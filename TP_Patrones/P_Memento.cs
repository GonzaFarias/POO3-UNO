using System;
using System.Collections.Generic;

namespace Patron_Memento
{
    // Clase Origen que representa el estado original que queremos guardar y restaurar.
    class Origen
    {
        private string estado;

        public Origen(string estadoInicial)
        {
            estado = estadoInicial;
        }

        public void SetEstado(string nuevoEstado)
        {
            estado = nuevoEstado;
        }

        public string GetEstado()
        {
            return estado;
        }

        public Memento Guardar()
        {
            return new Memento(estado);
        }

        public void Restaurar(Memento memento)
        {
            estado = memento.GetEstado();
        }
    }

    // Clase Memento que representa el objeto que almacena el estado.
    class Memento
    {
        private string estado;

        public Memento(string estado)
        {
            this.estado = estado;
        }

        public string GetEstado()
        {
            return estado;
        }
    }

    // Clase Caretaker que es responsable de mantener y gestionar los momentos (Mementos).
    class Caretaker
    {
        private List<Memento> momentos = new List<Memento>();

        public void AgregarMemento(Memento memento)
        {
            momentos.Add(memento);
        }

        public Memento ObtenerMemento(int indice)
        {
            if (indice >= 0 && indice < momentos.Count)
            {
                return momentos[indice];
            }
            else
            {
                return null;
            }
        }
    }

    class main
    {
        static void Main(string[] args)
        {
            // Crear el objeto de origen y el caretaker.
            Origen origen = new Origen("Estado Inicial");
            Caretaker caretaker = new Caretaker();

            // Guardar el estado inicial en el caretaker.
            caretaker.AgregarMemento(origen.Guardar());

            // Cambiar el estado del origen.
            origen.SetEstado("Nuevo Estado");

            // Guardar el nuevo estado en el caretaker.
            caretaker.AgregarMemento(origen.Guardar());

            // Restaurar el estado original desde el caretaker.
            origen.Restaurar(caretaker.ObtenerMemento(0));

            Console.WriteLine("Estado actual: " + origen.GetEstado());
        }
    }
}