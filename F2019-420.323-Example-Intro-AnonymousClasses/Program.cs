using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F2019_420._323_Example_Intro_AnonymousClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var anonSimple = new { Amount = 108, Message = "\"Hello\"" };

            Console.WriteLine(string.Format("Amount is {0} and message is {1}.", anonSimple.Amount, anonSimple.Message));

            var anonCollection = new[] { new { Name = "Brendan", Age = 46 }, new { Name = "Sarah", Age = 21 } };

            Console.WriteLine(string.Format("Name of record 2: {0} and age: {1}",anonCollection[1].Name, anonCollection[1].Age));
        }
    }
}
