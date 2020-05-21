using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Parcial2
{
    class Cliente
    {
		//Campos
		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		private string apellido;

		public string Apellido
		{
			get { return apellido; }
			set { apellido = value; }
		}

		private int telefono;

		public int Telefono
		{
			get { return telefono; }
			set { telefono = value; }
		}

		private string e_mail;

		public string E_mail
		{
			get { return e_mail; }
			set { e_mail = value; }
		}


		private List<Mascota> mascotas;

		public List<Mascota> Mascotas
		{
			get { return mascotas; }
			set { mascotas = value; }
		}

		//Constructores

		public Cliente(string nombre1, string apellido1, int telefono1, string e_mail1)
		{
			nombre = nombre1;
			apellido = apellido1;
			telefono = telefono1;
			e_mail = e_mail1;
			mascotas = new List<Mascota>();
		}

		public Cliente(string nombre1, string apellido1, int telefono1, string e_mail1, Mascota mascota)
		{
			nombre = nombre1;
			apellido = apellido1;
			telefono = telefono1;
			e_mail = e_mail1;
			mascotas = new List<Mascota>();
			this.mascotas.Add(mascota);
		}

		//Metodos
		public void AgregarMascota(Mascota mascota)
		{
			if (this.mascotas.Any())
			{
				this.mascotas.Add(mascota);
			}
			else
			{
				WriteLine("No tiene ninguna mascota.\nDesea agregar una mascota.");
				string cont = ReadLine();
				switch (cont)
				{
					case "si":
						this.mascotas.Add(mascota);
						break;
					case "no":
						break;
					default:
						WriteLine("Opcion Erronea!!!");
						break;
				}
			}
		}

		public void EliminarMascota(Mascota mascota)
		{
			if (this.mascotas.Any())
			{
			}

			this.mascotas.Remove(mascota);
		}


		public void MostrarCliente()
		{
			WriteLine("<<<<<<<<<<<<<<<Cliente>>>>>>>>>>>>>>>>>>>>" +
				"\nNombre: " + Nombre + "\nApellido: " + Apellido + 
				"\nTelefono: " + Telefono + "\nEmail: " + E_mail);
		}


	}
}
