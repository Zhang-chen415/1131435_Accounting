namespace _1131435_張新誠_個人記帳系統
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTotal = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開啟檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存新檔ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編輯ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增帳目ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更新選取紀錄ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刪除選取紀錄ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvRecords = new System.Windows.Forms.DataGridView();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchNote = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFilterCategory = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("新細明體", 12F);
            this.labelTotal.Location = new System.Drawing.Point(-3, 296);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(127, 16);
            this.labelTotal.TabIndex = 9;
            this.labelTotal.Text = "目前總金額 : 0 元";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案ToolStripMenuItem,
            this.編輯ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(306, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 檔案ToolStripMenuItem
            // 
            this.檔案ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開啟檔案ToolStripMenuItem,
            this.另存新檔ToolStripMenuItem});
            this.檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            this.檔案ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.檔案ToolStripMenuItem.Text = "檔案";
            // 
            // 開啟檔案ToolStripMenuItem
            // 
            this.開啟檔案ToolStripMenuItem.Name = "開啟檔案ToolStripMenuItem";
            this.開啟檔案ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.開啟檔案ToolStripMenuItem.Text = "📂 開啟檔案";
            this.開啟檔案ToolStripMenuItem.Click += new System.EventHandler(this.開啟檔案ToolStripMenuItem_Click);
            // 
            // 另存新檔ToolStripMenuItem
            // 
            this.另存新檔ToolStripMenuItem.Name = "另存新檔ToolStripMenuItem";
            this.另存新檔ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.另存新檔ToolStripMenuItem.Text = "💾 另存新檔";
            this.另存新檔ToolStripMenuItem.Click += new System.EventHandler(this.另存新檔ToolStripMenuItem_Click);
            // 
            // 編輯ToolStripMenuItem
            // 
            this.編輯ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增帳目ToolStripMenuItem,
            this.更新選取紀錄ToolStripMenuItem,
            this.刪除選取紀錄ToolStripMenuItem});
            this.編輯ToolStripMenuItem.Name = "編輯ToolStripMenuItem";
            this.編輯ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.編輯ToolStripMenuItem.Text = "編輯";
            // 
            // 新增帳目ToolStripMenuItem
            // 
            this.新增帳目ToolStripMenuItem.Name = "新增帳目ToolStripMenuItem";
            this.新增帳目ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.新增帳目ToolStripMenuItem.Text = "新增帳目";
            this.新增帳目ToolStripMenuItem.Click += new System.EventHandler(this.新增帳目ToolStripMenuItem_Click);
            // 
            // 更新選取紀錄ToolStripMenuItem
            // 
            this.更新選取紀錄ToolStripMenuItem.Name = "更新選取紀錄ToolStripMenuItem";
            this.更新選取紀錄ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.更新選取紀錄ToolStripMenuItem.Text = "更新選取紀錄";
            this.更新選取紀錄ToolStripMenuItem.Click += new System.EventHandler(this.更新選取紀錄ToolStripMenuItem_Click);
            // 
            // 刪除選取紀錄ToolStripMenuItem
            // 
            this.刪除選取紀錄ToolStripMenuItem.Name = "刪除選取紀錄ToolStripMenuItem";
            this.刪除選取紀錄ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.刪除選取紀錄ToolStripMenuItem.Text = "刪除選取紀錄";
            this.刪除選取紀錄ToolStripMenuItem.Click += new System.EventHandler(this.刪除選取紀錄ToolStripMenuItem_Click);
            // 
            // dgvRecords
            // 
            this.dgvRecords.AllowUserToAddRows = false;
            this.dgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCategory,
            this.colAmount,
            this.colNote});
            this.dgvRecords.Location = new System.Drawing.Point(0, 53);
            this.dgvRecords.MultiSelect = false;
            this.dgvRecords.Name = "dgvRecords";
            this.dgvRecords.ReadOnly = true;
            this.dgvRecords.RowTemplate.Height = 24;
            this.dgvRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecords.Size = new System.Drawing.Size(306, 233);
            this.dgvRecords.TabIndex = 11;
            this.dgvRecords.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colCategory
            // 
            this.colCategory.HeaderText = "類別";
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;
            this.colCategory.Width = 75;
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "金額";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            this.colAmount.Width = 75;
            // 
            // colNote
            // 
            this.colNote.HeaderText = "備註";
            this.colNote.Name = "colNote";
            this.colNote.ReadOnly = true;
            this.colNote.Width = 150;
            // 
            // txtSearchNote
            // 
            this.txtSearchNote.Location = new System.Drawing.Point(194, 27);
            this.txtSearchNote.Name = "txtSearchNote";
            this.txtSearchNote.Size = new System.Drawing.Size(112, 22);
            this.txtSearchNote.TabIndex = 12;
            this.txtSearchNote.TextChanged += new System.EventHandler(this.txtSearchNote_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 10F);
            this.label1.Location = new System.Drawing.Point(130, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 13;
            this.label1.Text = "搜尋備註";
            // 
            // cbFilterCategory
            // 
            this.cbFilterCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterCategory.FormattingEnabled = true;
            this.cbFilterCategory.Items.AddRange(new object[] {
            "全部",
            "食",
            "衣",
            "住",
            "行",
            "收入",
            "娛樂",
            "其他支出"});
            this.cbFilterCategory.Location = new System.Drawing.Point(3, 27);
            this.cbFilterCategory.Name = "cbFilterCategory";
            this.cbFilterCategory.Size = new System.Drawing.Size(121, 20);
            this.cbFilterCategory.TabIndex = 14;
            this.cbFilterCategory.SelectedIndexChanged += new System.EventHandler(this.cbFilterCategory_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 321);
            this.Controls.Add(this.cbFilterCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchNote);
            this.Controls.Add(this.dgvRecords);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "記帳系統";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 檔案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開啟檔案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存新檔ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編輯ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增帳目ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更新選取紀錄ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刪除選取紀錄ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvRecords;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNote;
        private System.Windows.Forms.TextBox txtSearchNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFilterCategory;
    }
}

