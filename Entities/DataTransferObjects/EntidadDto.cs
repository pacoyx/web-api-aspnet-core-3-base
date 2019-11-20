using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class EntidadDto
    {
        public Guid Id { get; set; }
        
        public string EntidadId { get; set; }
        public string Descripcion { get; set; }
        public int Estado { get; set; }
        public int Prioridad { get; set; }
    }
}
