using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Models
{
    public class ModeloPrueba
    {
        public Persona ObtenerPersona()
        {
            Persona laPersona = new Persona("Farías", "Gonzalo", 22);
            return laPersona;
        }
        public List<Persona> ObtenerPersonas()
        {
            List<Persona> lasPersonas = new List<Persona>();
            Persona laPersona = new Persona("Faraday", "Michael", 33);
            lasPersonas.Add(laPersona);
            lasPersonas.Add(new Persona("Volta", "Alessandro", 23));
            lasPersonas.Add(new Persona("González", "María", 32));
            lasPersonas.Add(new Persona("López", "Juan", 28));
            lasPersonas.Add(new Persona("Martínez", "Laura", 24));
            lasPersonas.Add(new Persona("Pérez", "Carlos", 29));
            lasPersonas.Add(new Persona("Rodríguez", "Ana", 27));
            lasPersonas.Add(new Persona("Fernández", "José", 35));
            lasPersonas.Add(new Persona("Gómez", "Sofía", 30));
            lasPersonas.Add(new Persona("Díaz", "Luis", 26));
            lasPersonas.Add(new Persona("Torres", "Marta", 31));
            lasPersonas.Add(new Persona("Ramírez", "Pedro", 22));
            lasPersonas.Add(new Persona("Gutiérrez", "Carolina", 33));
            lasPersonas.Add(new Persona("Sánchez", "Miguel", 25));
            lasPersonas.Add(new Persona("Vargas", "Alejandra", 37));
            lasPersonas.Add(new Persona("Flores", "Diego", 28));
            lasPersonas.Add(new Persona("Ruiz", "Elena", 34));
            return lasPersonas;
        }
    }
    public class Persona(String inombre, String iapellido, int iedad)
	{
        public int edad { get; set; } = iedad;
        public string nombre { get; set; } = inombre;
        public string apellido { get; set; } = iapellido;
    }
}
