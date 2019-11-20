using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IEntidadRepository : IRepositoryBase<Entidad>
    {
        IEnumerable<Entidad> GetAllEntidades();
        Entidad GetEntidadById(Guid entidadId);
        Entidad GetEntidadWithDetails(Guid entidadId);
        void CreateEntidad(Entidad owner);
        void UpdateEntidad(Entidad owner);
        void DeleteEntidad(Entidad owner);
    }
}
