using Project.BLL.Patterns.GenericRepository.EFBaseRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Patterns.GenericRepository.EFConcRep
{
    public class ProductRepository : BaseRepository<Product>
    {

        public List<Product> GetProductsByCategory(int id)
        {
            return _db.Products.Where(x => x.CategoryID == id).ToList();
        }
    }
}
