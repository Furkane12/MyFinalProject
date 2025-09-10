using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
	//IEntity nin yanında bulunan "Category" bir veritabanı tablosudur. Anlamamız gerekiyor, IEntity referans olarak "Category" tutuyor.
	public class Category: IEntity
	{
		public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
