using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Parcial2
{
	/**
	 * Llamamos atenciones ordinarias a la vacunación,
       desparacitación, baño, corte de pelo,
	*/
    class Ordinaria : Atencion
    {
		//Campos
		private Tipo tipo;

		public Tipo Tipo
		{
			get { return tipo; }
			set { tipo = value; }
		}

		private double precio;

		public double Precio
		{
			get { return precio; }
			set { precio = value; }
		}

		//Constructor

		public Ordinaria(int codAt, string titulo, string descripcion, DateTime fecha,Tipo tipo, double precio) :base(codAt,titulo,descripcion,fecha)
		{
			this.tipo = tipo;
			this.precio = precio;
		}
		public Ordinaria(int codAt, string titulo, string descripcion, DateTime fecha,Tipo tipo) : base(codAt, titulo, descripcion, fecha)
		{
			this.tipo = tipo;
			this.precio = (int)tipo;

		}
	}
	public enum Tipo { vacunacion = 850, desparacitacion = 650, baño = 350, corteDePelo = 150 }
}
