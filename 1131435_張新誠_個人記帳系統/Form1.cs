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

        private void ApplyFilter()
        {
            // 取得目前輸入的關鍵字（轉小寫，去前後空格）
            string keyword = txtSearchNote.Text.Trim().ToLower();

            // 取得目前下拉選單選了什麼類別
            string selectedCategory = cbFilterCategory.SelectedItem?.ToString() ?? "全部";

            // 暫時解除 DataGridView 正在被滑鼠點選的行，避免隱藏選中行時報錯
            dgvRecords.CurrentCell = null;

            foreach (DataGridViewRow row in dgvRecords.Rows)
            {
                // 跳過完全空白的新增列
                if (row.Cells["colCategory"].Value == null) continue;

                string category = row.Cells["colCategory"].Value.ToString();
                string note = row.Cells["colNote"].Value.ToString().ToLower();

                // 1. 比對類別是否符合 (如果是選"全部"、或者列的類別跟選取的一樣，即為合法的類別)
                bool isCategoryMatch = (selectedCategory == "全部" || category == selectedCategory);

                // 2. 比對備註關鍵字是否符合 (如果是空的、或者備註包含關鍵字，即為合法的關鍵字)
                bool isKeywordMatch = (string.IsNullOrEmpty(keyword) || note.Contains(keyword));

                // 3. 只有當兩個條件同時滿足時，這一列才顯示，否則隱藏
                row.Visible = (isCategoryMatch && isKeywordMatch);
            }

            // 篩選完畫面後，重新計算「目前看得到」的總金額！
            UpdateTotalAmount();
        }
        private void UpdateChart()
        {
            // 1. 建立一個字典(Dictionary)來儲存各支出的加總
            Dictionary<string, long> expenseStats = new Dictionary<string, long>()
    {
        { "食", 0 }, { "衣", 0 }, { "住", 0 }, { "行", 0 }, { "娛樂", 0 }, { "其他支出", 0 }
    };

            // 2. 掃描 DataGridView 表格累加金額
            foreach (DataGridViewRow row in dgvRecords.Rows)
            {
                if (row.Cells["colCategory"].Value == null) continue;

                string category = row.Cells["colCategory"].Value.ToString();
                string amountStr = row.Cells["colAmount"].Value.ToString();

                if (long.TryParse(amountStr, out long amount))
                {
                    // 如果是支出種類，就加進對應的分類裡
                    if (expenseStats.ContainsKey(category))
                    {
                        expenseStats[category] += amount;
                    }
                }
            }

            // 3. 清空圖表舊資料
            chart1.Series["Series1"].Points.Clear();

            // 4. 將有花錢的項目塞進圓餅圖裡
            foreach (var pair in expenseStats)
            {
                if (pair.Value > 0) // 金額大於 0 元的才顯示，畫面比較乾淨
                {
                    // 新增資料點（X軸是類別名稱如"食"，Y軸是總金額）
                    int pointIndex = chart1.Series["Series1"].Points.AddXY(pair.Key, pair.Value);

                    // 讓圓餅圖上同時顯示「類別」與「金額」（例如：食 (500元)）
                    chart1.Series["Series1"].Points[pointIndex].Label = $"{pair.Key}\n({pair.Value}元)";
                }
            }
        }
        private void UpdateTotalAmount(bool showAlert = false)
        {
            long total = 0;
            long totalExpense = 0;

            foreach (DataGridViewRow row in dgvRecords.Rows)
            {
                if (row.Cells["colCategory"].Value == null) continue;
                if (!row.Visible) continue;

                string category = row.Cells["colCategory"].Value.ToString();
                string amountStr = row.Cells["colAmount"].Value.ToString();

                if (long.TryParse(amountStr, out long amount))
                {
                    if (category == "收入")
                    {
                        total += amount;
                    }
                    else
                    {
                        total -= amount;
                        totalExpense += amount;
                    }
                }
            }

            // 更新總金額顯示
            labelTotal.Text = $"目前總金額：{total} 元";
            labelTotal.ForeColor = (total < 0) ? System.Drawing.Color.Red : System.Drawing.Color.Black;

            // ======= 預算檢查邏輯 =======
            if (long.TryParse(txtBudget.Text, out long budgetLimit) && budgetLimit > 0)
            {
                if (totalExpense > budgetLimit)
                {
                    lblBudgetStatus.Text = $"⚠️ 已超支！(總支出：{totalExpense} / 預算：{budgetLimit})";
                    lblBudgetStatus.ForeColor = System.Drawing.Color.Red;

                    // 💡 修改點：只有當傳入的 showAlert 為 true 時，才跳出 MessageBox 彈窗！
                    if (showAlert)
                    {
                        MessageBox.Show($"警告：您本月的總支出 ({totalExpense} 元) 已經超過設定的預算上限 ({budgetLimit} 元)！請節約開支。",
                                        "預算超額警示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    lblBudgetStatus.Text = $"✅ 預算內 (總支出：{totalExpense} / 預算：{budgetLimit})";
                    lblBudgetStatus.ForeColor = System.Drawing.Color.Green;
                }
            }
            else
            {
                lblBudgetStatus.Text = "（未設定預算上限）";
                lblBudgetStatus.ForeColor = System.Drawing.Color.Gray;
            }

            // 更新圖表
            UpdateChart();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateTotalAmount();
            cbFilterCategory.SelectedIndex = 0;
        }


        private void 新增帳目ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 inputForm = new Form2();
            inputForm.Text = "新增記帳紀錄";

            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                // 直接將類別、金額、備註作為三個獨立參數塞進表格
                dgvRecords.Rows.Add(inputForm.Category, inputForm.Amount, inputForm.Note);

                UpdateTotalAmount();
                isUnsaved = true; // 觸發未存檔警示
                UpdateTotalAmount(true);
            }
        }

        private void 刪除選取紀錄ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 防呆：檢查目前有沒有選中任何一列
            if (dgvRecords.SelectedRows.Count == 0)
            {
                MessageBox.Show("請先在表格中點選一筆要刪除的紀錄！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("確定要刪除這筆紀錄嗎？", "確認刪除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // 移除被選取的那一列
                dgvRecords.Rows.Remove(dgvRecords.SelectedRows[0]);

                UpdateTotalAmount();
                isUnsaved = true;
                MessageBox.Show("紀錄已成功刪除！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void 更新選取紀錄ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvRecords.SelectedRows.Count == 0)
            {
                MessageBox.Show("請先在表格中點選一筆要修改的紀錄！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 抓出目前選中的那一列
            DataGridViewRow selectedRow = dgvRecords.SelectedRows[0];

            Form2 editForm = new Form2();
            editForm.Text = "編輯記帳紀錄";

            // 直接從儲存格把舊資料傳入 Form2
            editForm.SetOriginalData(
                selectedRow.Cells["colCategory"].Value.ToString(),
                selectedRow.Cells["colAmount"].Value.ToString(),
                selectedRow.Cells["colNote"].Value.ToString()
            );

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                // 將使用者修改後的新資料更新回原欄位
                selectedRow.Cells["colCategory"].Value = editForm.Category;
                selectedRow.Cells["colAmount"].Value = editForm.Amount;
                selectedRow.Cells["colNote"].Value = editForm.Note;

                UpdateTotalAmount();
                isUnsaved = true;
                MessageBox.Show("紀錄已成功更新！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void 另存新檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvRecords.Rows.Count == 0)
            {
                MessageBox.Show("目前沒有任何記帳紀錄可以儲存！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "文字檔案 (*.txt)|*.txt|CSV 檔案 (*.csv)|*.csv";
            saveFileDialog.Title = "將記帳紀錄另存新檔";
            saveFileDialog.FileName = "我的帳本";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName, false))
                    {
                        // 在檔案的最前方，固定塞入目前設定的預算數字
                        string budgetText = string.IsNullOrWhiteSpace(txtBudget.Text) ? "0" : txtBudget.Text;
                        sw.WriteLine($"預算,{budgetText},");

                        // 接下來才寫入明細
                        foreach (DataGridViewRow row in dgvRecords.Rows)
                        {
                            if (row.Cells["colCategory"].Value != null)
                            {
                                string line = $"{row.Cells["colCategory"].Value},{row.Cells["colAmount"].Value},{row.Cells["colNote"].Value}";
                                sw.WriteLine(line);
                            }
                        }
                    }
                    isUnsaved = false;
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
                    dgvRecords.Rows.Clear();

                    using (StreamReader sr = new StreamReader(openFileDialog.FileName))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            if (!string.IsNullOrWhiteSpace(line))
                            {
                                string[] parts = line.Split(',');
                                if (parts.Length >= 2)
                                {
                                    // ➕ 核心修改：如果這一行開頭是我們約定好的「預算」標籤
                                    if (parts[0] == "預算")
                                    {
                                        // 把預算數字填回主畫面的 TextBox 裡
                                        txtBudget.Text = parts[1] == "0" ? "" : parts[1];
                                    }
                                    else if (parts.Length == 3) // 否則就是一般的明細列
                                    {
                                        dgvRecords.Rows.Add(parts[0], parts[1], parts[2]);
                                    }
                                }
                            }
                        }
                    }

                    // 讀取完畢後立刻重新計算總金額（因為預算和明細都到位了，會完美觸發超支判定）
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearchNote_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void cbFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void txtBudget_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalAmount();
        }

        private void txtBudget_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 只能輸入數字與退格鍵
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtBudget_KeyDown(object sender, KeyEventArgs e)
        {
            // 如果使用者按下的是 Enter 鍵，代表輸入完了
            if (e.KeyCode == Keys.Enter)
            {
                UpdateTotalAmount(true); // 執行檢查，如果超支就跳彈窗
                e.SuppressKeyPress = true; // 防止視窗發出叮的一聲警告音
            }
        }

        private void txtBudget_Leave(object sender, EventArgs e)
        {
            // 當使用者打完字，滑鼠點去點別的地方（離開輸入框）時，也進行一次正式檢查
            UpdateTotalAmount(true);
        }

        private void 新增新檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 1. 安全檢查：如果目前有沒存檔的資料，先問使用者要不要存
            if (isUnsaved)
            {
                DialogResult result = MessageBox.Show(
                    "您目前有尚未儲存的變動，是否要在開啟新檔案前進行儲存？\n\n[是]：進行存檔\n[否]：放棄變動並開新檔\n[取消]：回到程式",
                    "提醒",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    // 幫他觸發另存新檔
                    另存新檔ToolStripMenuItem_Click(sender, e);

                    // 如果存完檔使用者按取消，或者依然是未存檔狀態，就攔截不開新檔
                    if (isUnsaved) return;
                }
                else if (result == DialogResult.Cancel)
                {
                    // 使用者點取消，直接結束這個 function，什麼都不做
                    return;
                }
            }

            // 2. 開始執行「全畫面清空重設」
            dgvRecords.Rows.Clear();        // 清空表格明細
            txtBudget.Text = "";            // 清空預算輸入框
            txtSearchNote.Text = "";        // 清空搜尋備註框
            cbFilterCategory.SelectedIndex = 0; // 分類選單回歸到「全部」

            // 3. 重新計算並更新總金額與圖表（此時會自動歸零、圖表會清空）
            UpdateTotalAmount();

            // 4. 重設變數：目前是全新乾淨的檔案，標記為已儲存狀態
            isUnsaved = false;

            MessageBox.Show("已建立新的空白帳本！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
