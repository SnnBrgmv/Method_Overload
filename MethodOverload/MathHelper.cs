using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload
{
    internal class MathHelper
    {
        public int PrintValue(int num1, int num2) 
        {
            return num1 + num2;
        }

        public int PrintValue(bool value) 
        {
            if (value) return 1;
            return 0;
        }

        public void PrintValue(string word1, string word2) 
        {
            Console.WriteLine($"{word1} {word2}");
        }

        public int PrintValue(int num1,int num2,int num3) 
        {
            return num1 * num2 * num3;
        }
    }
}
