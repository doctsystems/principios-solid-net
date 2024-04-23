using Serilog.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSOLID
{
    internal class ArticuloService
    {
        private readonly Almacenamiento almacenamiento;
        private readonly Cache cache;
        private readonly Logging logger;

        public ArticuloService()
        {
            almacenamiento = new Almacenamiento();
            cache = new Cache();
            logger = new Logging();
        }

        public void GuardarArticulo(string contenido, string titulo)
        {
            try
            {
                logger.Info($"vamos a insertar el articulo {titulo}");
                almacenamiento.EscribirFichero(contenido, titulo);
                logger.Info($"articulo {titulo} insertado");
                cache.Add(contenido, titulo);
            }
            catch (Exception e)
            {
                logger.Error("error...", e);
            }
        }

        public string ConsultarArticulo(string titulo)
        {
            logger.Info($"consultar articulo {titulo}");
            string contenido = cache.Get(titulo);
            if (!string.IsNullOrWhiteSpace(contenido))
            {
                logger.Info($"Articulo \"{titulo}\" encontrado en la cache");
                return contenido;
            }

            logger.Info($"Buscar articulo \"{titulo}\" en el sistema de archivos");
            return almacenamiento.LeerFichero(titulo);
        }
    }
}
