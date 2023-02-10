using System;

namespace _10._02._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            //Medicine pd1 = new Medicine();
            //pd1.category = "Bas agri dermani";
            //pd1.Name = "Novarest";


            Pharmacy pharmacy = new Pharmacy();



            string opt;
            do
            {

                Console.WriteLine("1. Derman yarat");
                Console.WriteLine("2. Dermanlara bax");
                Console.WriteLine("3. Endirimli dermanlari goster");
                Console.WriteLine("4. Verilmish endirim araliginda olan dermanlari goster");
                Console.WriteLine("5.  Verilimis kateqoriya ucun dermanlari goster");
                Console.WriteLine("6. Verilmis kateqoriyada stokda nece dene derman qalib");
                Console.WriteLine("0. Proses bitdi");


                Console.WriteLine("Secim edin");
                opt = Console.ReadLine();

                switch (opt)
                {

                    case "1":
                        Console.WriteLine("Dermani Adi");
                        string name = (Console.ReadLine());

                        Console.WriteLine("Category");
                        string category = Console.ReadLine();

                        Console.WriteLine("Price");
                        string priceStr = Console.ReadLine();
                        double price = Convert.ToDouble(priceStr);

                        Console.WriteLine("Discount price");
                        string discountStr = Console.ReadLine();
                        double discount = Convert.ToDouble(discountStr);

                        Medicine medicine = new Medicine
                        {
                            Name = name,
                            Category = category,
                            Price = price,
                            DiscountPrice = discount


                        };
                        pharmacy.AddMedicine(medicine);


                        break;

                    case "2":

                        Console.WriteLine("Dermanlar");

                        for (int i = 0; i < pharmacy.Products.Length; i++)
                        {
                            Console.WriteLine($"\nName: {pharmacy.Products[i].Name}");
                            Console.WriteLine($"Price: {pharmacy.Products[i].Price}");
                            Console.WriteLine($"Discount: {pharmacy.Products[i].DiscountPrice}");
                            Console.WriteLine($"Category: {pharmacy.Products[i].Category}");

                        }

                        break;
                    case "3":

                        Console.WriteLine("Endirimli Dermanlar");
                        for (int i = 0; i < pharmacy.Products.Length; i++)
                        {
                            if (pharmacy.Products[i].DiscountPrice > 0)
                            {

                                Console.WriteLine($"\nName: {pharmacy.Products[i].Name}");
                                Console.WriteLine($"Price: {pharmacy.Products[i].Price}");
                                Console.WriteLine($"Discount: {pharmacy.Products[i].DiscountPrice}");
                                Console.WriteLine($"Category: {pharmacy.Products[i].Category}");
                            }

                        }


                        break;
                    case "4":

                        Console.WriteLine("min max araligindaki dermanlar");

                        int min = Convert.ToInt32(Console.ReadLine());
                        int max = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < pharmacy.Products.Length; i++)
                        {
                            if (pharmacy.Products[i].DiscountPrice >= min && pharmacy.Products[i].DiscountPrice <= max)
                            {
                                Console.WriteLine($"\nName: {pharmacy.Products[i].Name}");
                                Console.WriteLine($"Price: {pharmacy.Products[i].Price}");
                                Console.WriteLine($"Discount: {pharmacy.Products[i].DiscountPrice}");
                                Console.WriteLine($"Category: {pharmacy.Products[i].Category}");
                            }
                        }


                        break;
                    case "5":
                        Console.WriteLine("Kateqoriyani daxil edin");

                        string catq = Console.ReadLine();

                        for (int i = 0; i < pharmacy.Products.Length; i++)
                        {
                            if (pharmacy.Products[i].Category == catq)
                            {

                                Console.WriteLine($"\nName: {pharmacy.Products[i].Name}");
                                Console.WriteLine($"Price: {pharmacy.Products[i].Price}");
                                Console.WriteLine($"Discount: {pharmacy.Products[i].DiscountPrice}");
                                Console.WriteLine($"Category: {pharmacy.Products[i].Category}");
                            }
                        }



                        break;
                    case "6":
                         catq = Console.ReadLine();
                        int count = 0;

                        for (int i = 0; i < pharmacy.Products.Length; i++)
                        {
                            if (pharmacy.Products[i].Category == catq)
                            {
                                
                                count++;
                            }
                        }
                        Console.WriteLine($"Bu kateqoriyada {count} derman qalib");
                        break;
                    case "0":

                        break;

                    default:
                        Console.WriteLine("secim duzgun deil");
                        break;
                }

            } while (opt != "0");





        }
    }
}
