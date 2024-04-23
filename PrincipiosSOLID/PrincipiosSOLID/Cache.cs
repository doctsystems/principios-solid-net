using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSOLID
{
    internal class Cache
    {
        private readonly Dictionary<string, string> CacheDicctionary;
        public Cache()
        {
            CacheDicctionary = new Dictionary<string, string>();
        }

        public void Add(string titulo, string contenido)
        {
            if (!CacheDicctionary.ContainsKey(titulo))
            {
                CacheDicctionary[titulo] = contenido;
            }
        }

        public string Get(string titulo)
        {
            CacheDicctionary.TryGetValue(titulo, out string contenido);
            return contenido;
        }
    }
}
