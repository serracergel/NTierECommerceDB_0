using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DAL.ContextClasses;

namespace Project.BLL.Patterns.SingletonPattern
{
    public class DBTool
    {
        //private ctor=>instance alinmamasi icin
        DBTool() { }

        static MyContext _dbInstance;
        public static MyContext DBInstance 
        {
            get
            {
              return  _dbInstance == null ? _dbInstance = new MyContext() : _dbInstance;
               
               
            } 
        }
    }
}
