using System;
using System.Collections.Generic;
using System.Text;

namespace _10._02._2023
{
    class Pharmacy
    {
        public Medicine[] Products = new Medicine[0];



        public void AddMedicine(Medicine product)
        {
            Array.Resize(ref Products, Products.Length + 1);
            Products[Products.Length - 1] = product;
        }

    }
}
