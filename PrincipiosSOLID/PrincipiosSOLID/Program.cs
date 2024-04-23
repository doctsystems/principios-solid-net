using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Xml.Linq;

namespace PrincipiosSOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Almacenamiento almacenamiento = new Almacenamiento();
            almacenamiento.EscribirFichero("Test", "test principios SOLID");
            Console.WriteLine(almacenamiento.LeerFichero("Test"));
            Console.ReadLine();
        }
    }
}
