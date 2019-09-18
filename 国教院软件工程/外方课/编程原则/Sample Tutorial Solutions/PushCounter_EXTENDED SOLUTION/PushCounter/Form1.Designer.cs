namespace PushCounter {
    partial class Form1 {
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
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.buttonClickMe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clickCounterLabel = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.checkBoxCheck = new System.Windows.Forms.CheckBox();
            this.labelCheckMessage = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClickMe
            // 
            this.buttonClickMe.Location = new System.Drawing.Point(102, 39);
            this.buttonClickMe.Name = "buttonClickMe";
            this.buttonClickMe.Size = new System.Drawing.Size(75, 23);
            this.buttonClickMe.TabIndex = 3;
            this.buttonClickMe.Text = "Click me";
            this.buttonClickMe.Click += new System.EventHandler(this.buttonClickMe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "The button has been clicked";
            // 
            // clickCounterLabel
            // 
            this.clickCounterLabel.AutoSize = true;
            this.clickCounterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clickCounterLabel.Location = new System.Drawing.Point(122, 116);
            this.clickCounterLabel.Name = "clickCounterLabel";
            this.clickCounterLabel.Size = new System.Drawing.Size(40, 13);
            this.clickCounterLabel.TabIndex = 2;
            this.clickCounterLabel.Text = "0 times";
            // 
            // buttonReset
            // 
            this.buttonReset.Enabled = false;
            this.buttonReset.Location = new System.Drawing.Point(102, 208);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 4;
            this.buttonReset.Text = "reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // checkBoxCheck
            // 
            this.checkBoxCheck.AutoSize = true;
            this.checkBoxCheck.Location = new System.Drawing.Point(134, 150);
            this.checkBoxCheck.Name = "checkBoxCheck";
            this.checkBoxCheck.Size = new System.Drawing.Size(15, 14);
            this.checkBoxCheck.TabIndex = 5;
            this.checkBoxCheck.UseVisualStyleBackColor = true;
            this.checkBoxCheck.CheckedChanged += new System.EventHandler(this.checkBoxCheck_CheckedChanged);
            // 
            // labelCheckMessage
            // 
            this.labelCheckMessage.AutoSize = true;
            this.labelCheckMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheckMessage.Location = new System.Drawing.Point(68, 170);
            this.labelCheckMessage.Name = "labelCheckMessage";
            this.labelCheckMessage.Size = new System.Drawing.Size(204, 17);
            this.labelCheckMessage.TabIndex = 6;
            this.labelCheckMessage.Text = "The CheckBox is NOT checked";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(286, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 261);
            this.Controls.Add(this.labelCheckMessage);
            this.Controls.Add(this.checkBoxCheck);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.clickCounterLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonClickMe);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Click Counter";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Button buttonClickMe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label clickCounterLabel;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.CheckBox checkBoxCheck;
        private System.Windows.Forms.Label labelCheckMessage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
    }
}

