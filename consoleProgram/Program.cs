using System;
using System.Collections.Generic;

// Clase de práctica C#
namespace pruconsola
{
    class clase1
    {
        public int uno;
        protected int dos;
        public void vector()
        {
            int[] miVector;
            miVector = new int[10];

            Random numeroAleatorio = new Random();
            for (int i = 0; i < miVector.Length; i++)
                miVector[i] = numeroAleatorio.Next(1, 1000);

            Console.WriteLine("Long = " + miVector.Length);

            for (int i = 0; i < miVector.Length; i++)
                Console.WriteLine(miVector[i]);
        }

        public void lista()
        {
            List<int> miLista;
            miLista = new List<int>();

            miLista.Add(4);
            miLista.Add(9);
            miLista.Add(12);
            miLista.Add(21);
            miLista.Add(6);

            foreach (int elemento in miLista)
                Console.WriteLine(elemento);
            miLista.Sort();
            miLista.Remove(4);
            for (int i = 0; i < miLista.Count; i++)
                Console.WriteLine("El elemento " + i + " es " + miLista[i]);
        }

        public void metodoPractica()
        {
            uno = 1;
            dos = 2;
            Console.WriteLine("Soy metodo de practica, saludos");
            Console.WriteLine("Valores: "+uno+" y "+dos);

        }
    }
 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo");
            System.Console.WriteLine("Hola Mundo 2");
            clase1 miObjeto = new clase1();
            miObjeto.metodoPractica();
            miObjeto.lista();
            miObjeto.vector();
        }
    }
}