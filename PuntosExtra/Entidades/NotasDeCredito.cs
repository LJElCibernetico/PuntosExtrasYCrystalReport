using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace PuntosExtra.Entidades
{
    public class NotasDeCredito
    {
        [Key]
        public int notasID { get; set; }
        public int estudianteID { get; set; }
        public DateTime fecha { get; set; }
        public decimal monto { get; set; }
        public decimal pctBeca { get; set; }
        public decimal montoAsignatura { get; set; }

        public NotasDeCredito()
        {
            this.estudianteID = 0;
            this.notasID = 0;
            this.monto = 0;
            this.fecha = DateTime.Now;
            this.montoAsignatura = 0;
            this.pctBeca = 0;
        }

        public NotasDeCredito(int notasID, int estudianteID, string observaciones, decimal monto, DateTime fecha, decimal pctBeca, decimal montoAsignatura)
        {
            this.notasID = notasID;
            this.estudianteID = estudianteID;
            this.monto = monto;
            this.fecha = fecha;
            this.pctBeca = pctBeca;
            this.montoAsignatura = montoAsignatura;
        }
    }
}
