using PuntosExtra.DAL;
using PuntosExtra.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace PuntosExtra.BLL
{
    public class NotasDeCreditoBLL
    {
        public static bool Guardar(NotasDeCredito estudiante)
        {
            bool paso = false;
            try
            {
                ContextoNotasDeCredito Contex = new ContextoNotasDeCredito();
                Contex.Notas.Add(estudiante);
                Contex.SaveChanges();
                paso = true;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Eliminar(int estudianteID)
        {
            bool paso = false;

            try
            {
                ContextoNotasDeCredito contex = new ContextoNotasDeCredito();

                var estudiante = contex.Notas.Find(estudianteID);

                contex.Notas.Remove(estudiante);
                contex.SaveChanges();

                paso = true;
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public static NotasDeCredito Buscar(int EstudianteId)
        {
            NotasDeCredito NotaCredito = new NotasDeCredito();

            try
            {
                ContextoNotasDeCredito contex = new ContextoNotasDeCredito();
                NotaCredito = contex.Notas.Find(EstudianteId);
            }
            catch (Exception)
            {
                throw;
            }

            return NotaCredito;
        }

        public static bool Modificar(NotasDeCredito nota)
        {
            bool paso = false;

            try
            {
                ContextoNotasDeCredito contex = new ContextoNotasDeCredito();

                contex.Entry(nota).State = EntityState.Modified;
                if (contex.SaveChanges() > 0)
                {
                    paso = true;
                }

            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public static List<NotasDeCredito> GetList(Expression<Func<NotasDeCredito, bool>> criterioBusqueda)
        {
            List<NotasDeCredito> NotaCredito = new List<NotasDeCredito>();
            try
            {
                ContextoNotasDeCredito contex = new ContextoNotasDeCredito();
                NotaCredito = contex.Notas.Where(criterioBusqueda).ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return NotaCredito;
        }
    }
}
