using DiplomadoCodeFirstModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomadoCodeFirstModel.DAL
{
	class CargarDatos : System.Data.Entity.DropCreateDatabaseIfModelChanges<EstudianteContext>
	{
		protected override void Seed(EstudianteContext context)
		{
			var Estudiantes = new List<Estudiante>
			{
				new Estudiante{Nombres="Ramon Agustin", Apellidos="Castillo Veras", Fecha_Ingreso=DateTime.Parse("2018-10-02"),},
				new Estudiante{Nombres="Felix Augusto", Apellidos="Ozuna Ramirez", Fecha_Ingreso=DateTime.Parse("2018-10-02"),},
				new Estudiante{Nombres="Yorqui", Apellidos="MoNtero Sanchez", Fecha_Ingreso=DateTime.Parse("2018-10-02"),},
				new Estudiante{Nombres="FERNIELIS", Apellidos="VICIOSO RODRIGUEZ", Fecha_Ingreso=DateTime.Parse("2018-10-02"),},
				new Estudiante{Nombres="Jose Carlos ", Apellidos="Rivera Hernandez", Fecha_Ingreso=DateTime.Parse("2018-10-02"),},
				new Estudiante{Nombres="Junior", Apellidos="Maria Araujo", Fecha_Ingreso=DateTime.Parse("2018-10-02"),},
				new Estudiante{Nombres="Wilson", Apellidos="Garcia Nova Garcia", Fecha_Ingreso=DateTime.Parse("2018-10-02"),},
				new Estudiante{Nombres="Emiris Antonio ", Apellidos="Cuevas Méndez", Fecha_Ingreso=DateTime.Parse("2018-10-02"),},
				new Estudiante{Nombres="MIKELSON ", Apellidos="BAEZ PANIAGUA", Fecha_Ingreso=DateTime.Parse("2018-10-02"),},
				new Estudiante{Nombres="Franmark ", Apellidos="Collazo Comas", Fecha_Ingreso=DateTime.Parse("2018-10-02"),},
				new Estudiante{Nombres="Jose SERAPIO", Apellidos="Cruz CESPEDES", Fecha_Ingreso=DateTime.Parse("2018-10-02"),},
				new Estudiante{Nombres="Doillan Carill ", Apellidos="Perez Feliz", Fecha_Ingreso=DateTime.Parse("2018-10-02"),},
				new Estudiante{Nombres="Juan Carlos ", Apellidos="Reyes Jimenez", Fecha_Ingreso=DateTime.Parse("2018-10-02"),},
				new Estudiante{Nombres="Fabio Ramon ", Apellidos="Lajara Reyes", Fecha_Ingreso=DateTime.Parse("2018-10-02"),},
				new Estudiante{Nombres="Juan Javier ", Apellidos="Rufino Arias", Fecha_Ingreso=DateTime.Parse("2018-10-02"),},
				new Estudiante{Nombres="Eliezer ", Apellidos="de la Rosa Perez", Fecha_Ingreso=DateTime.Parse("2018-10-02"),},
				new Estudiante{Nombres="Francis Manuel ", Apellidos="Beltre Gomez", Fecha_Ingreso=DateTime.Parse("2018-10-02"),},
				new Estudiante{Nombres="Marileidy ", Apellidos="Manzueta De la Rosa", Fecha_Ingreso=DateTime.Parse("2018-10-02"),},
				new Estudiante{Nombres="Juan Ariel ", Apellidos="De la Cruz García", Fecha_Ingreso=DateTime.Parse("2018-10-02"),},
				new Estudiante{Nombres="Alberto ", Apellidos="Reynoso Mateo", Fecha_Ingreso=DateTime.Parse("2018-10-02"),},
				new Estudiante{Nombres="PEDRO FEDERICO ", Apellidos="GARCIA MEDINA", Fecha_Ingreso=DateTime.Parse("2018-10-02"),},
				new Estudiante{Nombres="Marlon Jose ", Apellidos="Santana", Fecha_Ingreso=DateTime.Parse("2018-10-02"),},
				new Estudiante{Nombres="Rafael Albeniz", Apellidos="Vargas Encarnacion", Fecha_Ingreso=DateTime.Parse("2018-10-02"),},
				new Estudiante{Nombres="ALLEN NATANIEL ", Apellidos="FÉLIZ FÉLIZ", Fecha_Ingreso=DateTime.Parse("2018-10-02"),},
			};
			Estudiantes.ForEach(s => context.Estudiantes.Add(s));
			context.SaveChanges();

			var Cursos = new List<Curso>
			{
				new Curso{CursoID=1, Descrpcion="Diplomado Desarrollo Web (C#)",},
				new Curso{CursoID=2, Descrpcion="CiberSeguridad",},

			};
			Cursos.ForEach(s => context.Cursos.Add(s));
			context.SaveChanges();

			var Inscripciones = new List<Inscripcion>
			{
				new Inscripcion{EstudianteID=1, CursoID=1, Semestre=8},
				new Inscripcion{EstudianteID=2, CursoID=1, Semestre=5},
				new Inscripcion{EstudianteID=3, CursoID=1, Semestre=6},
				new Inscripcion{EstudianteID=4, CursoID=1, Semestre=4},
				new Inscripcion{EstudianteID=5, CursoID=1, Semestre=3},
				new Inscripcion{EstudianteID=6, CursoID=1, Semestre=7},
				new Inscripcion{EstudianteID=7, CursoID=1, Semestre=2},
				new Inscripcion{EstudianteID=8, CursoID=1, Semestre=6},
				new Inscripcion{EstudianteID=9, CursoID=1, Semestre=5},
				new Inscripcion{EstudianteID=10, CursoID=1, Semestre=9},
			};
			Inscripciones.ForEach(s => context.Inscripciones.Add(s));
			context.SaveChanges();
		}
	}
}

