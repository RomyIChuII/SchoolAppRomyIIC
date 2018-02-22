namespace SchoolAppRomyIIC
{
    partial class frmSchoolAppWithMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSchoolName = new System.Windows.Forms.Label();
            this.lblNamOfTeam = new System.Windows.Forms.Label();
            this.mnuFileMenu = new System.Windows.Forms.MenuStrip();
            this.mniFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSchoolName
            // 
            this.lblSchoolName.AutoSize = true;
            this.lblSchoolName.BackColor = System.Drawing.Color.BurlyWood;
            this.lblSchoolName.Font = new System.Drawing.Font("Monospac821 BT", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchoolName.Location = new System.Drawing.Point(106, 106);
            this.lblSchoolName.Name = "lblSchoolName";
            this.lblSchoolName.Size = new System.Drawing.Size(416, 39);
            this.lblSchoolName.TabIndex = 0;
            this.lblSchoolName.Text = "Immaculata HighSchool";
            this.lblSchoolName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNamOfTeam
            // 
            this.lblNamOfTeam.AutoSize = true;
            this.lblNamOfTeam.BackColor = System.Drawing.Color.BurlyWood;
            this.lblNamOfTeam.Font = new System.Drawing.Font("Monospac821 BT", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamOfTeam.Location = new System.Drawing.Point(210, 168);
            this.lblNamOfTeam.Name = "lblNamOfTeam";
            this.lblNamOfTeam.Size = new System.Drawing.Size(131, 39);
            this.lblNamOfTeam.TabIndex = 1;
            this.lblNamOfTeam.Text = "SAINTS";
            // 
            // mnuFileMenu
            // 
            this.mnuFileMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFileMenu});
            this.mnuFileMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuFileMenu.Name = "mnuFileMenu";
            this.mnuFileMenu.Size = new System.Drawing.Size(581, 24);
            this.mnuFileMenu.TabIndex = 3;
            this.mnuFileMenu.Text = "File";
            // 
            // mniFileMenu
            // 
            this.mniFileMenu.BackColor = System.Drawing.Color.Gold;
            this.mniFileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniFileMenu.Name = "mniFileMenu";
            this.mniFileMenu.Size = new System.Drawing.Size(37, 20);
            this.mniFileMenu.Text = "File";
            this.mniFileMenu.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(152, 22);
            this.mniExit.Text = "EXIT";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // frmSchoolAppWithMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(581, 294);
            this.Controls.Add(this.lblNamOfTeam);
            this.Controls.Add(this.lblSchoolName);
            this.Controls.Add(this.mnuFileMenu);
            this.Name = "frmSchoolAppWithMenu";
            this.Text = "School App With Menu";
            this.mnuFileMenu.ResumeLayout(false);
            this.mnuFileMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSchoolName;
        private System.Windows.Forms.Label lblNamOfTeam;
        private System.Windows.Forms.MenuStrip mnuFileMenu;
        private System.Windows.Forms.ToolStripMenuItem mniFileMenu;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
    }
}

