using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Project.BLL.Patterns.GenericRepository.IntRep;
using Project.BLL.Patterns.SingletonPattern;
using Project.DAL.ContextClasses;
using Project.ENTITIES.Enums;
using Project.ENTITIES.Models;

namespace Project.BLL.Patterns.GenericRepository.EFBaseRep
{
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        public BaseRepository() 
        {
            _db = DBTool.DBInstance;
        }
        protected MyContext _db;
        public void Add(T item)
        {
            _db.Set<T>().Add(item);
            Save();
        }

        private void Save()
        {
            _db.SaveChanges();
        }

        public void AddRange(List<T> list)
        {
            _db.Set<T>().AddRange(list);
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            return _db.Set<T>().Any(exp);
        }

        public void Delete(T item)
        {
          item.DeletedDate = DateTime.Now;
            item.Status=ENTITIES.Enums.DataStatus.Deleted;
            Save();
        }

        public void DeleteRange(List<T> list)
        {
            foreach (T item in list) Delete(item);
           
        }

        public void Destroy(T item)
        {
         _db.Set<T>().Remove(item);
            Save();
        }

        public void DestroyRange(List<T> list)
        {
            _db.Set<T>().RemoveRange(list);
        }

        public T Find(int id)
        {
          return  _db.Set<T>().Find(id);
        }

        public T FirstOrDefault(Expression<Func<T, bool>> exp)
        {
            return _db.Set<T>().FirstOrDefault(exp);
        }

        public List<T> GetActives()
        {
            return Where(x => x.Status != ENTITIES.Enums.DataStatus.Deleted);
        }

        public List<T> GetAll()
        {
            return _db.Set<T>().ToList();
        }

        public List<T> GetCountedDatas(int number = 1)
        {
            return _db.Set<T>().Take(number).ToList();
        }

        public List<T> GetFirstDatas(int number = 1)
        {
            return _db.Set<T>().OrderBy(x => x.CreatedDate).Take(number).ToList();
        }

        public List<T> GetLastDatas(int number = 1)
        {
            return _db.Set<T>().OrderByDescending(x => x.CreatedDate).Take(number).ToList();
        }

        public List<T> GetModifieds()
        {
            return Where(x => x.Status == ENTITIES.Enums.DataStatus.Updated);
        }

        public List<T> GetPassives()
        {
            return Where(x => x.Status == ENTITIES.Enums.DataStatus.Deleted); ;
        }

        public object Select(Expression<Func<T, object>> exp)
        {
          return  _db.Set<T>().Select(exp);
        }

        public IQueryable<X> Select<X>(Expression<Func<T, X>> exp)
        {
            return _db.Set<T>().Select(exp);
        }

        public void Update(T item)
        {
           item.Status=DataStatus.Updated;
           item.UpdatedDate=DateTime.Now;
           T originalData= Find(item.ID);
            _db.Entry(originalData).CurrentValues.SetValues(item);
            Save();
        }

        public void UpdateRange(List<T> list)
        {
            foreach (T item in list) Update(item);
           
        }

        public List<T> Where(Expression<Func<T, bool>> exp)
        {
            return _db.Set<T>().Where(exp).ToList();
        }
    }
}
