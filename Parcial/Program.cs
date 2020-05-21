using System;
using System.Collections.Generic;
using static System.Console;

namespace Parcial
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos cliente
            Cliente cliente = new Cliente("Nando","Orange",476627,"yefris@gmail.com");
            //Creamos Carrito
            Carrito carrito = new Carrito(cliente);
            //Creamos Articulos
            Perecedero per = new Perecedero();
            Articulo manzana = new Articulo("Manzana","No Perecederos", 50);
            Articulo banana = new Perecedero("Banana", "Perecederos", 120,23,new DateTime(2020,05,14));
            Articulo naranja = new Articulo("Naranja", "Perecederos", 46, 24);
            //Agregamos a la lista
            carrito.Agregar(manzana);
            carrito.Agregar(banana);
            carrito.Agregar(naranja);
            //Mostramos
            carrito.Mostrar();
            //Eliminamos un articulo
            WriteLine("Eliminamos la Manzana");
            carrito.QuitarArticulo(manzana);
            //Mostramos
            carrito.Mostrar();
            //Monto a pagar
            WriteLine("El monto total a pagar es: $" + carrito.PrecioTotal);

            ReadKey();
        }
    }
    class Carrito
    {
        private Cliente cliente;
        private List<Articulo> articulos;

        private double precioTotal;

        public double PrecioTotal
        {
            get { return precioTotal; }
            set { precioTotal = value; }
        }


        public Carrito(Cliente cliente)
        {
            this.cliente = cliente;
            articulos = new List<Articulo>();
        }

        public void Agregar(Articulo a)
        {
            if (a.Stock > 0)
            {
                articulos.Add(a);
                this.precioTotal += a.Precio;
                a.Stock -= 1;
            }
            else
            {
                WriteLine("Sin stock del producto");
            }

        }
        public void QuitarArticulo(Articulo a)
        {
            articulos.Remove(a);
            this.precioTotal -= a.Precio;
            a.Stock += 1;
        }

        public void Mostrar()
        {
            foreach (var mostrar in articulos)
            {
                mostrar.Mostrar();
            }
        }

    }
    class Cliente
    {
        private string Nombre { get; set; }
        private string Apellido { get; set; }
        private int Telefono { get; set; }
        private string Email { get; set; }

        public Cliente(string nombre, string apellido, int telefono, string email)
        {
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Email = email;
        }
    }
    class Articulo
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        private string categoria;

        public string Categoria
        {
            get { return Categoria; }
            set { Categoria = value; }
        }


        private double precio;

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        private int stock;

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public Articulo()
        {

        }
        public Articulo(string nombre, string categoria, double precio, int stock)
        {
            this.nombre = nombre;
            this.categoria = categoria;
            this.precio = precio;
            this.stock = stock;
        }
        public Articulo(string nombre, string categoria, double precio)
        {
            this.nombre = nombre;
            this.categoria = categoria;
            this.precio = precio;
            this.stock = new Random().Next(10, 50);
        }

        public void Mostrar()
        {
            WriteLine("Articulo: " + nombre + "\nCategoria:" + categoria +
                " \nPrecio: $" + precio + "\nStock: " + stock);

        }

        public void VenciPer(Perecedero vencido)
        {
            if (vencido.Venci())
            {
                WriteLine("El producto " + nombre + " esta vencido");
            }
            else
            {
                WriteLine("El producto "+ nombre + "apto para la venta.");
            }
        }


    }
    class Perecedero : Articulo
    {
        private DateTime vencimiento;

        public Perecedero() { 
        }
        public Perecedero(string nombre, string categoria, double precio, int stock,DateTime date) : base(nombre,categoria,precio,stock)
        {
            this.vencimiento = date;
        }
        public bool Venci()
        {
            if (vencimiento.Date >= DateTime.Now)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
