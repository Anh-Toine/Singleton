using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            MathHelper math = MathHelper.GetInstance;
            int sum = math.Add(math.Add(4, -5), math.Add(4, -5));
            bool isneg = math.IsNegative(sum);
            Console.WriteLine(isneg);
        }
    }
}
