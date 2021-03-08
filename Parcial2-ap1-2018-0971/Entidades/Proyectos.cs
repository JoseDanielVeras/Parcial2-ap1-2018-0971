using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_ap1_2018_0971.Entidades
{
    public class Proyectos
    {
        [Key]
        public int ProyectoId { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public int TiempoTotal { get; set; }

        [ForeignKey("ProyectoId")]
        public List<ProyectosDetalle> DetalleProyecto { get; set; }
        public Proyectos()
        {
            ProyectoId = 0;
            Fecha = DateTime.Now;
            Descripcion = string.Empty;
            TiempoTotal = 0;
            DetalleProyecto = new List<ProyectosDetalle>();
        }

        public Proyectos(int proyectoId, DateTime fecha, string descripcion, int tiempoTotal)
        {
            ProyectoId = proyectoId;
            Fecha = fecha;
            Descripcion = descripcion;
            TiempoTotal = tiempoTotal;
            DetalleProyecto = new List<ProyectosDetalle>();
        }
    }
}
