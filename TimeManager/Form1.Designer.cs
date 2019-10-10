namespace TimeManager
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anwendungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beeendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButtonPappe = new System.Windows.Forms.RadioButton();
            this.radioButtonMarrika = new System.Windows.Forms.RadioButton();
            this.labelChoose = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numericUpDownMinutes = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHours = new System.Windows.Forms.NumericUpDown();
            this.labelMinutes = new System.Windows.Forms.Label();
            this.labelHours = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSet = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anwendungToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anwendungToolStripMenuItem
            // 
            this.anwendungToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beeendenToolStripMenuItem});
            this.anwendungToolStripMenuItem.Name = "anwendungToolStripMenuItem";
            this.anwendungToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.anwendungToolStripMenuItem.Text = "Anwendung";
            // 
            // beeendenToolStripMenuItem
            // 
            this.beeendenToolStripMenuItem.Name = "beeendenToolStripMenuItem";
            this.beeendenToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.beeendenToolStripMenuItem.Text = "Beeenden";
            this.beeendenToolStripMenuItem.Click += new System.EventHandler(this.beeendenToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.labelInfo);
            this.panel1.Controls.Add(this.labelTime);
            this.panel1.Location = new System.Drawing.Point(30, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 49);
            this.panel1.TabIndex = 2;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelInfo.Location = new System.Drawing.Point(242, 16);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(0, 19);
            this.labelInfo.TabIndex = 2;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTime.Location = new System.Drawing.Point(24, 16);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(95, 22);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "15:16:43 ";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(30, 109);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButtonPappe);
            this.panel2.Controls.Add(this.radioButtonMarrika);
            this.panel2.Controls.Add(this.labelChoose);
            this.panel2.Location = new System.Drawing.Point(30, 161);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 84);
            this.panel2.TabIndex = 4;
            // 
            // radioButtonPappe
            // 
            this.radioButtonPappe.AutoSize = true;
            this.radioButtonPappe.Location = new System.Drawing.Point(28, 59);
            this.radioButtonPappe.Name = "radioButtonPappe";
            this.radioButtonPappe.Size = new System.Drawing.Size(81, 17);
            this.radioButtonPappe.TabIndex = 2;
            this.radioButtonPappe.TabStop = true;
            this.radioButtonPappe.Text = "SoftTechno";
            this.radioButtonPappe.UseVisualStyleBackColor = true;
            // 
            // radioButtonMarrika
            // 
            this.radioButtonMarrika.AutoSize = true;
            this.radioButtonMarrika.Location = new System.Drawing.Point(28, 35);
            this.radioButtonMarrika.Name = "radioButtonMarrika";
            this.radioButtonMarrika.Size = new System.Drawing.Size(85, 17);
            this.radioButtonMarrika.TabIndex = 1;
            this.radioButtonMarrika.TabStop = true;
            this.radioButtonMarrika.Text = "HardTechno";
            this.radioButtonMarrika.UseVisualStyleBackColor = true;
            // 
            // labelChoose
            // 
            this.labelChoose.AutoSize = true;
            this.labelChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChoose.Location = new System.Drawing.Point(15, 14);
            this.labelChoose.Name = "labelChoose";
            this.labelChoose.Size = new System.Drawing.Size(113, 17);
            this.labelChoose.TabIndex = 0;
            this.labelChoose.Text = "Auswahl der Melodie";
            this.labelChoose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelChoose.UseCompatibleTextRendering = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.numericUpDownMinutes);
            this.panel3.Controls.Add(this.numericUpDownHours);
            this.panel3.Controls.Add(this.labelMinutes);
            this.panel3.Controls.Add(this.labelHours);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(480, 124);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(235, 104);
            this.panel3.TabIndex = 5;
            // 
            // numericUpDownMinutes
            // 
            this.numericUpDownMinutes.Location = new System.Drawing.Point(113, 70);
            this.numericUpDownMinutes.Name = "numericUpDownMinutes";
            this.numericUpDownMinutes.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMinutes.TabIndex = 4;
            // 
            // numericUpDownHours
            // 
            this.numericUpDownHours.Location = new System.Drawing.Point(112, 35);
            this.numericUpDownHours.Name = "numericUpDownHours";
            this.numericUpDownHours.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownHours.TabIndex = 3;
            // 
            // labelMinutes
            // 
            this.labelMinutes.AutoSize = true;
            this.labelMinutes.Location = new System.Drawing.Point(17, 72);
            this.labelMinutes.Name = "labelMinutes";
            this.labelMinutes.Size = new System.Drawing.Size(48, 13);
            this.labelMinutes.TabIndex = 2;
            this.labelMinutes.Text = "Minuten:";
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Location = new System.Drawing.Point(17, 37);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(50, 13);
            this.labelHours.TabIndex = 1;
            this.labelHours.Text = "Stunden:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Einstellen der Arbeitszeit";
            // 
            // buttonSet
            // 
            this.buttonSet.AutoEllipsis = true;
            this.buttonSet.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSet.Location = new System.Drawing.Point(480, 258);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(75, 23);
            this.buttonSet.TabIndex = 6;
            this.buttonSet.Text = "Set";
            this.buttonSet.UseVisualStyleBackColor = false;
            this.buttonSet.Click += new System.EventHandler(this.buttonSet_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(641, 258);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 7;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonSet);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anwendungToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beeendenToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButtonPappe;
        private System.Windows.Forms.RadioButton radioButtonMarrika;
        private System.Windows.Forms.Label labelChoose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown numericUpDownMinutes;
        private System.Windows.Forms.NumericUpDown numericUpDownHours;
        private System.Windows.Forms.Label labelMinutes;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSet;
        private System.Windows.Forms.Button buttonStop;
    }
}

