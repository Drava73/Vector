using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector vek1 = new Vector();
            vek1.Input();
            _ = vek1.XYZlength;
            vek1.Skoliatminus();
            Console.Write(vek1);
            Console.ReadLine();
        }
    }
}
