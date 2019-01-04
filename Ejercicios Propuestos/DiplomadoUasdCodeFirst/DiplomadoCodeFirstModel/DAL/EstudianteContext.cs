using DiplomadoCodeFirstModel.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoCodeFirstModel.DAL
{
	public class EstudianteContext : DbContext
	{
		public EstudianteContext()
			: base("EstudianteContext")

		{
		}

		public DbSet<Estudiante> Estudiantes { get; set; }
		public DbSet<Inscripcion> Inscripciones { get; set; }
		public DbSet<Curso> Cursos { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}
	}
}
