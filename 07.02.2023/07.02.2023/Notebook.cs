using System;
using System.Collections.Generic;
using System.Text;

namespace _07._02._2023
{
    class Notebook
    {

        public Notebook(string brand,string model)
        {
            Brand = brand;
            Model = model;

        }

        public string Brand;
        public string Model;
        public double Price;
        public int Ram;

        public void ShowInfo()
        {
            Console.WriteLine($"Brand: {Brand} - Model: {Model} - Price: {Price} - Ram {Ram}");
        }

    }
}
