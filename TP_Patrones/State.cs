using System;
namespace Patron_State
{
    // Interfaz para definir los métodos que deben ser implementados por los estados concretos.
    interface IEstado
    {
        void Manejar();
    }

    // Clase concreta que representa un estado específico.
    class EstadoConcretoA : IEstado
    {
        public void Manejar()
        {
            Console.WriteLine("Manejar el Estado Concreto A");
        }
    }

    // Clase concreta que representa otro estado específico.
    class EstadoConcretoB : IEstado
    {
        public void Manejar()
        {
            Console.WriteLine("Manejar el Estado Concreto B");
        }
    }

    // Clase de contexto que mantiene una referencia al estado actual.
    class Contexto
    {
        private IEstado estadoActual;

        public Contexto()
        {
            // Inicializar el estado actual, por ejemplo, a EstadoConcretoA.
            estadoActual = new EstadoConcretoA();
        }

        public void CambiarEstado(IEstado nuevoEstado)
        {
            estadoActual = nuevoEstado;
        }

        public void RealizarOperacion()
        {
            estadoActual.Manejar();
        }
    }

    class State
    {
        static void Main(string[] args)
        {
            // Crear el contexto.
            Contexto contexto = new Contexto();

            // Realizar operación en el estado actual.
            contexto.RealizarOperacion();

            // Cambiar al otro estado.
            contexto.CambiarEstado(new EstadoConcretoB());

            // Realizar operación en el nuevo estado.
            contexto.RealizarOperacion();
        }
    }

}