using System;

namespace tp6
{
    class Program
    {
        /**
         * Definimos la funcion partCad que devuelve parte de una cadena
         * Recibe:
         *  - una cadena
         *  - la posicion inicial
         *  - la longitud a devolver
         */
        public static string partCad(string cadena, int indInicial, int posicion)
        {
            string result = cadena.Substring(indInicial, posicion);
            return result;
        }
 
        static void Main(string[] args)
        {
            string numero,invertida="";
            int posicion,numTOentero;
 
            Console.Write("ingresar numero a invertir: ");
            numero = Console.ReadLine(); // recibe una cadena
            numTOentero = Convert.ToInt32(numero); // casteo a numTOentero para hacer el control
            posicion = numero.Length; // tamaño de la cadena 
            
            if (numTOentero > 0)
            {
                while (posicion > 0)
                {
                    // en cada ciclo del bucle obtenemos un caracter empezando por el
                    // final para invertir la cadena.
                    invertida = invertida + partCad(numero, posicion - 1, 1);
                    posicion = posicion - 1;
                }

                Console.WriteLine("La numero invertida es: " + invertida);

            }
            else
            {
                Console.WriteLine("no se puede hacer la conversion de numeros menores o iguales a cero");
            }
            
            
        }
    }
}

