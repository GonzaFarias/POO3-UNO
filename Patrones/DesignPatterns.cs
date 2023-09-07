using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    abstract class PatronComposite
    {
        protected String nombre;

        public PatronComposite()
        { this.nombre = ""; }

        public PatronComposite(String nombre)
        { this.nombre = nombre; }

        abstract public void agregar(PatronComposite c);
        abstract public void eliminar(PatronComposite c);
        abstract public void mostrar(int profundidad);
    }
    class Compuesto : PatronComposite
    {

        private List<PatronComposite> hijo = new List<PatronComposite>();

        public Compuesto() : base()
        {
            return;
        }

        public Compuesto(String nombre) : base(nombre)
        { return ; }
        public override void agregar(PatronComposite componente)
        {
            hijo.Add(componente);
        }

        public override void eliminar(PatronComposite componente)
        {
            hijo.Remove(componente);
        }
        public override void mostrar(int profundidad)
        {
            Console.WriteLine(nombre + " nivel: " + profundidad);
            for (int i = 0; i < hijo.Count; i++)
                hijo[i].mostrar(profundidad + 1);
        }
    }
    class Hoja : PatronComposite
    {

        public Hoja() : base()
        {
            ;
        }
        public Hoja(String nombre) : base(nombre)
        {
        }
        public override void agregar(PatronComposite c)
        {
            Console.WriteLine("no se puede agregar la hoja");
        }
        public override void eliminar(PatronComposite c)
        {
            Console.WriteLine("no se puede quitar la hoja");
        }
        public override void mostrar(int profundidad)
        {
            Console.WriteLine('-' + "" + nombre);
        }
        static void Main(string[] args)
        {
            Compuesto obj1 = new Compuesto();
            Hoja obj2 = new Hoja();
        }
    }
    
}
