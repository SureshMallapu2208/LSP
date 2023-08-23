using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    internal class NormalFileUser : IFileRead
    {
        public  void ReadFile() { Console.WriteLine(" Normal Read File"); }
    }
}
