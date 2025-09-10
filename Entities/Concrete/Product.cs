using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
	//IEntity nin yanında bulunan "Product" bir veritabanı tablosudur. Anlamamız gerekiyor, IEntity referans olarak "Product" tutuyor.
	public class Product: IEntity
	{
		public int ProductID { get; set; }
		public int CategoryId { get; set; }
		public string ProductName { get; set; }       
        public short UnitsInStock { get; set; }
        public decimal UnitPrice  { get; set; }
    }
}
