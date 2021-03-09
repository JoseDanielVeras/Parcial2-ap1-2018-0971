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
    public class TareaTiposBLL
    {
        public static TareasTipos Buscar(int tareasTiposId)
        {
            TareasTipos tipo;
            Contexto contexto = new Contexto();

            try
            {
                tipo = contexto.TareasTipos.Find(tareasTiposId);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return tipo;
        }

        public static string BuscarRequerimiento(int tareasTiposId)
        {
            TareasTipos tipo;
            Contexto contexto = new Contexto();

            try
            {
                tipo = contexto.TareasTipos.Find(tareasTiposId);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return tipo.Requerimiento;
        }

        public static int BuscarTiempo(int tareasTiposId)
        {
            TareasTipos tipo;
            Contexto contexto = new Contexto();

            try
            {
                tipo = contexto.TareasTipos.Find(tareasTiposId);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return tipo.Tiempo;
        }

        private static bool Insertar(TareasTipos tareasTipos)
        {
            bool insertado = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Add(tareasTipos);
                insertado = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return insertado;
        }

        private static bool Modificar(TareasTipos tareasTipos)
        {
            bool modificado = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(tareasTipos).State = EntityState.Modified;
                modificado = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return modificado;
        }

        public static bool Guardar(TareasTipos tiposTarea)
        {
            if (!Existe(tiposTarea.Descripcion))
                return Insertar(tiposTarea);
            else
                return Modificar(tiposTarea);
            
        }

        public static bool Existe(string descripcion)
        {
            bool encontrado = false;
            Contexto contexto = new Contexto();

            try
            {
                encontrado = contexto.TareasTipos.Any(e => e.Descripcion.ToLower() == descripcion.ToLower());
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return encontrado;
        }

        public static List<TareasTipos> GetList(Expression<Func<TareasTipos, bool>> criterio)
        {
            List<TareasTipos> lista = new List<TareasTipos>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.TareasTipos.Where(criterio).ToList();
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

        public static List<TareasTipos> GetTareasTipos()
        {
            List<TareasTipos> lista = new List<TareasTipos>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.TareasTipos.ToList();
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
