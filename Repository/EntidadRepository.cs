using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class EntidadRepository : RepositoryBase<Entidad>, IEntidadRepository
    {
        public EntidadRepository(RepositoryContext repositoryContext) 
            : base(repositoryContext)
        {
        }

        public void CreateEntidad(Entidad entidad)
        {
            Create(entidad);
        }

        public void DeleteEntidad(Entidad entidad)
        {
            Delete(entidad);
        }

        public IEnumerable<Entidad> GetAllEntidades()
        {
            return FindAll()
                 .OrderBy(ow => ow.Descripcion)
                 .ToList();
        }

        public Entidad GetEntidadById(Guid entidadId)
        {
            return FindByCondition(owner => owner.Id.Equals(entidadId))
          .FirstOrDefault();
        }

        public Entidad GetEntidadWithDetails(Guid entidadId)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntidad(Entidad entidad)
        {
            Update(entidad);
        }

      
    }
}
