using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Project.ENTITIES.Models;

namespace Project.BLL.Patterns.GenericRepository.IntRep
{
    public interface IRepository<T> where T : BaseEntity
    {
        //List Commands
        List<T> GetAll();
        List<T> GetActives();
        List<T> GetPassives();
        List<T> GetModifieds();

        //Modify Commands
        void Add(T item);
        void AddRange(List<T> list);
        void Update(T item);
        void UpdateRange(List<T> list);
        void Delete(T item);
        void DeleteRange(List<T> list);
        void Destroy(T item);
        void DestroyRange(List<T> list);

        //3 asamali sorgu 1=> x kendinden once ne denildiyse onu tut
        //2=>onu sorgula
        //Sorgudan(bool ifadeden) sonuc dondur(tipi)
        //Linq Expressions
        List<T> Where(Expression<Func<T,bool>> exp);
        bool Any(Expression<Func<T,bool>> exp);

        T FirstOrDefault(Expression<Func<T, bool>>exp);
        object Select(Expression<Func<T, object>>exp);
        //Anonimi barindirablen=>Dynamic,object
        IQueryable<X> Select<X>(Expression <Func<T, X>> exp);
        T Find(int id);
        List<T> GetFirstDatas(int number=1);
        List<T> GetLastDatas(int number=1);
        List<T> GetCountedDatas(int number = 1);
    }
}  
