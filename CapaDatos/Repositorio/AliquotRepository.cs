using CapaEntidad;
using CapaNegocio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Repositorio
{
    public interface IAliquotRepository : IGenericRepository<Aliquot>
    {

    }
    public class AliquotRepository:GenericRepository<Aliquot>, IAliquotRepository
    {
        public AliquotRepository(DBEjemploEntities context) : base(context)
        {
        }
    }
}
