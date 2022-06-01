using System;
using System.Collections.Generic;

namespace Anagrama
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] fechasBilly = { "16/07/1996", "09/03/1998", "15/09/1973" };

            List<string> fechasPrimo = new List<string>();

            foreach (string fechaBilly in fechasBilly)
            {
                fechasPrimo.Add(ModificarFecha(fechaBilly));
            }

            for (int indice = 0; indice < fechasPrimo.Count; indice++)
            {
                Console.WriteLine(fechasPrimo[indice]);
            }

        }



        /// <summary>
        /// Recibe 1 fecha en formato argentino (DD/MM/YYYY) y la convierte a formato estadounidense (MM/DD/YYYY) 
        /// </summary>
        static string ModificarFecha(string fechaAAjustar)
        {
            Char[] separador = new Char[] { '/' };


            string barra = "/";

            string[] fechaDividida = fechaAAjustar.Split(separador);

            string fechaAjustada = "";

            fechaAjustada += fechaDividida[1] + barra;
            fechaAjustada += fechaDividida[0] + barra;
            fechaAjustada += fechaDividida[2];

            return fechaAjustada;
        }
    }
}
