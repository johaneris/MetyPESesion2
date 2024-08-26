using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//se llama asi pq reune todas las caracteristicas
//atributos 
//clase en mayuscula, singular
//clase madre object, ya trae el contstructpr, la clase hija lo trae por defecto

namespace Sesion2.clases
{
    internal class Persona
    {
        public Persona() { } //constructor

        //atributos, nombre ne mayuscula pq es una propiedad, metodos get y set
        //Tarea, hacer un cuadro sobre las buenas practicas de programaci[on en c#
        public string Nombre { get; set; }
        public DateTime FechaNac { get; set; }

        //envento

        public int CalcularEdad()
        {
            return DateTime.Now.Year - FechaNac.Year;
        }

        //siempre una funcion debe retornar algo, no es necesario es Else

        public string EvaluarEdad()
        {
            if (CalcularEdad() >= 18) return "Mayor de edad";
            return "Menor de edad";
        }
    }
}
