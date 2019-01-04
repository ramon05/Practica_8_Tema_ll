using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoCodeFirstModel.Models
{
	public class Estudiante
	{
		public int EstudianteID { get; set; }
		public String Nombres { get; set; }
		public string Apellidos { get; set; }
		public DateTime Fecha_Ingreso { get; set; }
		public virtual ICollection<Inscripcion> Inscripcions { get; set; }

	}
}
