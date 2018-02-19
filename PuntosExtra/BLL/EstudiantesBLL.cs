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
    public class EstudiantesBLL
    {
        public static bool Guardar(Estudiantes estudiante)
        {
            bool paso = false;
            try
            {
                ContextoEstudiantes Contex = new ContextoEstudiantes();
                Contex.Estudiante.Add(estudiante);
                Contex.SaveChanges();
                paso = true;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Modificar(Estudiantes estudiante)
        {
            bool paso = false;

            try
            {
                ContextoEstudiantes contex = new ContextoEstudiantes();

                contex.Entry(estudiante).State = EntityState.Modified;
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

        public static bool Eliminar(int estudianteID)
        {
            bool paso = false;

            try
            {
                ContextoEstudiantes contex = new ContextoEstudiantes();

                var estudiante = contex.Estudiante.Find(estudianteID);

                contex.Estudiante.Remove(estudiante);
                contex.SaveChanges();

                paso = true;
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public static Estudiantes Buscar(int EstudianteId)
        {
            Estudiantes estudiante = new Estudiantes();

            try
            {
                ContextoEstudiantes contex = new ContextoEstudiantes();
                estudiante = contex.Estudiante.Find(EstudianteId);
            }
            catch (Exception)
            {
                throw;
            }

            return estudiante;
        }

        public static List<Estudiantes> GetList(Expression<Func<Estudiantes, bool>> criterioBusqueda)
        {
            List<Estudiantes> estudiante = new List<Estudiantes>();
            try
            {
                ContextoEstudiantes contex = new ContextoEstudiantes();
                estudiante = contex.Estudiante.Where(criterioBusqueda).ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return estudiante;
        }
    }
}
