using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _1131435_張新誠_個人記帳系統
{
    public partial class Form1 : Form
    {
        private bool isUnsaved = false;
        public Form1()
        {
            InitializeComponent();
        }

        
        private void UpdateTotalAmount()
        {
            int total = 0;

            // 依序檢查 ListBox 裡面的每一行紀錄
            foreach (var item in listBoxRecords.Items)
            {
                string record = item.ToString();
                string[] parts = record.Split(',');

                if (parts.Length == 3)
                {
                    string category = parts[0];
                    // 嘗試將金額字串轉成整數，轉換成功才計算（防呆）
                    if (int.TryParse(parts[1], out int amount))
                    {
                        // 如果類別是 "收入"，就加錢；其餘（食衣住行）都算支出，扣錢
                        if (category == "收入")
                        {
                            total += amount;
                        }
                        else
                        {
                            total -= amount;
                        }
                    }
                }
            }

            // 更新右下角或下方的 Label 顯示
            labelTotal.Text = $"目前總金額：{total} 元";

            // 亮點功能：如果透支（總金額變負數），就把字體變成紅色提醒；正數就維持黑色
            if (total < 0)
            {
                labelTotal.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                labelTotal.ForeColor = System.Drawing.Color.Black;
            }
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateTotalAmount();
        }


        private void 新增帳目ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 1. 實體化 Form2 視窗
            Form2 inputForm = new Form2();
            inputForm.Text = "新增記帳紀錄"; // 設定新視窗的標題

            // 2. 用 ShowDialog() 彈出視窗（這會強制使用者必須先處理這個小視窗）
            // 如果使用者在 Form2 按下了「確定」
            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                // 3. 從 Form2 物件中，把剛才填好的屬性值撈出來
                string category = inputForm.Category;
                string amount = inputForm.Amount;
                string note = inputForm.Note;

                // 4. 接下來就是你原本熟悉的新增邏輯囉！
                string recordLine = $"{category},{amount},{note}";
                listBoxRecords.Items.Add(recordLine);

                // 更新總金額
                UpdateTotalAmount();
                isUnsaved = true;
            }
        }

        private void 刪除選取紀錄ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 防呆：檢查使用者有沒有在 ListBox 點選任何項目
            if (listBoxRecords.SelectedIndex == -1)
            {
                MessageBox.Show("請先在清單中點選一筆要刪除的紀錄！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isUnsaved = true;
                return;
            }

            // 詢問使用者是否確定要刪除（做防呆確認，UI 介面大加分項目）
            DialogResult result = MessageBox.Show("確定要刪除這筆紀錄嗎？", "確認刪除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // 從 ListBox 中移除目前選中的那一項
                listBoxRecords.Items.RemoveAt(listBoxRecords.SelectedIndex);

                // 重新計算並更新總金額 Label
                UpdateTotalAmount();

                MessageBox.Show("紀錄已成功刪除！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void 更新選取紀錄ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 1. 防呆：檢查有沒有點選要修改的項目
            if (listBoxRecords.SelectedIndex == -1)
            {
                MessageBox.Show("請先在清單中點選一筆要修改的紀錄！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isUnsaved = true;
                return;
            }

            // 2. 抓取目前選中的舊字串（例如："食,100,午餐"）
            int selectedIndex = listBoxRecords.SelectedIndex;
            string selectedRecord = listBoxRecords.SelectedItem.ToString();
            string[] parts = selectedRecord.Split(',');

            if (parts.Length == 3)
            {
                // 3. 實體化 Form2 小視窗
                Form2 editForm = new Form2();
                editForm.Text = "編輯記帳紀錄"; // 標題改成編輯

                // 4. 關鍵：把原本舊的「類別、金額、備註」塞進 Form2 的輸入框裡
                editForm.SetOriginalData(parts[0], parts[1], parts[2]);

                // 5. 彈出 Form2 視窗，並等待使用者按下「確定」
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    // 6. 撈出使用者修改後的新資料
                    string newCategory = editForm.Category;
                    string newAmount = editForm.Amount;
                    string newNote = editForm.Note;

                    // 7. 組合成新字串，並替換掉 ListBox 裡原本位置的那一項
                    string updatedLine = $"{newCategory},{newAmount},{newNote}";
                    listBoxRecords.Items[selectedIndex] = updatedLine;

                    // 8. 重新計算並更新總金額 Label
                    UpdateTotalAmount();

                    MessageBox.Show("紀錄已成功更新！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void 另存新檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBoxRecords.Items.Count == 0)
            {
                MessageBox.Show("目前沒有任何記帳紀錄可以儲存！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "文字檔案 (*.txt)|*.txt|CSV 檔案 (*.csv)|*.csv";
            saveFileDialog.Title = "將記帳紀錄另存新檔";
            saveFileDialog.FileName = "我的帳本"; // 預設檔名

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName, false))
                    {
                        foreach (var item in listBoxRecords.Items)
                        {
                            sw.WriteLine(item.ToString());
                        }
                    }
                    MessageBox.Show("檔案另存成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"儲存失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void 開啟檔案ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "文字檔案 (*.txt)|*.txt|CSV 檔案 (*.csv)|*.csv";
            openFileDialog.Title = "選擇要讀取的記帳檔案";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    listBoxRecords.Items.Clear();

                    using (StreamReader sr = new StreamReader(openFileDialog.FileName))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            if (!string.IsNullOrWhiteSpace(line))
                            {
                                listBoxRecords.Items.Add(line);
                            }
                        }
                    }

                    // 讀取完畢後立刻重新計算總金額
                    UpdateTotalAmount();
                    isUnsaved = false;
                    MessageBox.Show("檔案載入成功！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"讀取失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 如果發現目前有尚未儲存的變動
            if (isUnsaved)
            {
                // 彈出對話框詢問：要存檔、不存檔、還是取消關閉？
                DialogResult result = MessageBox.Show(
                    "您有尚未儲存的記帳紀錄，是否要在關閉前進行儲存？\n\n[是]：進行存檔\n[否]：直接關閉(放棄變動)\n[取消]：回到程式",
                    "提醒",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    // 使用者想存檔，直接幫他觸發剛才寫好的「另存新檔」選單事件
                    另存新檔ToolStripMenuItem_Click(sender, e);

                    // 存完檔之後，如果使用者在存檔視窗按了取消，isUnsaved 還會是 true
                    // 為了保險起見，我們檢查如果還是 true，就攔截不要關閉
                    if (isUnsaved)
                    {
                        e.Cancel = true; // 攔截關閉動作
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    // 使用者點選「取消」，代表他不想關閉程式了
                    e.Cancel = true; // 關鍵：這行可以把關閉視窗的動作攔截、取消掉！
                }
                // 如果使用者點選「否」，就什麼都不做，程式會依循預設流程直接關閉，舊資料直接消失
            }
        }
    }
}
