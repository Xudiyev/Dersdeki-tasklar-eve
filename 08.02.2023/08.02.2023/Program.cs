using System;

namespace _08._02._2023
{
    class Program
    {
        static void Main(string[] args)
        {

            Human hmn1 = new Human();
            hmn1.Name = "Hikmet";


            hmn1.Age = 12;
            hmn1.Age = 23;
            hmn1.Age = -10;

            Console.WriteLine(hmn1.Age);


            Student std1 = new Student();
            std1.Name = "Abbas";
            std1.GroupNo = "P138";
            std1.Age = 30;
            


            Console.WriteLine(std1.Age);
            

        }
    }
}
