using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    public class Product 
    {
        public int Id { get; set; }
        public int CategoryId { get; set; } //for in key
        public string ProductName { get; set; } //ürün ismi
        public double UnitPrice { get; set; } //ürün fiyat
        public int UnitsInStock { get; set; } //stok adedi

        



    }
}
