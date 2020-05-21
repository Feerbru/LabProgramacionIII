using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Parcial2
{
    class Mascota
    {
		//Campos
		private int codigoMasc;

		public int CodigoMasc
		{
			get { return codigoMasc; }
			set { codigoMasc = value; }
		}

		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		private string tipo;

		public string Tipo
		{
			get { return tipo; }
			set { tipo = value; }
		}

		private string raza;

		public string Raza
		{
			get { return raza; }
			set { raza = value; }
		}

		private List<Atencion> atenciones;

		public List<Atencion> Atenciones
		{
			get { return atenciones; }
			set { atenciones = value; }
		}

		//Constructores
		public Mascota(int codigoMasc, string nombre, string tipo, string raza)
		{
			CodigoMasc = codigoMasc;
			Nombre = nombre;
			Tipo = tipo;
			Raza = raza;
			atenciones = new List<Atencion>();
		}
		public Mascota(int codigoMasc, string nombre, string tipo, string raza,Atencion atencion)
		{
			CodigoMasc = codigoMasc;
			Nombre = nombre;
			Tipo = tipo;
			Raza = raza;
			atenciones = new List<Atencion>();
			this.atenciones.Add(atencion);
		}

		//Metodos

		public void AgregarTurno(Atencion atencion)
		{

			if (this.atenciones.Any())
			{
				this.atenciones.Add(atencion);
			}
			else
			{
				WriteLine("No tiene ningun turno asignado.\nDesea agregar un Turno.");
				string cont = ReadLine();
				switch (cont)
				{
					case "si":
						this.atenciones.Add(atencion);
						break;
					case "no":
						break;
					default:
						WriteLine("Opcion Erronea!!!");
						break;
				}
			}
		}

		public void EliminarTurno(Atencion atencion)
		{
			if (atenciones.Any())
			{
			}
			else
			{
				atenciones.Remove(atencion);

			}
		}
	}
}
