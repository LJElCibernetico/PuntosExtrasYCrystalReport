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
        public static decimal M = 0;

        public static bool Guardar(NotasDeCredito nc)
        {
            bool paso = false;
            try
            {
                ContextoNotasDeCredito Contex = new ContextoNotasDeCredito();
                Estudiantes es = BLL.EstudiantesBLL.Buscar(nc.estudianteID);
                
                es.montoDescuento += nc.monto;

                BLL.EstudiantesBLL.Modificar(es);
                Contex.Notas.Add(nc);
                Contex.SaveChanges();
                
                paso = true;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Eliminar(int ID)
        {
            bool paso = false;

            try
            {
                ContextoNotasDeCredito contex = new ContextoNotasDeCredito();
                NotasDeCredito nc = contex.Notas.Find(ID);
                Estudiantes es = BLL.EstudiantesBLL.Buscar(nc.estudianteID);
                es.montoDescuento -= nc.monto;

                var estudiante = contex.Notas.Find(ID);
                BLL.EstudiantesBLL.Modificar(es);
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

                if (NotaCredito != null)
                    M = NotaCredito.monto;
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
                Estudiantes es = BLL.EstudiantesBLL.Buscar(nota.estudianteID);

                es.montoDescuento -= M;
                contex.Entry(nota).State = EntityState.Modified;
                es.montoDescuento += nota.monto;
                contex.SaveChanges();
                BLL.EstudiantesBLL.Modificar(es);

                paso = true;
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
