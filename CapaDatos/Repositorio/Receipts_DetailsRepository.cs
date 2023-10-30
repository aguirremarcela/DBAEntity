using CapaEntidad;
using CapaNegocio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Repositorio
{
    public interface IReceiptsDetailsRepository : IGenericRepository<Receipt_Details>
    {

    }
    public class Receipts_DetailsRepository: GenericRepository<Receipt_Details>, IReceiptsDetailsRepository
    {
        public Receipts_DetailsRepository(DBEjemploEntities context) : base(context)
        {
        }
    }
}
