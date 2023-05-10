using DotnetExam.Entities;
using System.Collections.Generic;
using System.Collections;
using Xunit;

namespace DotnetExam.Tests
{
    public class Exam_DNIXXX_APELLIDOYYY
    {
        [Fact]
        public void Test1_Teoria_NET()
        {

            //Describa la diferencia entre .NET Framework y .NET Core
            var respuesta = "La principal es que en el caso de .Net Core su uso es mas orientado para las " +
                "aplicaciones multiplataforma mas modernas y puede ejecutarse en multiples sistemas operativos " +
                ".Net Framework su uso es mas adecuado para aplicaciones Windows que necesiten compatibilidad " +
                "con ciertas bibliotecas y solo se ejecuta en Windows ";

            Assert.NotEqual(string.Empty, respuesta);


        }

        [Fact]
        public void Test2_Teoria_Assembly()
        {


            //Describa que es un assembly o ensamblado en .NET
            var respuesta = "Un assembly es un archivo que contiene el código compilado de una o varias clases" +
                "también puede incluir información necesaria del código y su uso, pueden adoptar la forma de un " +
                "archivo .txt, .dll o exe, en general se usa para organizar el código y los recursos necesarios " +
                "para un buen funcionamiento en el entorno de desarrollo ";

            Assert.NotEqual(string.Empty, respuesta);


        }


        [Fact]
        public void Test3_Teoria_IL()
        {


            //Describa que es el Lenguaje Intermedio o IL
            var respuesta = "Es un lenguaje de programación intermedio utilizado en la plataforma .Net" +
                "esto quiere decir que es un lenguaje de bajo nivel que se genera al compilar programas escritos " +
                "en Lenguajes .Net de alto nivel. ";

            Assert.NotEqual(string.Empty, respuesta);


        }




        [Fact]
        public void Test4_DateTime_Formatting()
        {
           

            var finalWorldCupMatch = new DateTime(2022, 12, 18, 15, 30, 23);


            Assert.Equal("18/12/22 15:30:23", finalWorldCupMatch.ToString("dd"));
            Assert.Equal("18/12/22 03:30 p. m.", finalWorldCupMatch.ToString("dd"));
            Assert.Equal("18 de diciembre de 2022", finalWorldCupMatch.ToString("dd"));


        }

        [Fact]
        public void Test5_DateTime_Days()
        {


            var finalWorldCupMatch = new DateTime(2022, 12, 18, 15, 30, 23);
            var today = new DateTime(2023, 5, 9, 15, 00, 00);

            TimeSpan diferencia = today - finalWorldCupMatch;

            var diastotales = (int)diferencia.TotalDays;

            var result = $"{diastotales} Dias totales desde la final del mundo";

            Assert.Equal("141 Días totales desde la final del mundo", result );

        }



        [Fact]
        public void Test6_POO_Alumno()
        {
            int id = 123456;
            string legajo = "000010/22", Nombre = "Lionel", Apellido = "Messi";
            

            var alumno = new Alumno(id, legajo, Nombre, Apellido );

            Assert.Equal(123456, alumno.AlumnoId);
            Assert.Equal("000010/22", alumno.Legajo);
            Assert.Equal("Lionel Messi", alumno.NombreCompleto);
        }



        [Fact]
        public void Test6_POO_Materia()
        {
            var materia = new Materia(123456, "Programacion III");

            Assert.Equal("Programacion III", materia.Nombre);
            Assert.Equal(123456, materia.MateriaId);

        }

        [Fact]
        public void Test8_POO_UML()
        {
            //En base al diagrama UML del examen
            //Codifique las clases e interfaces necesarias

            var docente = new Docente(1, "Lionel", "Scaloni");

            int id = 123456;
            string legajo = "000010/22", Nombre = "Lionel", Apellido = "Messi";

            int id2 = 123456;
            string legajo2 = "000010/23", Nombre2 = "Esteban", Apellido2 = "Quito";

            var alumno1 = new Alumno(id, legajo, Nombre, Apellido);


            var alumno2 = new Alumno(id2, legajo2, Nombre2, Apellido2);


            var materia = new Materia(1, "Programacion ")
            { 

             Profesor = docente
            
            };
            
            materia.Alumnos.Add(alumno1);
            materia.Alumnos.Add(alumno2);



            Assert.Equal("Programacion III", materia.Nombre);
            Assert.Equal(123456, materia.MateriaId);

            Assert.Equal(1, materia.Profesor.Id);
            Assert.Equal(1, materia.Profesor.DocenteId);
            Assert.Equal("Lionel", materia.Profesor.Nombre);
            Assert.Equal("Scaloni", materia.Profesor.Apellido);

            Assert.Equal(101010, materia.Alumnos.First().Id);
            Assert.Equal(101010, materia.Alumnos.First().Legajo);
            Assert.Equal(101010, materia.Alumnos.First().AlumnoId);
            Assert.Equal("Lionel", materia.Alumnos.First().Nombre);
            Assert.Equal("Messi", materia.Alumnos.First().Apellido);

            Assert.Equal(777, materia.Alumnos.Last().Id);
            Assert.Equal(777, materia.Alumnos.Last().AlumnoId);
            Assert.Equal("000007/22", materia.Alumnos.Last().Legajo);
            Assert.Equal("Rodrigo", materia.Alumnos.Last().Nombre);
            Assert.Equal("De Paul", materia.Alumnos.Last().Apellido);

        }


        [Fact]
        public void Test9_Collection_GetCountFirtLast()
        {
            //Utilice la coleccion del trabajo practico que presento
            //Para poder con el generador completar dicha coleccion
            //y buscar las primeras materias y primeros y ultimos alumnos
            var materias = new List<Materia>();

            
            
            materias.AddRange(MateriaGenerador.Generar(10000, 1000));

            Assert.Equal(10000, materias.Count);

            Assert.Equal(1000, materias.First().Alumnos.Count);
            Assert.Equal("M1-000001/23", materias.First().Alumnos.First().Legajo);
            Assert.Equal("M1-001000/23", materias.First().Alumnos.Last().Legajo);

            Assert.Equal(1000, materias.Last().Alumnos.Count);
            Assert.Equal("M10000-000001/23", materias.Last().Alumnos.First().Legajo);
            Assert.Equal("M10000-001000/23", materias.Last().Alumnos.Last().Legajo);

        }


        [Theory]
        [InlineData(100000)]
        public void Test10_Linq_BuscarLegajo(int cantidad)
        {
            //Busque los alumnos en las materias que contengan el legajo 000999
            //Utilice la coleccion del trabajo practico que presento
            var materias = new List<Materia>();
            Hashtable coleccion = new Hashtable();

            materias.AddRange(MateriaGenerador.Generar(10000, 1000));

            foreach (Materia Value in materias )
            {
                coleccion.Add(cantidad, Value);
            }

            var a = coleccion.Values;

            var legajos = from Alumno x in a
                          where x.Legajo.EndsWith("999")
                          select a;
                          
         

            Assert.Equal(1000, legajos.ToList().Count);

        }
    }
}