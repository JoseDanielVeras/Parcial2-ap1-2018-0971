
namespace Parcial2_ap1_2018_0971.UI.Consultas
{
    partial class cProyectos
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
            this.FiltroLabel = new System.Windows.Forms.Label();
            this.CriterioLabel = new System.Windows.Forms.Label();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.cProyectosDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.cProyectosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FiltroLabel
            // 
            this.FiltroLabel.AutoSize = true;
            this.FiltroLabel.Location = new System.Drawing.Point(12, 9);
            this.FiltroLabel.Name = "FiltroLabel";
            this.FiltroLabel.Size = new System.Drawing.Size(34, 15);
            this.FiltroLabel.TabIndex = 0;
            this.FiltroLabel.Text = "Filtro";
            // 
            // CriterioLabel
            // 
            this.CriterioLabel.AutoSize = true;
            this.CriterioLabel.Location = new System.Drawing.Point(177, 9);
            this.CriterioLabel.Name = "CriterioLabel";
            this.CriterioLabel.Size = new System.Drawing.Size(46, 15);
            this.CriterioLabel.TabIndex = 1;
            this.CriterioLabel.Text = "Criterio";
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Items.AddRange(new object[] {
            "Proyecto Id",
            "Descripción",
            "Tiempo Total"});
            this.FiltroComboBox.Location = new System.Drawing.Point(12, 27);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(141, 23);
            this.FiltroComboBox.TabIndex = 2;
            // 
            // CriterioTextBox
            // 
            this.CriterioTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CriterioTextBox.Location = new System.Drawing.Point(177, 27);
            this.CriterioTextBox.Name = "CriterioTextBox";
            this.CriterioTextBox.Size = new System.Drawing.Size(330, 23);
            this.CriterioTextBox.TabIndex = 3;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BuscarButton.Image = global::Parcial2_ap1_2018_0971.Properties.Resources.lupa;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(528, 25);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(71, 25);
            this.BuscarButton.TabIndex = 4;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // cProyectosDataGridView
            // 
            this.cProyectosDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cProyectosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cProyectosDataGridView.Location = new System.Drawing.Point(12, 56);
            this.cProyectosDataGridView.Name = "cProyectosDataGridView";
            this.cProyectosDataGridView.RowTemplate.Height = 25;
            this.cProyectosDataGridView.Size = new System.Drawing.Size(587, 299);
            this.cProyectosDataGridView.TabIndex = 5;
            // 
            // cProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 366);
            this.Controls.Add(this.cProyectosDataGridView);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.CriterioTextBox);
            this.Controls.Add(this.FiltroComboBox);
            this.Controls.Add(this.CriterioLabel);
            this.Controls.Add(this.FiltroLabel);
            this.MinimumSize = new System.Drawing.Size(631, 405);
            this.Name = "cProyectos";
            this.Text = "Consulta Proyectos";
            ((System.ComponentModel.ISupportInitialize)(this.cProyectosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FiltroLabel;
        private System.Windows.Forms.Label CriterioLabel;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.DataGridView cProyectosDataGridView;
    }
}