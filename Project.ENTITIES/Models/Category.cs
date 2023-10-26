using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{ //1 prod     1 category
    //1 category n prod
    public class Category : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int? ParentCategoryID { get; set; }
        //Relational Properties 
        public virtual List<Product> Products { get; set; }
        public virtual List<Category> ChildCategories { get; set; }
        public  virtual Category ParentCategory { get; set; }

        public override string ToString()
        {
            return $"{Title}";

        }
    }
}
