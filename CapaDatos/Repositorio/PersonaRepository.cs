using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaNegocio.Repositorio;

namespace CapaDatos.Repositorio
{
    public interface IPersonsRepository : IGenericRepository<Person>
    {

    }
    public class PersonaRepository : GenericRepository<Person>, IPersonsRepository
    {
        public PersonaRepository(DBEjemploEntities context) : base(context)
        {
        }
    }
}
