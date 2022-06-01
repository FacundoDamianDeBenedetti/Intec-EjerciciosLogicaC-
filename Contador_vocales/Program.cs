using System;

namespace Contador_vocales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una frase");
            string frase = Console.ReadLine().ToLower();
            Console.WriteLine(ContarVocales(frase));
        }





        /// <summary>
        /// Recibe una frase y devuelve la cantidad de vocales que tiene la misma.
        /// </summary>
        static int ContarVocales(string frase)
        {

            int contadorVocales = 0;

            if (frase.Length > 100)
            {
                Console.WriteLine("La frase no puede superar los 100 caracteres");
            }
            else
            {
                for (int i = 0; i < frase.Length; i++)
                {
                    switch (frase[i])
                    {
                        case 'a':
                            contadorVocales += 1;
                            break;
                        case 'e':
                            contadorVocales += 1;
                            break;
                        case 'i':
                            contadorVocales += 1;
                            break;
                        case 'o':
                            contadorVocales += 1;
                            break;
                        case 'u':
                            contadorVocales += 1;
                            break;
                    }
                }

                
            }
            return contadorVocales;
        }
        
    }
}
