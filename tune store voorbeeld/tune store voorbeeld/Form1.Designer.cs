namespace tune_store_voorbeeld
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNaamLsie = new System.Windows.Forms.TextBox();
            this.tbAddresLsie = new System.Windows.Forms.TextBox();
            this.tbWoonplaatsLsie = new System.Windows.Forms.TextBox();
            this.rtbOverzichtLsie = new System.Windows.Forms.RichTextBox();
            this.btnToevoegenLsie = new System.Windows.Forms.Button();
            this.btnShowLsie = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inschrijfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "naam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "addres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "woonplaats";
            // 
            // tbNaamLsie
            // 
            this.tbNaamLsie.Location = new System.Drawing.Point(125, 25);
            this.tbNaamLsie.Name = "tbNaamLsie";
            this.tbNaamLsie.Size = new System.Drawing.Size(100, 20);
            this.tbNaamLsie.TabIndex = 3;
            // 
            // tbAddresLsie
            // 
            this.tbAddresLsie.Location = new System.Drawing.Point(125, 50);
            this.tbAddresLsie.Name = "tbAddresLsie";
            this.tbAddresLsie.Size = new System.Drawing.Size(100, 20);
            this.tbAddresLsie.TabIndex = 3;
            // 
            // tbWoonplaatsLsie
            // 
            this.tbWoonplaatsLsie.Location = new System.Drawing.Point(125, 80);
            this.tbWoonplaatsLsie.Name = "tbWoonplaatsLsie";
            this.tbWoonplaatsLsie.Size = new System.Drawing.Size(100, 20);
            this.tbWoonplaatsLsie.TabIndex = 3;
            // 
            // rtbOverzichtLsie
            // 
            this.rtbOverzichtLsie.Location = new System.Drawing.Point(304, 25);
            this.rtbOverzichtLsie.Name = "rtbOverzichtLsie";
            this.rtbOverzichtLsie.ReadOnly = true;
            this.rtbOverzichtLsie.Size = new System.Drawing.Size(206, 150);
            this.rtbOverzichtLsie.TabIndex = 4;
            this.rtbOverzichtLsie.Text = "";
            // 
            // btnToevoegenLsie
            // 
            this.btnToevoegenLsie.Location = new System.Drawing.Point(12, 124);
            this.btnToevoegenLsie.Name = "btnToevoegenLsie";
            this.btnToevoegenLsie.Size = new System.Drawing.Size(74, 51);
            this.btnToevoegenLsie.TabIndex = 5;
            this.btnToevoegenLsie.Text = "toevoegen";
            this.btnToevoegenLsie.UseVisualStyleBackColor = true;
            this.btnToevoegenLsie.Click += new System.EventHandler(this.btnToevoegenLsie_Click);
            // 
            // btnShowLsie
            // 
            this.btnShowLsie.Location = new System.Drawing.Point(92, 124);
            this.btnShowLsie.Name = "btnShowLsie";
            this.btnShowLsie.Size = new System.Drawing.Size(74, 51);
            this.btnShowLsie.TabIndex = 5;
            this.btnShowLsie.Text = "show";
            this.btnShowLsie.UseVisualStyleBackColor = true;
            this.btnShowLsie.Click += new System.EventHandler(this.btnShowLsie_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inschrijfToolStripMenuItem,
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(524, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inschrijfToolStripMenuItem
            // 
            this.inschrijfToolStripMenuItem.Name = "inschrijfToolStripMenuItem";
            this.inschrijfToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.inschrijfToolStripMenuItem.Text = "inschrijf";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 199);
            this.Controls.Add(this.btnShowLsie);
            this.Controls.Add(this.btnToevoegenLsie);
            this.Controls.Add(this.rtbOverzichtLsie);
            this.Controls.Add(this.tbWoonplaatsLsie);
            this.Controls.Add(this.tbAddresLsie);
            this.Controls.Add(this.tbNaamLsie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "inschrijf formulier";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNaamLsie;
        private System.Windows.Forms.TextBox tbAddresLsie;
        private System.Windows.Forms.TextBox tbWoonplaatsLsie;
        private System.Windows.Forms.RichTextBox rtbOverzichtLsie;
        private System.Windows.Forms.Button btnToevoegenLsie;
        private System.Windows.Forms.Button btnShowLsie;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inschrijfToolStripMenuItem;
    }
}

