using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTareasEntidades
{
	public class Tareas
	{
		public int Id { get; set; }
		public string Nombre { get; set; }
		public bool Completado { get; set; }
		public DateTime FechaVencimiento { get; set; }
		public Tipo Tipo { get; set; }

				
	}
}
