using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSOLID
{
    internal class Almacenamiento
    {
        readonly string path = "D:/";
        public void EscribirFichero(string titulo, string contenido)
        {
            File.WriteAllText($"{path}/{titulo}.txt", contenido);
        }

        public string LeerFichero(string titulo)
        {
            return File.ReadAllText($"{path}/{titulo}.txt");
        }
    }
}
