
using System;

namespace MapaDeClases {
    class MiembroDeLaComunidad {
        public string Nombre { get; set; }
        public string Cedula { get; set; }

        public void MostrarInfo() {
            Console.WriteLine($"Nombre: {Nombre}");
        }
    }

    class Estudiante : MiembroDeLaComunidad {
        public string Matricula { get; set; }
    }

    class ExAlumno : MiembroDeLaComunidad {
        public int AnioGraduacion { get; set; }
    }

    class Empleado : MiembroDeLaComunidad {
        public double Salario { get; set; }
    }

    class Administrativo : Empleado {
        public string Departamento { get; set; }
    }

    class Docente : Empleado {
        public string Asignatura { get; set; }
    }

    class Administrador : Docente {
        public string NivelAcceso { get; set; }
    }

    class Maestro : Docente {
        public int CantidadClases { get; set; }
    }
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("===== PRUEBA DE TODAS LAS CLASES =====\n");

              Estudiante est = new Estudiante();
            est.Nombre = "Shaira Rodriguez";
            est.Cedula = "001-199418-1";
            est.Matricula = "2024-001";

            Console.WriteLine("ESTUDIANTE");
            Console.WriteLine("Nombre: " + est.Nombre);
            Console.WriteLine("Matrícula: " + est.Matricula);
            Console.WriteLine();

              ExAlumno ex = new ExAlumno();
            ex.Nombre = "Luis Gomez";
            ex.Cedula = "001-2222222-2";
            ex.AnioGraduacion = 2025;

            Console.WriteLine("EX ALUMNO");
            Console.WriteLine("Nombre: " + ex.Nombre);
            Console.WriteLine("Año graduación: " + ex.AnioGraduacion);
            Console.WriteLine();

              Administrativo adm = new Administrativo();
            adm.Nombre = "Maria Perez";
            adm.Cedula = "001-3333333-3";
            adm.Departamento = "Finanzas";
            adm.Salario = 30000;

            Console.WriteLine("ADMINISTRATIVO");
            Console.WriteLine("Nombre: " + adm.Nombre);
            Console.WriteLine("Departamento: " + adm.Departamento);
            Console.WriteLine("Salario: " + adm.Salario);
            Console.WriteLine();

              Maestro maestro = new Maestro();
            maestro.Nombre = "Jose Ramirez";
            maestro.Cedula = "001-2953001-0";
            maestro.Asignatura = "Programación II";
            maestro.CantidadClases = 3;
            maestro.Salario = 45000;

            Console.WriteLine("MAESTRO");
            Console.WriteLine("Nombre: " + maestro.Nombre);
            Console.WriteLine("Asignatura: " + maestro.Asignatura);
            Console.WriteLine("Clases: " + maestro.CantidadClases);
            Console.WriteLine("Salario: " + maestro.Salario);
            Console.ReadKey();
        }
    }
}
