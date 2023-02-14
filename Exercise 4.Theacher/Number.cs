using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4.Theacher
{
    public class BankDb
    {
        public static readonly BankDb Instance = new BankDb();
        private BankDb() { } // private constructor

        public double SomeNumber { get; set; }
        public string SomeString { get; set; }
    }
}
