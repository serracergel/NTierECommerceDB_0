using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    //c#'in yapisinda attribute var ayirt edebilmek icin SpecAttribute yaptim
    public class SpecAttribute : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        //Relational Properties
        public virtual List<ProductAttribute> ProductAttributes { get; set; }
    }
}
