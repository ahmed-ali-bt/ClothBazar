using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazar.Entities
{
   public class Product : BaseEntity
    {
      
        public Category Category { get; set; }//reference this product belong to caterory by make an obj
        public decimal Price { get; set; }
    }
}
