using System;
using AppDilleto.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppDilleto.Models
{
    [Table("t_contactanos")]
    public class ContactanosModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("nombre")]
        public string Nombre { get; set; }
         [Column("email")]
        public string Email { get; set; }
        [Column("mensaje")]
        public string Mensaje { get; set; }

        
    }
}
