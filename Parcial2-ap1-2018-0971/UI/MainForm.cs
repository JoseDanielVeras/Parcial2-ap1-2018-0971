using Parcial2_ap1_2018_0971.UI.Consultas;
using Parcial2_ap1_2018_0971.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2_ap1_2018_0971
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.rProyectosToolStripMenuItem.Click += new EventHandler(this.rProyectosToolStripMenuItem_ItemClicked);
            this.cConsultasToolStripMenuItem.Click += new EventHandler(this.cProyectosToolStripMenuItem_ItemClicked);

        }

        private void cProyectosToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var proyecto = new cProyectos();
            proyecto.Show();
        }

        private void rProyectosToolStripMenuItem_ItemClicked(object sender, EventArgs e)
        {
            var proyecto = new rProyectos();
            proyecto.Show();
        }

    }
}
