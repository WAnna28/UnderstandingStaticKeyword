using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingStaticKeyword.Models
{
    // Static classes can only
    // contain static members!
    static class InfoCenter
    {
        public static void Info1()
        {
            Console.WriteLine();
            Console.WriteLine(@"When a class has been defined as
static, it is not creatable using the new keyword, and it can contain only members or data fields marked with
the static keyword. If this is not the case, you receive compiler errors.");
        }

        public static void Info2()
        {
            Console.WriteLine();
            Console.WriteLine(@"If you create a class that contains nothing but static members and/or
constant data, the class has no need to be allocated in the first place!");
        }
    }
}
