using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp
{
    internal class Product
    {
        private int _id;
        private string _name;
        private int _price;
        private double _discountPercentage;

        public Product(int id, string name, int price, double discountPercentage)
        {
            _id = id;
            _name = name;
            _price = price;
            _discountPercentage = discountPercentage;
        }

        public void GetAllDetails(out string productName , out int productPrice , out double discountPercentage , out double priceAfteDiscount)
        {
            productName = _name;
            productPrice = _price;
            discountPercentage = _discountPercentage;
            priceAfteDiscount = productPrice - (productPrice * discountPercentage / 100);
        }
    }
}
