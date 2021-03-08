using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_ap1_2018_0971.Entidades
{
    public class TareasTipos
    {
        [Key]
        public int TipoId { get; set; }
        public string Descripcion { get; set; }
        public string Requerimiento { get; set; }
        public int Tiempo { get; set; }

        public TareasTipos()
        {
            TipoId = 0;
            Descripcion = "";
            Requerimiento = "";
            Tiempo = 0;
        }

        public TareasTipos(int id, string descripcion, string requerimiento, int tiempo)
        {
            TipoId = id;
            Descripcion = descripcion;
            Requerimiento = requerimiento;
            Tiempo = tiempo;
        }
    }
}
