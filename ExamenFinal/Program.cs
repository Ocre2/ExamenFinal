using ExamenFinal;




Libro libro1 = new Libro( "Libro 1",  "ISBN 1",  "Autor 1",  10,  5)
{
    
};
Libro libro2 = new Libro( "Libro 2", "ISBN 2",  "Autor 2",  15,  10)
{
    
};
//Agregar libro al inventario

List<Libro> inventario = new List<Libro>();
inventario.Add(libro1);
inventario.Add(libro2); 
// Mostrar info del inventario

Console.WriteLine("--inventario de ReadersCove--");
foreach (Libro libro in inventario)
{
    libro.Informacion();
}


//Realizar una venta 

List<Libro> librosVenta = new List<Libro>();
librosVenta.Add(libro2);
librosVenta.Add(libro1);

List<int> cantidadesVenta = new List<int>();
cantidadesVenta.Add(1);
cantidadesVenta.Add(2);


Ventas venta = new Ventas(librosVenta, cantidadesVenta);

//Mostrar info despues de la venta

Console.WriteLine("--Ventas realizadas--");
Console.WriteLine("MontoTotal: $" + venta.MontoTotal);

Console.WriteLine("--Inventario actualizado--");
foreach (Libro libro in inventario)
{
    libro.Informacion();
}










