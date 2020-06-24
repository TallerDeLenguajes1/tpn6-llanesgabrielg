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

        //    public static string partCad(string cadena, int indInicial, int posicion)
        //    {
        //        string result = cadena.Substring(indInicial, posicion);
        //        return result;
        //    }

        //static void Main(string[] args)
        //    {
        //        string numero,invertida="";
        //        int posicion,numTOentero;

        //        Console.Write("ingresar numero a invertir: ");
        //        numero = Console.ReadLine(); // recibe una cadena
        //        numTOentero = Convert.ToInt32(numero); // casteo a numTOentero para hacer el control
        //        posicion = numero.Length; // tamaño de la cadena 

        //        if (numTOentero > 0)
        //        {
        //            while (posicion > 0)
        //            {
        //                // en cada ciclo del bucle obtenemos un caracter empezando por el
        //                // final para invertir la cadena.
        //                invertida = invertida + partCad(numero, posicion - 1, 1);
        //                posicion = posicion - 1;
        //            }

        //            Console.WriteLine("La numero invertida es: " + invertida);

        //        }
        //        else
        //        {
        //            Console.WriteLine("no se puede hacer la conversion de numeros menores o iguales a cero");
        //        }


        //    }

        //public static void menu()
        //{
        //    Console.WriteLine("\n-------menu calculadora---------\n");
        //    Console.WriteLine("\n_SUMA_(1)");
        //    Console.WriteLine("\n_RESTA_(2)");
        //    Console.WriteLine("\n_MULTIPLICACION_(3)");
        //    Console.WriteLine("\n_DIVICION_(4)");
        //    //Console.WriteLine("\n_SALIR DEL PROGRAMA_(5)");
        //    Console.WriteLine("\n-------------------\n");
        //}
        //public static int salir(char opcionSalir)
        //{
        //    if (opcionSalir == 'n' || opcionSalir == 'N')
        //    {
        //        return 5;
        //    }
        //    else
        //    {
        //        return 0;
        //    }
        //}
        //static void Main(string[] args)
        //{
        //    int opcion, num1, num2, multiplicacion, division;
        //    char opcionChar;
        //    do
        //    {
        //        menu();
        //        Console.WriteLine("\n\n SELECCIONAR UNA OPCION : ");
        //        opcion = Convert.ToInt32(Console.ReadLine());
        //        // opcionSalir = Convert.ToChar(opcion); // 

        //        switch (opcion)
        //        {
        //            case 1:
        //                Console.Clear(); // limpiar pantalla
        //                Console.WriteLine("ingrese dos numeros enteros  : ");
        //                num1 = Convert.ToInt32(Console.ReadLine());
        //                num2 = Convert.ToInt32(Console.ReadLine());

        //                Console.WriteLine("la suma es : " + (num1 + num2));
        //                Console.WriteLine("\ndesea continuar realizando calculos,  S/N : ");
        //                opcionChar = Convert.ToChar(Console.ReadLine());
        //                opcion = salir(opcionChar);
        //                Console.Clear();// limpiar pantalla

        //                break;
        //            case 2:
        //                Console.Clear();
        //                Console.WriteLine("ingrese dos numeros enteros  : ");
        //                num1 = Convert.ToInt32(Console.ReadLine());
        //                num2 = Convert.ToInt32(Console.ReadLine());
        //                Console.WriteLine("la resta es : " + (num1 - num2));
        //                Console.WriteLine("\ndesea continuar realizando calculos,  S/N : ");
        //                opcionChar = Convert.ToChar(Console.ReadLine());
        //                opcion = salir(opcionChar);
        //                Console.Clear();

        //                break;
        //            case 3:
        //                Console.Clear();
        //                Console.WriteLine("ingrese dos numeros enteros : ");
        //                num1 = Convert.ToInt32(Console.ReadLine());
        //                num2 = Convert.ToInt32(Console.ReadLine());
        //                multiplicacion = num1 * num2;
        //                Console.WriteLine("la multiplicacion  es : " + (multiplicacion));
        //                Console.WriteLine("\ndesea continuar realizando calculos,  S/N : ");
        //                opcionChar = Convert.ToChar(Console.ReadLine());
        //                opcion = salir(opcionChar);
        //                Console.Clear();
        //                break;
        //            case 4:
        //                Console.Clear();
        //                Console.WriteLine("ingrese dos numeros enteros : ");
        //                num1 = Convert.ToInt32(Console.ReadLine());
        //                num2 = Convert.ToInt32(Console.ReadLine());
        //                if (num2 != 0)
        //                {
        //                    division = num1 / num2;
        //                    Console.WriteLine("la division es : " + (division));
        //                    Console.WriteLine("\ndesea continuar realizando calculos,  S/N : ");
        //                    opcionChar = Convert.ToChar(Console.ReadLine());
        //                    opcion = salir(opcionChar);
        //                    Console.Clear();
        //                }
        //                else
        //                {
        //                    Console.WriteLine("error, no se puede dividir por cero");
        //                    Console.WriteLine("\ndesea continuar realizando calculos,  S/N : ");
        //                    opcionChar = Convert.ToChar(Console.ReadLine());
        //                    opcion = salir(opcionChar);
        //                    Console.Clear();
        //                }
        //                break;
        //            default:
        //                if (opcion != 5)
        //                {
        //                    Console.Clear();
        //                    Console.WriteLine("opcion incorrecta, vuelva a ingresar");
        //                }

        //                break;
        //        }

        //    } while (opcion != 5);
        //    Console.WriteLine("chau chau adios!! ");
        //}

        // punto 3
        public static void Mostrar(float numero)
        {
            int partInt;
            Console.WriteLine("\nel valor absoluto es : " + (Math.Abs(numero)));

            Console.WriteLine("\n_el cuadrado es : " + (Math.Pow(numero, 2)));
            Console.WriteLine("\n_la raiz es : " + Math.Sqrt(numero));
            Console.WriteLine("\n_el seno es : " + (Math.Sin(numero)));
            Console.WriteLine("\n_el coseno es: " + (Math.Cos(numero)));
            partInt = Convert.ToInt32(numero); // casteo a entero
            Console.WriteLine("\n la parte entera es\n" + partInt); // muestro solo la parte entera
        }
        static void Main(string[] args)
        {
            float numero, numero2, numero3;
            Console.WriteLine("\n ingresar un numero :\n ");

            numero = Convert.ToSingle(Console.ReadLine());// hago ingreso y casteo a float 
            Mostrar(numero); // funcion para mostrar todo lo pedido
            Console.WriteLine("\n ingresar dos numeros nuevos :\n");
            numero2 = Convert.ToSingle(Console.ReadLine());
            numero3 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("el mayor de los numeros ingresados es :" + (Math.Max(numero2, numero3)));
            Console.WriteLine("el menor de los numeros ingresados es :" + (Math.Min(numero2, numero3)));
        }

    }
}

