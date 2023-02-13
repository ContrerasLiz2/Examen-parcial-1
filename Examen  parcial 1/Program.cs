//Hacer un programa que lea  nombre , correo , maateria , calificacion y estatus de un alumno ,
//el programa repetira esta accionhasta que el usuario se lo pida . 

// Una vez introducido los datos el programa mostrara el nombre , correo y estatus de los alumnos activos
// y ademas la cantidad de alumonos inactivos . Para finalizar mostrara el alumno con mayor calificacion 




namespace LeerDatosAlumno
{
    class Alumno
    {
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Materia { get; set; }
        public int Calificacion { get; set; }
        public string Estatus { get; set; }
    }

    class Program
    {
        private static void GetV() => Console.WriteLine("Nombre: {0}");

        private static void Main(string[] args)
        {
            Main(args, Console.WriteLine(""));
        }

        static void Main(string[] args)
        {
            List<Alumno> listaAlumnos = new List<Alumno>();
            string opcion = "";

            do
            {
                Console.WriteLine("Introduce el Nombre del  alumno:");
                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();
                Console.Write(" Ingresa Correo: ");
                string correo = Console.ReadLine();
                Console.Write("Materia: ");
                string materia = Console.ReadLine();
                Console.Write("Calificación: ");
                int calificacion = int.Parse(Console.ReadLine());
                Console.Write("Estatus (Activo/Inactivo): ");
                string estatus = Console.ReadLine();

                listaAlumnos.Add(new Alumno { Nombre = nombre, Correo = correo, Materia = materia, Calificacion = calificacion, Estatus = estatus });

                Console.WriteLine("¿Deseas introducir otro alumno? (Y/N)");
                opcion = Console.ReadLine();
            } while (opcion.ToUpper() == "Y");

            Console.WriteLine("\nDatos de los alumnos activos:");
            int contadorInactivos = 0;
            



           