using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Pedido
    {
        public DateTime Fecha { get; set; }
        public Single Monto { get; set; }

        public Pedido() 
        {
        
        }

        public Pedido(DateTime fecha, float monto)
        {
            Fecha = fecha;
            Monto = monto;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", Fecha.ToString("dd/MM/yy HH:mm:ss"), Monto); 
        }
    }
}
