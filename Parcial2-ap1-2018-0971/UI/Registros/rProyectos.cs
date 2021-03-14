using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial2_ap1_2018_0971.BLL;
using Parcial2_ap1_2018_0971.Entidades;

namespace Parcial2_ap1_2018_0971.UI.Registros
{
    public partial class rProyectos : Form
    {
        public List<ProyectosDetalle> Detalle { get; set; }

        public rProyectos()
        {
            InitializeComponent();
            this.Detalle = new List<ProyectosDetalle>();
        }

        private void LlenarGrid()
        {
            ProyectoDetalleDataGridView.DataSource = null;
            ProyectoDetalleDataGridView.DataSource = this.Detalle;
        }

        private void Limpiar()
        {
            ProyectoIdNumericUpDown.Value = 0;
            FechaDateTimePicker.Value = DateTime.Now;
            DescripcionTextBox.Clear();
            errorProvider1.Clear();
            TiempoTotalTextBox.Clear();

            this.Detalle = new List<ProyectosDetalle>();
            LlenarGrid();
        }

        private Proyectos LlenaClases()
        {
            Proyectos proyectos = new Proyectos();
            proyectos.ProyectoId = (int)ProyectoIdNumericUpDown.Value;
            proyectos.Descripcion = DescripcionTextBox.Text;
            proyectos.Fecha = FechaDateTimePicker.Value;
            proyectos.TiempoTotal += Convert.ToInt32(TiempoTextBox.Text);

            proyectos.DetalleProyecto = this.Detalle;
            return proyectos;
        }

        private void LlenaCampos(Proyectos proyectos)
        {
            ProyectoIdNumericUpDown.Value = proyectos.ProyectoId;
            DescripcionTextBox.Text = proyectos.Descripcion;
            FechaDateTimePicker.Value = proyectos.Fecha;
            TiempoTotalTextBox.Text = Convert.ToString(proyectos.TiempoTotal);

            this.Detalle = proyectos.DetalleProyecto;
            LlenarGrid();
        }

        private bool Validar()
        {
            bool paso = true;
            
            if(DescripcionTextBox.Text == "")
            {
                errorProvider1.SetError(DescripcionTextBox, "Obligatorio");
                DescripcionTextBox.Focus();
                paso = false;
            }
            /*if(ProyectosBLL.ExisteProyecto(DescripcionTextBox.Text))
            {
                errorProvider1.SetError(DescripcionTextBox, "Obligatorio");
                DescripcionTextBox.Focus();
                paso = false;
            }*/
            if(this.Detalle.Count == 0)
            {
                errorProvider1.SetError(ProyectoDetalleDataGridView, "Obligatorio");
                TiposTareaComboBox.Focus();
                paso = false;
            }

            return paso;
        }

        private bool ExisteEnBaseDeDatos()
        {
            var proyecto = new Proyectos();
            proyecto = ProyectosBLL.Buscar((int)ProyectoIdNumericUpDown.Value);
            return (proyecto != null);
        }

        private void rProyectos_Load(object sender, EventArgs e)
        {
            TiposTareaComboBox.DataSource = TareaTiposBLL.GetTareasTipos();
            TiposTareaComboBox.DisplayMember = "Descripcion";
            TiposTareaComboBox.ValueMember = "TipoId";
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            Proyectos proyectos = new Proyectos();
            int id = (int)ProyectoIdNumericUpDown.Value;

            Limpiar();
            proyectos = ProyectosBLL.Buscar(id);

            if (proyectos != null)
                LlenaCampos(proyectos);
            else
                MessageBox.Show("No se encuentra","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            if (ProyectoDetalleDataGridView.DataSource != null)
                this.Detalle = (List<ProyectosDetalle>)ProyectoDetalleDataGridView.DataSource;

            this.Detalle.Add(
                new ProyectosDetalle(
                    detalleId: 0,
                    proyectoId: (int)ProyectoIdNumericUpDown.Value,
                    tipoTareaId: Convert.ToInt32(TiposTareaComboBox.SelectedIndex) + 1,
                    requerimiento: DescripcionTextBox.Text,
                    tiempo: Convert.ToInt32(TiempoTextBox.Text)
                )
            );

            LlenarGrid();
            TiposTareaComboBox.Focus();
        }

        private void RemoverButton_Click(object sender, EventArgs e)
        {
            if((ProyectoDetalleDataGridView.Rows.Count > 0) && ProyectoDetalleDataGridView.CurrentRow != null)
            {
                Detalle.RemoveAt(ProyectoDetalleDataGridView.CurrentRow.Index);
                LlenarGrid();
            }
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Proyectos proyectos;

            if (!Validar())
                return;

            proyectos = LlenaClases();
            var paso = ProyectosBLL.Guardar(proyectos);

            if(paso)
            {
                MessageBox.Show("Se ha Guardado", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                MessageBox.Show("No se puede Guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = (int)ProyectoIdNumericUpDown.Value;
            errorProvider1.Clear();

            if (ProyectosBLL.Eliminar(id))
            {
                MessageBox.Show("Se ha Eliminado", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                errorProvider1.SetError(ProyectoIdNumericUpDown, "Id No Existe");
        }

        private void TiposTareaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TiposTareaComboBox.SelectedIndex == 0)
            {
                RequerimientoTextBox.Text = TareaTiposBLL.BuscarRequerimiento(1);
                TiempoTextBox.Text = Convert.ToString(TareaTiposBLL.BuscarTiempo(1));
            }
            else if(TiposTareaComboBox.SelectedIndex == 1)
                {
                    RequerimientoTextBox.Text = TareaTiposBLL.BuscarRequerimiento(2);
                    TiempoTextBox.Text = Convert.ToString(TareaTiposBLL.BuscarTiempo(2));
                }
                else if (TiposTareaComboBox.SelectedIndex == 2)
                    {
                        RequerimientoTextBox.Text = TareaTiposBLL.BuscarRequerimiento(3);
                        TiempoTextBox.Text = Convert.ToString(TareaTiposBLL.BuscarTiempo(3));
                    }
                    else if (TiposTareaComboBox.SelectedIndex == 3)
                        {
                            RequerimientoTextBox.Text = TareaTiposBLL.BuscarRequerimiento(4);
                            TiempoTextBox.Text = Convert.ToString(TareaTiposBLL.BuscarTiempo(4));
                        }
        }
    }
}
