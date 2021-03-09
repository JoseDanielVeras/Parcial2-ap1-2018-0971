using Parcial2_ap1_2018_0971.BLL;
using Parcial2_ap1_2018_0971.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2_ap1_2018_0971.UI.Consultas
{
    public partial class cProyectos : Form
    {
        public cProyectos()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var lista = new List<Proyectos>();

            if(!String.IsNullOrWhiteSpace(CriterioTextBox.Text))
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        lista = ProyectosBLL.GetList(r => r.ProyectoId == Utilidades.ToInt(CriterioTextBox.Text));
                        break;

                    case 1:
                        lista = ProyectosBLL.GetList(r => r.Descripcion.Contains(CriterioTextBox.Text));
                        break;

                    case 2:
                        lista = ProyectosBLL.GetList(r => r.TiempoTotal == Utilidades.ToInt(CriterioTextBox.Text));
                        break;

                    default:

                        break;
                }
            }
            else
            {
                lista = ProyectosBLL.GetList(r => true);
            }
            cProyectosDataGridView.DataSource = null;
            cProyectosDataGridView.DataSource = lista;

        }
    }
}
