using System;

namespace _07._02._2023
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Sayi daxil edin:");
            int count = Convert.ToInt32(Console.ReadLine());
            Notebook[] notebooks = new Notebook[count];



            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Brand: ");
                string brand = Console.ReadLine();
                Console.WriteLine("Model: ");
                string model = Console.ReadLine();
                Console.WriteLine("Price: ");
                double price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ram: ");
                int ram = Convert.ToInt32(Console.ReadLine());

                Notebook nt = new Notebook(brand, model) { Price = price, Ram = ram };
                notebooks[i] = nt;

                
            }

            double sum = 0;
            for (int i = 0; i < notebooks.Length; i++)
            {
                sum += notebooks[i].Price;
            }

            var result = sum / notebooks.Length;



            Console.WriteLine(result);
        }
    }
}
