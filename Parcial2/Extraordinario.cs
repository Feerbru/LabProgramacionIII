using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Parcial2
{
	//las extraordinarias son consultas por enfermedad.
	class Extraordinario : Atencion
    {
		//Campos
		private bool signosVitales;

		public bool SignosVitales
		{
			get { return signosVitales; }
			set { signosVitales = value; }
		}

		private string diagnostico;

		public string Diagnostico
		{
			get { return diagnostico; }
			set { diagnostico = value; }
		}

		private string tratamiento;

		public string Tratamiento
		{
			get { return tratamiento; }
			set { tratamiento = value; }
		}
		//Constructores
		public Extraordinario(bool signosVitales, string diagnostico, string tratamiento)
		{
			SignosVitales = signosVitales;
			Diagnostico = diagnostico;
			Tratamiento = tratamiento;
		}


	}
}
