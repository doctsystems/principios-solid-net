using System;
using System.Xml.Linq;

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

        public int Alcohol { get; set; }

        public Beer(string name, string brand, int alcohol)
        {
            Name = name;
            Brand = brand;
            Alcohol = alcohol;
        }
    }

    public class BeerDB
    {
        private Beer _beer;
        public BeerDB (Beer beer) {
            _beer = beer;
        }
        public void Save()
        {
            Console.WriteLine($"Cerveza {_beer.Name} - {_beer.Brand} con {_beer.Alcohol} grados, guardada");
        }
    }

    public class BeerRequest
    {
        private Beer _beer;
        public BeerRequest(Beer beer)
        {
            _beer = beer;
        }
        public void Send()
        {
            Console.WriteLine($"Enviando cerveza {_beer.Name} - {_beer.Brand} con {_beer.Alcohol} grados");
        }
    }
}
