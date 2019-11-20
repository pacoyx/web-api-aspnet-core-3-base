using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Models
{
   public class Entidad
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Codigo es requerido")]
        public string EntidadId { get; set; }
        public string Descripcion { get; set; }
        public int Estado { get; set; }
        public int Prioridad { get; set; }
    }
}
