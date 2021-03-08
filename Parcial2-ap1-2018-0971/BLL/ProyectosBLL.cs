using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Parcial2_ap1_2018_0971.DAL;
using Parcial2_ap1_2018_0971.Entidades;

namespace Parcial2_ap1_2018_0971.BLL
{
    public class ProyectosBLL
    {
        public static bool ExisteProyecto(string descripcion)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                paso = contexto.Proyectos.Any(e => e.Descripcion.ToLower() == descripcion.ToLower());
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        private static bool Insertar(Proyectos proyectos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Proyectos.Add(proyectos);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        private static bool Modificar(Proyectos proyectos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Database.ExecuteSqlRaw($"Delete FROM ProyectosDatalle where ProyectoId = {proyectos.ProyectoId}");
                
                foreach(var anterior in proyectos.DetalleProyecto)
                {
                    contexto.Entry(anterior).State = EntityState.Added;
                }

                contexto.Entry(proyectos).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static bool Guardar(Proyectos proyectos)
        {
            if (!ExisteProyecto(proyectos.Descripcion))
                return Insertar(proyectos);
            else
                return Modificar(proyectos);
        }

        public static Proyectos Buscar(int id)
        {
            var contexto = new Contexto();
            var proyectos = new Proyectos();

            try
            {
                proyectos = contexto.Proyectos.Include(x => x.DetalleProyecto).Where(z => z.ProyectoId == id).SingleOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return proyectos;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                var eliminar = contexto.Proyectos.Find(id);
                contexto.Entry(eliminar).State = EntityState.Deleted;

                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static List<Proyectos> GetList(Expression<Func<Proyectos, bool>> criterio)
        {
            List<Proyectos> lista = new List<Proyectos>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Proyectos.Where(criterio).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return lista;
        }

        public static List<Proyectos> GetProyectos()
        {
            List<Proyectos> lista = new List<Proyectos>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Proyectos.ToList();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return lista;
        }
    }
}
