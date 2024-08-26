using Sesion2.clases;

namespace Sesion2
{

    //leer los datos de una oersina y decir si es mayor o menor de edad 
    //crear las clases

    internal class Program

    {
        static void Main(string[] args)
        {
            //esto es una variable

            string nombre;
            DateTime fechaNac;

            Persona persona = new Persona();


            Console.Write("Dime tu nombre: ");
            nombre = Console.ReadLine();
            Console.Write("En que fecha naciste: ");
            fechaNac = DateTime.Parse(Console.ReadLine());



            /*esto es set*/
            persona.Nombre = nombre;
            persona.FechaNac = fechaNac;

            Console.WriteLine(persona.EvaluarEdad());
           
        }
    }
}
