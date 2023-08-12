using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenFinal;
namespace ExamenFinal
{
    public class ReadersCove
    {
        private List<Libro> Inventario;
        private List<Ventas> Ventas;

        public ReadersCove()
        {
            Inventario = new List<Libro>();
            Ventas = new List<Ventas>();
        }

        public void AgregaLibro(Libro libro)
        {
            Inventario.Add(libro);
        }
        
       

        

    }
}
