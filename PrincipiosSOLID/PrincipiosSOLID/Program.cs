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
        private readonly string path = "C:/temp";

        private readonly Dictionary<string, string> Cache;

        static void Main(string[] args)
        {

        }

        public void GuardarArticulo(string contenido, string titulo)
        {
            Log.Information($"vamos a insertar el articulo {titulo}");
            File.WriteAllText($"{path}/{titulo}.txt", contenido);
            Log.Information($"articulo {titulo} insertado");
            this.Cache.Add(titulo, contenido);
        }

        public string ConsultarArticulo(string titulo)
        {
            Log.Information($"consultar articulo {titulo}");
            string contenido = this.Cache[titulo];
            if (!string.IsNullOrWhiteSpace(contenido))
            {
                Log.Information($"Articulo \"{titulo}\" encontrado en la cache");
                return contenido;
            }

            Log.Information($"buscar articulo \"{titulo}\" en el sistema de archivos");
            contenido = File.ReadAllText($"{path}/{titulo}.txt");
            return contenido;
        }
    }
}
