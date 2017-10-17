using System;
using UsersLibrary;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan lengthOfService = new DateTime(2017, 1, 20).Subtract(new DateTime(2009, 1, 20));
            Employee Barack_Obama = new Employee("Obama II", "Barack", new DateTime(1961, 8, 4),
                lengthOfService,"Президент Соединённых Штатов Америки");
            Console.WriteLine(Barack_Obama);

            Console.ReadKey();
        }
    }
}
