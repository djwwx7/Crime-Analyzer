using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace CrimeAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Crimes crimes = new Crimes(args);
        }
    }
}