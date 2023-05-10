using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetExam.Entities
{
    public abstract class Persona
    {

        

        public int PersonaId { get; set; }
        public string Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }


        public Persona(int PersonaId, string Legajo, string Nombre, string Apellido)
        {
            this.PersonaId = PersonaId;
            this.Legajo = Legajo;
            this.Nombre = Nombre;
            this.Apellido = Apellido;

        }

        public Persona() { }

    }
}
