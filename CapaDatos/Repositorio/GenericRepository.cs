using CapaEntidad;
using System.Data.Entity;
using System.Linq;

namespace CapaNegocio.Repositorio
{
    public interface IGenericRepository<T>
    {
        T Insert(T t);
        //T GetById(int id);//puede pasar que no siempre sea entero el id entonces pasamos uno generico
        IQueryable<T> GetAll();
        void Update(T t);
        bool Delete(int id);
    }
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DBEjemploEntities _context;
        protected DbSet<T> Entities => _context.Set<T>();
        protected GenericRepository(DBEjemploEntities context)
        {
            _context = context;
        }
        public bool Delete(int id)
        {
            T t = this.GetById(id);
            if (t == null)
            {
                return false;
            }
            else
            {
                _context.Set<T>().Remove(t);
                return true;
            }
        }

        public IQueryable<T> GetAll()=> _context.Set<T>();


        public T GetById(int id)
        {
            return _context.Set<T>().Find(Equals(id));
        }

        public T Insert(T t)
        {
             _context.Set<T>().Add(t);
            _context.SaveChanges();
            return t;
        }

        public void Update(T t)
        {
            _context.Entry(t).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
