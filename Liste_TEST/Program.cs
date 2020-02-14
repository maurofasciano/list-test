using System;

namespace Liste_TEST
{
    class Program
    {
        /// <summary>
        /// Creazione istanza classe lista, altrimentio non passa
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var lista = new Liste();  
            lista.List();
        }
    }

    public class Liste
    {
        public void List()
        {

            int[] myInt = { 1, 15, 37, 9 };

            myInt[0] = 100;

            Console.WriteLine("Valore di posizione array {0}", myInt[0]);
            Console.ReadLine();

        }
    }

}
