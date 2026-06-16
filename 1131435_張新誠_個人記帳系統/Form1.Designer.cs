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
            this.listBoxRecords = new System.Windows.Forms.ListBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開啟檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存新檔ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編輯ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增帳目ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更新選取紀錄ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刪除選取紀錄ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxRecords
            // 
            this.listBoxRecords.FormattingEnabled = true;
            this.listBoxRecords.ItemHeight = 12;
            this.listBoxRecords.Location = new System.Drawing.Point(0, 26);
            this.listBoxRecords.Name = "listBoxRecords";
            this.listBoxRecords.Size = new System.Drawing.Size(304, 232);
            this.listBoxRecords.TabIndex = 4;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("新細明體", 12F);
            this.labelTotal.Location = new System.Drawing.Point(12, 263);
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
            this.新增帳目ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.新增帳目ToolStripMenuItem.Text = "新增帳目";
            this.新增帳目ToolStripMenuItem.Click += new System.EventHandler(this.新增帳目ToolStripMenuItem_Click);
            // 
            // 更新選取紀錄ToolStripMenuItem
            // 
            this.更新選取紀錄ToolStripMenuItem.Name = "更新選取紀錄ToolStripMenuItem";
            this.更新選取紀錄ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.更新選取紀錄ToolStripMenuItem.Text = "更新選取紀錄";
            this.更新選取紀錄ToolStripMenuItem.Click += new System.EventHandler(this.更新選取紀錄ToolStripMenuItem_Click);
            // 
            // 刪除選取紀錄ToolStripMenuItem
            // 
            this.刪除選取紀錄ToolStripMenuItem.Name = "刪除選取紀錄ToolStripMenuItem";
            this.刪除選取紀錄ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.刪除選取紀錄ToolStripMenuItem.Text = "刪除選取紀錄";
            this.刪除選取紀錄ToolStripMenuItem.Click += new System.EventHandler(this.刪除選取紀錄ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 284);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.listBoxRecords);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxRecords;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 檔案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開啟檔案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存新檔ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編輯ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增帳目ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更新選取紀錄ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刪除選取紀錄ToolStripMenuItem;
    }
}

