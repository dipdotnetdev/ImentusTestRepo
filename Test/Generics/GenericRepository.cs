using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Generics
{
    public interface IGenericRepository<T> where T : class
    {
        void Add(T entity);
        T GetById(int id); 
        IEnumerable<T> GetAll();
        void Update(T entity);
        void Delete(int id);
    }
    public class GenericRepository<T> : IGenericRepository<T> where T: class
    {
        private readonly List<T> _data = new List<T>();

        public void Add(T entity) => _data.Add(entity);

        public T GetById(int Id)
        {
            var prop = typeof(T).GetProperty("Id");
            return _data.FirstOrDefault(e => (int)prop.GetValue(e) == Id);
        }

        public IEnumerable<T> GetAll() {
            return _data;
        }

        public void Update(T entity)
        {
            var prop =typeof(T).GetProperty("Id");
            var id = (int)prop.GetValue(entity);
            var existing = GetById(id);
            if (existing != null)
            {
                var index = _data.IndexOf(existing);
                _data[index] = entity;
            }
        }

        public void Delete(int id)
        {
            var entity = GetById(id);
            _data.Remove(entity);
        }
    }

}
