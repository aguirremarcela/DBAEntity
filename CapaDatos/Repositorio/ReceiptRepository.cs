using CapaEntidad;
using CapaNegocio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Repositorio
{
    public interface IReciptsRepository : IGenericRepository<Receipt>
    {

    }
   public class ReceiptRepository : GenericRepository<Receipt>, IReciptsRepository
    {
        public ReceiptRepository(DBEjemploEntities context) : base(context)
        {
        }
    }
}
