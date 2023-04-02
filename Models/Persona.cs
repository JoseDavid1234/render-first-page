using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace prueba_postgres_2.Models
{

    [Table("persona")] // nombre de la tabla en minúsculas
    public class Persona
    {
        [Column("id")] // nombre de la columna en minúsculas
        public int Id { get; set; }

        [Column("nombre")] // nombre de la columna en minúsculas
        public string Nombre { get; set; }

        [Column("apellido")] // nombre de la columna en minúsculas
        public string Apellido { get; set; }

        [Column("email")] // nombre de la columna en minúsculas
        public string Email { get; set; }
    }
}