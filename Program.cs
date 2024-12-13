using System;
using Estudiantes;
class Program {
    static void Main(string[] args){
        Console.WriteLine("Hola que tal, bienvenido a el gestor de notas de Christian Ormachea!");
        
        Console.WriteLine("Seleccione la opcion dentro del menu: ");
        Console.WriteLine("0. Ingrese un nuevo estudiante al sistema.");
        Console.WriteLine("1. Ingrese una nueva nota.");
        Console.WriteLine("2. Ver todas las notas.");
        Console.WriteLine("3. Calcular el promedio de las notas");
        Console.WriteLine("4. Salir");

        List<Estudiante> estudiantes = new List<Estudiante>();
        int opcion = int.Parse(Console.ReadLine());

        if(opcion == 4){
            Console.WriteLine("Gracias, vuelva prontos! :)");
            return;
        }

        Estudiante estudiante01 = new Estudiante("juan");
        estudiante01.AgregarNota(8);
        estudiante01.AgregarNota(7);
        estudiante01.AgregarNota(6);
        estudiantes.Add(estudiante01);

        
            switch(opcion){
            case 0: 
                Console.WriteLine("Ingrese el nombre del nuevo estudiante a ingresar:");
                string nombreEstudiante = Console.ReadLine();
                Estudiante estudianteNuevo = new Estudiante(nombreEstudiante);
                estudiantes.Add(estudianteNuevo);
                break;
            case 1:
                Console.WriteLine("A que estudiante desea agregarle la nota? ");
                string nombreEstudianteABuscar = Console.ReadLine();    
                int notaAAgregar = int.Parse(Console.ReadLine());
                dynamic estudianteEncontrado = null;
                foreach(var estudiante in estudiantes){
                    if(estudiante.Nombre() == nombreEstudianteABuscar){
                        estudianteEncontrado = estudiante;
                        estudiante.AgregarNota(notaAAgregar);
                    }
                }

                if(estudianteEncontrado == null){
                    Console.WriteLine("Error, no se encontro al estudiante en el sistema. ");
                }

                break;
            case 2:
                Console.WriteLine("A que estudiante desea verle la nota? ");
                string nombreEstudianteNota = Console.ReadLine();
                dynamic estudianteAMostrarNota = null;
                foreach (var estudiante in estudiantes)
                {
                    if(estudiante.Nombre() == nombreEstudianteNota){
                        estudianteAMostrarNota = estudiante;
                        estudiante.MostrarNotas();
                    }  
                }

                if(estudianteAMostrarNota == null){
                    Console.WriteLine("Error, no se encontro al estudiante en el sistema.");
                }

                break;
            case 3:
                Console.WriteLine("A que estudiante quiere verle el promedio.");
                string nombreEstudiantePromedio = Console.ReadLine();
                dynamic estudianteAMostrarPromedio = null;

                foreach (var estudiante in estudiantes)
                {
                    if(estudiante.Nombre() == nombreEstudiantePromedio){
                        estudianteAMostrarPromedio = estudiante;
                        estudiante.Promedio();
                    }
                }

                if(estudianteAMostrarPromedio == null){
                    Console.WriteLine("Error, no se encontro el estudiante en el sistema.");
                }
                break;
            default:
                Console.WriteLine("Error, ingrese una opcion valida.");
                break; 

            }
        


        
    }

}
