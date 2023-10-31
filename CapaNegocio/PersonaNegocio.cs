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
   
    public class PersonaNegocio 

    {
        private readonly PersonaRepository _personaRepository;
        public PersonaNegocio()
        {
            _personaRepository = new PersonaRepository(new DBEjemploEntities());
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetAll()
        {
            return (List<Person>)_personaRepository.GetAll();
        }

        public Person Insert(Person person)
        {
           if (person.Name.Length < 8)
            {
                return _personaRepository.Insert(person);
            }
            else
            {
                return null;
            }   
        }

     

        public void Update(Person t)
        {
            throw new NotImplementedException();
        }
    }
}
