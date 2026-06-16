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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.txtSearchNote = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFilterCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBudget = new System.Windows.Forms.TextBox();
            this.lblBudgetStatus = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("新細明體", 12F);
            this.labelTotal.Location = new System.Drawing.Point(0, 272);
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
            this.menuStrip1.Size = new System.Drawing.Size(371, 24);
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
            this.dgvRecords.Location = new System.Drawing.Point(3, 29);
            this.dgvRecords.MultiSelect = false;
            this.dgvRecords.Name = "dgvRecords";
            this.dgvRecords.ReadOnly = true;
            this.dgvRecords.RowTemplate.Height = 24;
            this.dgvRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecords.Size = new System.Drawing.Size(358, 233);
            this.dgvRecords.TabIndex = 11;
            this.dgvRecords.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtSearchNote
            // 
            this.txtSearchNote.Location = new System.Drawing.Point(249, 3);
            this.txtSearchNote.Name = "txtSearchNote";
            this.txtSearchNote.Size = new System.Drawing.Size(112, 22);
            this.txtSearchNote.TabIndex = 12;
            this.txtSearchNote.TextChanged += new System.EventHandler(this.txtSearchNote_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 10F);
            this.label1.Location = new System.Drawing.Point(180, 6);
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
            this.cbFilterCategory.Location = new System.Drawing.Point(6, 3);
            this.cbFilterCategory.Name = "cbFilterCategory";
            this.cbFilterCategory.Size = new System.Drawing.Size(121, 20);
            this.cbFilterCategory.TabIndex = 14;
            this.cbFilterCategory.SelectedIndexChanged += new System.EventHandler(this.cbFilterCategory_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "預算上限";
            // 
            // txtBudget
            // 
            this.txtBudget.Location = new System.Drawing.Point(261, 272);
            this.txtBudget.MaxLength = 10;
            this.txtBudget.Name = "txtBudget";
            this.txtBudget.Size = new System.Drawing.Size(100, 22);
            this.txtBudget.TabIndex = 16;
            this.txtBudget.TextChanged += new System.EventHandler(this.txtBudget_TextChanged);
            this.txtBudget.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBudget_KeyDown);
            this.txtBudget.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBudget_KeyPress);
            this.txtBudget.Leave += new System.EventHandler(this.txtBudget_Leave);
            // 
            // lblBudgetStatus
            // 
            this.lblBudgetStatus.AutoSize = true;
            this.lblBudgetStatus.Location = new System.Drawing.Point(6, 295);
            this.lblBudgetStatus.Name = "lblBudgetStatus";
            this.lblBudgetStatus.Size = new System.Drawing.Size(0, 12);
            this.lblBudgetStatus.TabIndex = 17;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(375, 338);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbFilterCategory);
            this.tabPage1.Controls.Add(this.lblBudgetStatus);
            this.tabPage1.Controls.Add(this.labelTotal);
            this.tabPage1.Controls.Add(this.txtBudget);
            this.tabPage1.Controls.Add(this.dgvRecords);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtSearchNote);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(367, 312);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "帳務明細";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(367, 312);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "統計圖表";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(361, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // colCategory
            // 
            this.colCategory.HeaderText = "類別";
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;
            this.colCategory.Width = 80;
            // 
            // colAmount
            // 
            this.colAmount.HeaderText = "金額";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            this.colAmount.Width = 80;
            // 
            // colNote
            // 
            this.colNote.HeaderText = "備註";
            this.colNote.Name = "colNote";
            this.colNote.ReadOnly = true;
            this.colNote.Width = 160;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 361);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "記帳系統";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
        private System.Windows.Forms.TextBox txtSearchNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFilterCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBudget;
        private System.Windows.Forms.Label lblBudgetStatus;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNote;
    }
}

