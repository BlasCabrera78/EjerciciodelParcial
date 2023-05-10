namespace DotnetExam.Entities
{
    public class Alumno :  Persona
    {
        public int AlumnoId { get; set; }
        public string Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Alumno(int AlumnoId, string Legajo, string Nombre, string Apellido) 
        {
            this.AlumnoId = AlumnoId;
            this.Legajo = Legajo;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
        
        }

        public Alumno() { }

        public Alumno(string Nombre)
        {
            this.Nombre = Nombre;
        
        }

        public string NombreCompleto { 
            get { 
                return $"{Nombre} {Apellido}";
            } 
        }

        public override string ToString()
        {
            return NombreCompleto;
        }

    }
}