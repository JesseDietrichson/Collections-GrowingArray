using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateGrowingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            GrowingArray array = new GrowingArray();

            array.Add(5);
            array.Add(60);
            array.Add(4);
            array.Add(56);
            array.Add(12);
            array.Add(45);
            array.Add(45);
            array.Add(45);

            array.Display();
        }
    }
}
