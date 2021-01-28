using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{   
    // Product = Ürün
    class Product
    {
        public int Id { get; set; }
        //Hangi Kategoriye ait olduğunu belirtmek için
        public int CategoryId { get; set; }

        // Ürün adı
        public string ProductName { get; set; }

        //Ürün Fiyatı
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }


    }
}
