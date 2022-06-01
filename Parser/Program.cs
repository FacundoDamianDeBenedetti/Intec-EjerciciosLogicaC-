using BenchmarkDotNet.Reports;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using Prometheus;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Parser
{
    class Program
    {
        static void Main(string[] args)
        {

            string primerString = "xyaabbbccccdefwwzzz";
            string segundoString = "xxxxyyyyabklmopgghqzzzz";

            IOrderedEnumerable<char> stringCorrecto = OrdenarStrings(primerString, segundoString);

            foreach (char caracter in stringCorrecto)
            {
                Console.Write(caracter);
                Console.Write(" ");
            }

        }


        /// <summary>
        /// Recibe 2 strings, los compara y  une. Devuelve 1 solo string sin que se repita ningun caracter y ordenado alfabeticamente.
        /// </summary>
        static IOrderedEnumerable<char> OrdenarStrings(string primerString, string segundoString)
        {
            HashSet<char> stringNetoPrimero = new HashSet<char>(primerString);
            HashSet<char> stringNetoSegundo = new HashSet<char>(segundoString);

            stringNetoPrimero.UnionWith(stringNetoSegundo);

            IOrderedEnumerable<char> stringUnico = stringNetoPrimero.OrderBy(alfabeto => alfabeto);

            return stringUnico;
        }
    }
}