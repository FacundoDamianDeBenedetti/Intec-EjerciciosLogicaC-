using System;
using System.Collections.Generic;

namespace Encriptar_Mensajes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la frase");
            string frase = Console.ReadLine();

            Char[] separador = new Char[] { ' ', ',', '.'};

            string[] fraseSeparada = frase.Split(separador, StringSplitOptions.RemoveEmptyEntries);

            List<string> fraseInvertida = new List<string>();

            foreach (string palabra in fraseSeparada)
            {
                string palabraInvertida = InvertirPalabra(palabra);
                fraseInvertida.Add(palabraInvertida);
                Console.Write(palabraInvertida + " ");
            }
        }


        /// <summary>
        /// Recibe 1 string y lo devuelve al reves
        /// </summary>
        static string InvertirPalabra(string palabra)
        {
            char[] palabraAChars = palabra.ToCharArray();
            Array.Reverse(palabraAChars);

            return new string(palabraAChars);
        }
    }
}
