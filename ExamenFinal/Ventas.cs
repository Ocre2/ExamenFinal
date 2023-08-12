using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    public class Ventas
    {
        public List<Libro> LibrosComprados { get; set; }
        public List<int> Cantidades { get; set; }
        public decimal MontoTotal { get; set; }

        public Ventas(List<Libro> libros, List<int> cantidades) 
        {
            LibrosComprados = libros;
            Cantidades = cantidades;
            CalcularTotal();
            ActualizarInventario();
        }

        public void CalcularTotal() 
        {
            MontoTotal = 0;

            for(int i = 0; i < LibrosComprados.Count; i++) 
            {
                MontoTotal += LibrosComprados[i].PrecioUnitario * Cantidades[i];
            }
        }

        private void ActualizarInventario()
        {
            for(int i = 0;i < LibrosComprados.Count;i++)
            {
                LibrosComprados[i].Stock -= Cantidades[i];
            }
        }
        
    }
}
