using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    public class Libro
    {
        public string Titulo { get; set; }
        public string ISBN { get; set; }
        public string Autor { get; set; }
        public Decimal PrecioUnitario { get; set; }
        public int Stock { get; set; }

        public  Libro(string titulo, string isbn, string autor, decimal precioUnitario, int stock)
        {
            Titulo = titulo;
            ISBN = isbn;
            Autor = autor;
            PrecioUnitario = precioUnitario;
            Stock = stock;
        }

        public void Informacion()
        {
            Console.WriteLine("Titulo: " + Titulo);
            Console.WriteLine("ISBN: "+ ISBN);
            Console.WriteLine("Autor: "+  Autor);
            Console.WriteLine("Precio Unitario: "+  PrecioUnitario);
            Console.WriteLine("Cantidad en stock"+  Stock);
            Console.WriteLine("-------------------------------------");
        }
    }

   
}
