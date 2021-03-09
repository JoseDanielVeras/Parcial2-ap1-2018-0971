
namespace Parcial2_ap1_2018_0971.UI.Registros
{
    partial class rProyectos
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
            this.components = new System.ComponentModel.Container();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FechaLabel = new System.Windows.Forms.Label();
            this.ProyectoIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ProyectoIdLabel = new System.Windows.Forms.Label();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.DescripcionLabel = new System.Windows.Forms.Label();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RemoverButton = new System.Windows.Forms.Button();
            this.ProyectoDetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.TiempoTextBox = new System.Windows.Forms.TextBox();
            this.TiposTareasLabel = new System.Windows.Forms.Label();
            this.TiempoLabel = new System.Windows.Forms.Label();
            this.Requerimientolabel = new System.Windows.Forms.Label();
            this.RequerimientoTextBox = new System.Windows.Forms.TextBox();
            this.TiposTareaComboBox = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label = new System.Windows.Forms.Label();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.TiempoToalLabel = new System.Windows.Forms.Label();
            this.TiempoTotalTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProyectoIdNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProyectoDetalleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(12, 81);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(120, 23);
            this.FechaDateTimePicker.TabIndex = 8;
            // 
            // FechaLabel
            // 
            this.FechaLabel.AutoSize = true;
            this.FechaLabel.Location = new System.Drawing.Point(12, 63);
            this.FechaLabel.Name = "FechaLabel";
            this.FechaLabel.Size = new System.Drawing.Size(38, 15);
            this.FechaLabel.TabIndex = 7;
            this.FechaLabel.Text = "Fecha";
            // 
            // ProyectoIdNumericUpDown
            // 
            this.ProyectoIdNumericUpDown.Location = new System.Drawing.Point(12, 27);
            this.ProyectoIdNumericUpDown.Name = "ProyectoIdNumericUpDown";
            this.ProyectoIdNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.ProyectoIdNumericUpDown.TabIndex = 6;
            // 
            // ProyectoIdLabel
            // 
            this.ProyectoIdLabel.AutoSize = true;
            this.ProyectoIdLabel.Location = new System.Drawing.Point(12, 9);
            this.ProyectoIdLabel.Name = "ProyectoIdLabel";
            this.ProyectoIdLabel.Size = new System.Drawing.Size(72, 15);
            this.ProyectoIdLabel.TabIndex = 5;
            this.ProyectoIdLabel.Text = "Proyectos Id";
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(12, 135);
            this.DescripcionTextBox.Multiline = true;
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(649, 64);
            this.DescripcionTextBox.TabIndex = 10;
            // 
            // DescripcionLabel
            // 
            this.DescripcionLabel.AutoSize = true;
            this.DescripcionLabel.Location = new System.Drawing.Point(12, 117);
            this.DescripcionLabel.Name = "DescripcionLabel";
            this.DescripcionLabel.Size = new System.Drawing.Size(138, 15);
            this.DescripcionLabel.TabIndex = 9;
            this.DescripcionLabel.Text = "Descripción del Proyecto";
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = global::Parcial2_ap1_2018_0971.Properties.Resources.lupa;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(138, 25);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(71, 25);
            this.BuscarButton.TabIndex = 11;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RemoverButton);
            this.groupBox1.Controls.Add(this.ProyectoDetalleDataGridView);
            this.groupBox1.Controls.Add(this.AgregarButton);
            this.groupBox1.Controls.Add(this.TiempoTextBox);
            this.groupBox1.Controls.Add(this.TiposTareasLabel);
            this.groupBox1.Controls.Add(this.TiempoLabel);
            this.groupBox1.Controls.Add(this.Requerimientolabel);
            this.groupBox1.Controls.Add(this.RequerimientoTextBox);
            this.groupBox1.Controls.Add(this.TiposTareaComboBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 271);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle Tarea";
            // 
            // RemoverButton
            // 
            this.RemoverButton.Image = global::Parcial2_ap1_2018_0971.Properties.Resources.boton_x_16x16;
            this.RemoverButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoverButton.Location = new System.Drawing.Point(6, 230);
            this.RemoverButton.Name = "RemoverButton";
            this.RemoverButton.Size = new System.Drawing.Size(101, 25);
            this.RemoverButton.TabIndex = 22;
            this.RemoverButton.Text = "Remover Fila";
            this.RemoverButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoverButton.UseVisualStyleBackColor = true;
            this.RemoverButton.Click += new System.EventHandler(this.RemoverButton_Click);
            // 
            // ProyectoDetalleDataGridView
            // 
            this.ProyectoDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProyectoDetalleDataGridView.Location = new System.Drawing.Point(6, 66);
            this.ProyectoDetalleDataGridView.Name = "ProyectoDetalleDataGridView";
            this.ProyectoDetalleDataGridView.RowTemplate.Height = 25;
            this.ProyectoDetalleDataGridView.Size = new System.Drawing.Size(630, 158);
            this.ProyectoDetalleDataGridView.TabIndex = 21;
            // 
            // AgregarButton
            // 
            this.AgregarButton.Image = global::Parcial2_ap1_2018_0971.Properties.Resources.anadir_16x16;
            this.AgregarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AgregarButton.Location = new System.Drawing.Point(559, 36);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(77, 25);
            this.AgregarButton.TabIndex = 20;
            this.AgregarButton.Text = "Agregar";
            this.AgregarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // TiempoTextBox
            // 
            this.TiempoTextBox.Location = new System.Drawing.Point(444, 37);
            this.TiempoTextBox.Name = "TiempoTextBox";
            this.TiempoTextBox.Size = new System.Drawing.Size(103, 23);
            this.TiempoTextBox.TabIndex = 19;
            // 
            // TiposTareasLabel
            // 
            this.TiposTareasLabel.AutoSize = true;
            this.TiposTareasLabel.Location = new System.Drawing.Point(6, 19);
            this.TiposTareasLabel.Name = "TiposTareasLabel";
            this.TiposTareasLabel.Size = new System.Drawing.Size(81, 15);
            this.TiposTareasLabel.TabIndex = 14;
            this.TiposTareasLabel.Text = "Tipos de Tarea";
            // 
            // TiempoLabel
            // 
            this.TiempoLabel.AutoSize = true;
            this.TiempoLabel.Location = new System.Drawing.Point(444, 19);
            this.TiempoLabel.Name = "TiempoLabel";
            this.TiempoLabel.Size = new System.Drawing.Size(47, 15);
            this.TiempoLabel.TabIndex = 18;
            this.TiempoLabel.Text = "Tiempo";
            // 
            // Requerimientolabel
            // 
            this.Requerimientolabel.AutoSize = true;
            this.Requerimientolabel.Location = new System.Drawing.Point(146, 19);
            this.Requerimientolabel.Name = "Requerimientolabel";
            this.Requerimientolabel.Size = new System.Drawing.Size(143, 15);
            this.Requerimientolabel.TabIndex = 15;
            this.Requerimientolabel.Text = "Requerimiento de la Tarea";
            // 
            // RequerimientoTextBox
            // 
            this.RequerimientoTextBox.Location = new System.Drawing.Point(146, 37);
            this.RequerimientoTextBox.Name = "RequerimientoTextBox";
            this.RequerimientoTextBox.Size = new System.Drawing.Size(279, 23);
            this.RequerimientoTextBox.TabIndex = 17;
            // 
            // TiposTareaComboBox
            // 
            this.TiposTareaComboBox.FormattingEnabled = true;
            this.TiposTareaComboBox.Location = new System.Drawing.Point(6, 37);
            this.TiposTareaComboBox.Name = "TiposTareaComboBox";
            this.TiposTareaComboBox.Size = new System.Drawing.Size(121, 23);
            this.TiposTareaComboBox.TabIndex = 16;
            this.TiposTareaComboBox.SelectedIndexChanged += new System.EventHandler(this.TiposTareaComboBox_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(6, 19);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(81, 15);
            this.label.TabIndex = 14;
            this.label.Text = "Tipos de Tarea";
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = global::Parcial2_ap1_2018_0971.Properties.Resources._new;
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoButton.Location = new System.Drawing.Point(12, 480);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(75, 60);
            this.NuevoButton.TabIndex = 13;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = global::Parcial2_ap1_2018_0971.Properties.Resources.disco_flexible;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.Location = new System.Drawing.Point(116, 480);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 60);
            this.GuardarButton.TabIndex = 14;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = global::Parcial2_ap1_2018_0971.Properties.Resources.eliminar;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarButton.Location = new System.Drawing.Point(226, 480);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 60);
            this.EliminarButton.TabIndex = 15;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // TiempoToalLabel
            // 
            this.TiempoToalLabel.AutoSize = true;
            this.TiempoToalLabel.Location = new System.Drawing.Point(480, 502);
            this.TiempoToalLabel.Name = "TiempoToalLabel";
            this.TiempoToalLabel.Size = new System.Drawing.Size(75, 15);
            this.TiempoToalLabel.TabIndex = 16;
            this.TiempoToalLabel.Text = "Tiempo Total";
            // 
            // TiempoTotalTextBox
            // 
            this.TiempoTotalTextBox.Location = new System.Drawing.Point(561, 499);
            this.TiempoTotalTextBox.Name = "TiempoTotalTextBox";
            this.TiempoTotalTextBox.Size = new System.Drawing.Size(100, 23);
            this.TiempoTotalTextBox.TabIndex = 17;
            // 
            // rProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 569);
            this.Controls.Add(this.TiempoTotalTextBox);
            this.Controls.Add(this.TiempoToalLabel);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.DescripcionLabel);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.FechaLabel);
            this.Controls.Add(this.ProyectoIdNumericUpDown);
            this.Controls.Add(this.ProyectoIdLabel);
            this.Name = "rProyectos";
            this.Text = "Registro Proyectos";
            this.Load += new System.EventHandler(this.rProyectos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProyectoIdNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProyectoDetalleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.Label FechaLabel;
        private System.Windows.Forms.NumericUpDown ProyectoIdNumericUpDown;
        private System.Windows.Forms.Label ProyectoIdLabel;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.Label DescripcionLabel;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.TextBox TiempoTextBox;
        private System.Windows.Forms.Label TiposTareasLabel;
        private System.Windows.Forms.Label TiempoLabel;
        private System.Windows.Forms.Label Requerimientolabel;
        private System.Windows.Forms.TextBox RequerimientoTextBox;
        private System.Windows.Forms.ComboBox TiposTareaComboBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button RemoverButton;
        private System.Windows.Forms.DataGridView ProyectoDetalleDataGridView;
        private System.Windows.Forms.TextBox TiempoTotalTextBox;
        private System.Windows.Forms.Label TiempoToalLabel;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
    }
}