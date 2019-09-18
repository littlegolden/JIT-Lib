namespace CurrencyApp {
    partial class FormCurrencyApp {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.labelHeading = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelConversion = new System.Windows.Forms.Label();
            this.labelConvertedAmount = new System.Windows.Forms.Label();
            this.textBoxAUD = new System.Windows.Forms.TextBox();
            this.textBoxConvertedAmount = new System.Windows.Forms.TextBox();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.labelCurrency = new System.Windows.Forms.Label();
            this.comboBoxCurrency = new System.Windows.Forms.ComboBox();
            this.listBoxConversionRate = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loadDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHeading
            // 
            this.labelHeading.AutoSize = true;
            this.labelHeading.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeading.Location = new System.Drawing.Point(192, 0);
            this.labelHeading.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(259, 28);
            this.labelHeading.TabIndex = 0;
            this.labelHeading.Text = "Currency Converter";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(12, 70);
            this.labelAmount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(139, 20);
            this.labelAmount.TabIndex = 0;
            this.labelAmount.Text = "Amount in AUD:";
            // 
            // labelConversion
            // 
            this.labelConversion.AutoSize = true;
            this.labelConversion.Location = new System.Drawing.Point(12, 180);
            this.labelConversion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelConversion.Name = "labelConversion";
            this.labelConversion.Size = new System.Drawing.Size(143, 20);
            this.labelConversion.TabIndex = 0;
            this.labelConversion.Text = "Conversion Rate:";
            // 
            // labelConvertedAmount
            // 
            this.labelConvertedAmount.AutoSize = true;
            this.labelConvertedAmount.Location = new System.Drawing.Point(12, 231);
            this.labelConvertedAmount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelConvertedAmount.Name = "labelConvertedAmount";
            this.labelConvertedAmount.Size = new System.Drawing.Size(162, 20);
            this.labelConvertedAmount.TabIndex = 0;
            this.labelConvertedAmount.Text = "Converted Amount:";
            // 
            // textBoxAUD
            // 
            this.textBoxAUD.Location = new System.Drawing.Point(236, 67);
            this.textBoxAUD.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxAUD.Name = "textBoxAUD";
            this.textBoxAUD.Size = new System.Drawing.Size(184, 26);
            this.textBoxAUD.TabIndex = 1;
            this.textBoxAUD.Text = "1";
            this.textBoxAUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxConvertedAmount
            // 
            this.textBoxConvertedAmount.Enabled = false;
            this.textBoxConvertedAmount.Location = new System.Drawing.Point(236, 223);
            this.textBoxConvertedAmount.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxConvertedAmount.Name = "textBoxConvertedAmount";
            this.textBoxConvertedAmount.Size = new System.Drawing.Size(182, 26);
            this.textBoxConvertedAmount.TabIndex = 1;
            this.textBoxConvertedAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonConvert
            // 
            this.buttonConvert.BackColor = System.Drawing.Color.Navy;
            this.buttonConvert.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConvert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonConvert.Location = new System.Drawing.Point(81, 285);
            this.buttonConvert.Margin = new System.Windows.Forms.Padding(5);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(185, 43);
            this.buttonConvert.TabIndex = 2;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = false;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // labelCurrency
            // 
            this.labelCurrency.AutoSize = true;
            this.labelCurrency.Location = new System.Drawing.Point(12, 128);
            this.labelCurrency.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCurrency.Name = "labelCurrency";
            this.labelCurrency.Size = new System.Drawing.Size(153, 20);
            this.labelCurrency.TabIndex = 0;
            this.labelCurrency.Text = "Currency Chosen:";
            // 
            // comboBoxCurrency
            // 
            this.comboBoxCurrency.FormattingEnabled = true;
            this.comboBoxCurrency.Items.AddRange(new object[] {
            "British Pounds",
            "Chinese CNY",
            "Euro",
            "US Dollar",
            "Canadian Dollar"});
            this.comboBoxCurrency.Location = new System.Drawing.Point(236, 125);
            this.comboBoxCurrency.Name = "comboBoxCurrency";
            this.comboBoxCurrency.Size = new System.Drawing.Size(182, 28);
            this.comboBoxCurrency.TabIndex = 4;
            this.comboBoxCurrency.SelectedIndexChanged += new System.EventHandler(this.comboBoxCurrency_SelectedIndexChanged);
            // 
            // listBoxConversionRate
            // 
            this.listBoxConversionRate.Enabled = false;
            this.listBoxConversionRate.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxConversionRate.FormattingEnabled = true;
            this.listBoxConversionRate.ItemHeight = 20;
            this.listBoxConversionRate.Items.AddRange(new object[] {
            "0.538612",
            "4.75631",
            "0.615986",
            "0.688746",
            "0.924343"});
            this.listBoxConversionRate.Location = new System.Drawing.Point(236, 180);
            this.listBoxConversionRate.Name = "listBoxConversionRate";
            this.listBoxConversionRate.Size = new System.Drawing.Size(182, 24);
            this.listBoxConversionRate.TabIndex = 5;
            this.listBoxConversionRate.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDataToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(451, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loadDataToolStripMenuItem
            // 
            this.loadDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.loadDataToolStripMenuItem.Name = "loadDataToolStripMenuItem";
            this.loadDataToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.loadDataToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormCurrencyApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(451, 365);
            this.Controls.Add(this.listBoxConversionRate);
            this.Controls.Add(this.comboBoxCurrency);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.textBoxConvertedAmount);
            this.Controls.Add(this.textBoxAUD);
            this.Controls.Add(this.labelConvertedAmount);
            this.Controls.Add(this.labelCurrency);
            this.Controls.Add(this.labelConversion);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelHeading);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormCurrencyApp";
            this.Text = "Currency Conversion App";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelConversion;
        private System.Windows.Forms.Label labelConvertedAmount;
        private System.Windows.Forms.TextBox textBoxAUD;
        private System.Windows.Forms.TextBox textBoxConvertedAmount;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Label labelCurrency;
        private System.Windows.Forms.ComboBox comboBoxCurrency;
        private System.Windows.Forms.ListBox listBoxConversionRate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    }
}

