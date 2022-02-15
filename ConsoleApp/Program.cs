using System;
using ClassLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker1 = new Worker("Ivan", "Ivanenko", "Ivanov", "24-01-2022", new Job("microsoft", new Address("Ukraine", "Zhytomyr", "lekh kachinsky street",
                2, 10034), 10500, "10:00 - 18:00"), "no experience", "higher educationn");
            Worker worker2 = new Worker("Andrii", "Tatum", "Ivanov", "27-02-2022", new Job("microsoft", new Address("Ukraine", "Kyiv", "Khreshchatyk street",
                10, 103424), 10500, "10:00 - 18:00"), "3 years experience", "secondary educationn");
            Console.WriteLine($"Worker 1 : {worker1.GetWorker()}\n");
            Console.WriteLine($"Worker 2 : {worker2.GetWorker()}");


        }
    }
}
