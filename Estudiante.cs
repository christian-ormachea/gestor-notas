namespace Estudiantes 
{
    public class Estudiante 
    {
        private string nombre;
        private int[] notas;
        private int cantidadNotas; 
        public Estudiante(string nombreConstructor){
            nombre = nombreConstructor;
            notas = new int[0];
            cantidadNotas = 0;
        }

        public void AgregarNota(int unaNota){
            int[] nuevoArray = new int[cantidadNotas + 1];

            for (int i = 0; i < cantidadNotas; i++)
            {
                nuevoArray[i] = notas[i];
            }

            nuevoArray[cantidadNotas] = unaNota;

            notas = nuevoArray;
            cantidadNotas++;
        }

        public void Promedio(){
            decimal promedio = 0;

            if (notas.Length == 0)
            {
                Console.WriteLine("Erorr, el estudiante no tiene notas todavia");
            }

            foreach (var nota in notas)
            {   
                promedio = promedio + nota;
            }
            promedio = promedio / (notas.Length);

            Console.WriteLine($"El promedio del estudiante: {nombre} es: {promedio}");
        }

        public void MostrarNotas(){
            Console.WriteLine(nombre);
            foreach (var nota in notas)
            {
                Console.WriteLine(nota);
            }
        }

        public string Nombre(){
            return nombre;
        }
    }
}