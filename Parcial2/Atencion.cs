using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Parcial2
{
    class Atencion
    {

		public enum Atenciones { vacunacion = 850, desparacitacion = 650, baño = 350, corteDePelo = 150 }

		private int codAt;

		public int CodAt
		{
			get { return codAt; }
			set { codAt = value; }
		}

		private string titulo;

		public string Titulo
		{
			get { return titulo; }
			set { titulo = value; }
		}

		private string descripcion;

		public string Descripcion
		{
			get { return descripcion; }
			set { descripcion = value; }
		}

		private DateTime fecha;

		public DateTime  Fecha
		{
			get { return fecha; }
			set { fecha = value; }
		}

		//Constructor
		public Atencion(int codAt, string titulo, string descripcion, DateTime fecha)
		{
			CodAt = codAt;
			Titulo = titulo;
			Descripcion = descripcion;
			Fecha = fecha;
		}

		public Atencion()
		{
		}

	}
}
