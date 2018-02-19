using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace PuntosExtra.Entidades
{
    public class Estudiantes
    {
        [Key]
        public int estudianteID { get; set; }
        public string nombre { get; set; }
        public string observaciones { get; set; }
        public decimal montoDescuento { get; set; }
        public DateTime fecha { get; set; }

        public Estudiantes()
        {
            this.estudianteID = 0;
            this.nombre = string.Empty;
            this.observaciones = string.Empty;
            this.montoDescuento = 0;
            this.fecha = DateTime.Now;
        }

        public Estudiantes(int estudianteID, string nombre, string fecha, decimal monto)
        {
            this.estudianteID = estudianteID;
            this.nombre = nombre;
            this.montoDescuento = monto;
            this.fecha = DateTime.Now;
        }
    }
}
