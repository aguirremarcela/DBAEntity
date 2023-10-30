using CapaEntidad;
using CapaNegocio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Repositorio
{
    public interface IProductRepository : IGenericRepository<Product> { }
    public class ProductRepository :GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(DBEjemploEntities context) : base(context)
        {
        }
    }
}
