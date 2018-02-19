using System;
using System.Collections.Generic;
using System.Data.Entity;
using PuntosExtra.Entidades;
using System.Linq;
using System.Text;

namespace PuntosExtra.DAL
{
    public class ContextoNotasDeCredito : DbContext
    {
        public DbSet<NotasDeCredito> Notas { get; set; }

        public ContextoNotasDeCredito() : base("ConStr2")
        {

        }
    }
}
