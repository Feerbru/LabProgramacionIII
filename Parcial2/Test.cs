using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Parcial2
{
    class Test
    {
        /**
         * Fernando Matias Bruzzo - TUP
         * 
         *  Desarrollar una aplicación en C# orientado a objetos, para una veterinaria, el sistema permitirá
            registrar clientes y estos podrán tener mascotas de modo que las mascotas podrán tener atenciones
            estas pueden ser ordinarias o extraordinarias. Llamamos atenciones ordinarias a la vacunación,
            desparacitación, baño, corte de pelo, y las extraordinarias son consultas por enfermedad.

            De los clientes guardaremos el nombre, apellido, el teléfono, e_mail.

            realizar una clase test para probar las clases cree en ella un cliente y asignele un par de mascotas
            creele ademas algunas atenciones ordinarias y extraordinarias a las mascotas.
         **/
        static void Main(string[] args)
        {
            //Creamos cliente
            Cliente cliente = new Cliente("Fernando", "Orange", 36340723, "Landa23@gmail.com");
            //Creamos mascotas
            Mascota perro = new Mascota(14,"Rocko","Perro","pitbull");
            Mascota gato = new Mascota(12, "Bola de nieve", "Gato", "siameses");
            Mascota caballo = new Mascota(1, "Pepe", "Caballo", "Mustang");
            //Agregamos los animales al cliente
            cliente.AgregarMascota(perro);
            cliente.AgregarMascota(gato);
            cliente.AgregarMascota(caballo);

            //creamos Atenciones
            Ordinaria turno = new Ordinaria(12, "", "", new DateTime(2020, 05, 19), Tipo.vacunacion);
            Extraordinario turno1 = new Extraordinario(true, "Varicela", "30 dias reposo");

            perro.AgregarTurno(turno);

            cliente.MostrarCliente();

            foreach (var cli in cliente.Mascotas)
            {
                WriteLine(cli.Nombre);
            }

            ReadKey();
        }
    }
}
