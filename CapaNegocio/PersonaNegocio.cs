using CapaDatos.Repositorio;
using CapaEntidad;
using CapaNegocio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public interface IPersonaNegocio
    {
        Person Insert(String name, DateTime d, DateTime d2);
    }
    public class PersonaNegocio: IPersonaNegocio

    {
        private Person person = null;
        private readonly IGenericRepository<Person> _personaRepository;
        public PersonaNegocio(IGenericRepository<Person> personaRepository)
        {
            _personaRepository = personaRepository;
        }
      public Person Insert(String name, DateTime d, DateTime up)
        {
           
            person.Name = name;
            person.Created = d;
            person.Updated = up;
            // aca debos hacer las validaciones de lo que me trae desde el formulario 
            return _personaRepository.Insert(person);   
        }
    }
}
