using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetExam.Entities
{
    public static class MateriaGenerador
    {
        public static List<Materia> Generar(int cantidad, int alumnosPorMateria) {

            var materias = new List<Materia>();

            for (int i = 1; i <= cantidad; i++)
            {
                var materia = new Materia()
                {
                    MateriaId = i,
                    Nombre = $"Materia {i}"
                };


                for (int a = 1; a <= alumnosPorMateria; a++)
                {
                    materia.Alumnos.Add(new Alumno() { 
                        AlumnoId = a,
                        Legajo = $"M{i}-{a.ToString().PadLeft(6, '0')}/23",
                        Nombre = $"Nombre {a}",
                        Apellido = $"Apellido {a}"
                    });
                }
               

                materias.Add(materia);

                
            }

            return materias;
        } 
    }
}
