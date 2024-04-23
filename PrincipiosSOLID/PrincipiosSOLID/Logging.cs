using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSOLID
{
    internal class Logging
    {
        public void Info(string message) { Log.Information(message); }
        public void Error(string message, Exception e) { Log.Error(e, message); }
        public void Warning(string message, Exception e) { Log.Warning(e, message); }
    }
}
