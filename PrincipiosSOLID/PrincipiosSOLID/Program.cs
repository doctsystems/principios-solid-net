using System;

namespace PrincipiosSOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Beer
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        
        public Beer(string name, string brand)
        {
            Name = name;
            Brand = brand;
        }

        public void Save()
        {
            Console.WriteLine($"Cerveza {Name} - {Brand}, guardada");
        }

        public void Send()
        {
            Console.WriteLine($"Enviando cerveza {Name} - {Brand}");
        }

    }
}
