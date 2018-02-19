using PuntosExtra.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace PuntosExtra.DAL
{
    public class ContextoEstudiantes : DbContext
    {
        public DbSet<Estudiantes> Estudiante { get; set; }

        public ContextoEstudiantes() : base("ConStr1")
        {

        }
        
    }
}
