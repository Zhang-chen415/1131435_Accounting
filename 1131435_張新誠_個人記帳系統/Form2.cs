using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1131435_張新誠_個人記帳系統
{
    public partial class Form2 : Form
    {
        public string Category { get; set; }
        public string Amount { get; set; }
        public string Note { get; set; }
        public Form2()
        {
            InitializeComponent();
            if (comboBoxCategory.Items.Count > 0)
            {
                comboBoxCategory.SelectedIndex = 0; // 預設選第一個項目
            }
        }
        public void SetOriginalData(string category, string amount, string note)
        {
            comboBoxCategory.SelectedItem = category;
            textBoxAmount.Text = amount;
            textBoxNote.Text = note;
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxAmount.Text) || string.IsNullOrWhiteSpace(textBoxNote.Text))
            {
                MessageBox.Show("金額與備註不能為空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 將輸入框的值存進屬性中
            Category = comboBoxCategory.SelectedItem.ToString();
            Amount = textBoxAmount.Text;
            Note = textBoxNote.Text;

            // 關鍵：設定 DialogResult 為 OK，代表使用者是正常完成輸入
            this.DialogResult = DialogResult.OK;
            this.Close(); // 關閉小視窗
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
