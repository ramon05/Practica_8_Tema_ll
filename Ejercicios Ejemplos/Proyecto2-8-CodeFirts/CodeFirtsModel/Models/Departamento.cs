using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirtsModel.Models
{
	public class Departamento
	{
		public int DepartamentoID { get; set; }
		public string Descripcion { get; set; }
		public virtual ICollection<Registro> Registros { get; set; }

	}
}
