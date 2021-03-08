
namespace Parcial2_ap1_2018_0971
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.RegistosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rProyectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cConsultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RegistosToolStripMenuItem,
            this.ConsultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // RegistosToolStripMenuItem
            // 
            this.RegistosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rProyectosToolStripMenuItem});
            this.RegistosToolStripMenuItem.Name = "RegistosToolStripMenuItem";
            this.RegistosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.RegistosToolStripMenuItem.Text = "Registros";
            // 
            // ConsultasToolStripMenuItem
            // 
            this.ConsultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cConsultasToolStripMenuItem});
            this.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem";
            this.ConsultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.ConsultasToolStripMenuItem.Text = "Consultas";
            // 
            // rProyectosToolStripMenuItem
            // 
            this.rProyectosToolStripMenuItem.Name = "rProyectosToolStripMenuItem";
            this.rProyectosToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.rProyectosToolStripMenuItem.Text = "Proyectos";
            // 
            // cConsultasToolStripMenuItem
            // 
            this.cConsultasToolStripMenuItem.Name = "cConsultasToolStripMenuItem";
            this.cConsultasToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.cConsultasToolStripMenuItem.Text = "Proyectos";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem RegistosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rProyectosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConsultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cConsultasToolStripMenuItem;
    }
}

