using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    //Sealed classes cannot be inherited from//
    public sealed class MathHelper
    {
        //The default access modifier of C# is private
        private MathHelper() { }
        private static readonly MathHelper mathinstance = new MathHelper() { };
        public static MathHelper GetInstance
        {
            get
            {
                return mathinstance;
            }
        }
        public int Add(int num1,int num2)
        {
            return num1 + num2;
        }
        public bool IsNegative(int testnum)
        {
            return testnum < 0;
        }
    }
}
