using System;
using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class Persona
    {
        [Key]
        public int Identificacion { get; set; }
        public string Nombre { get; set; }
         public string Apellidos { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
         public string Departamento { get; set; }
        public string Ciudad { get; set; }
        public string Apoyo { get; set; }
        public string Modalidad { get; set; }
        public void CalcularApoyo() 
        {
            if (Modalidad.Equals("Mercado") || Modalidad.Equals("mercado"))
            {
                Apoyo="mercado";
            }
            else
            {
                Apoyo="dinero";
            }
        }
    }
    }

