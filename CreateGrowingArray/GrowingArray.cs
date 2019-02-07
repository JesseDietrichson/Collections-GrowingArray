using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateGrowingArray
{
    class GrowingArray
    {
        private int[] intArray;
        private int currentPosition = 0;

        public GrowingArray()
        {
            intArray = new int[2];
        }

        public void Add(int intToAdd)
        {
            intArray[currentPosition] = intToAdd;
            currentPosition++;

            if (currentPosition >= intArray.Length)
            {
                //grow array
                int[] tempArray = new int[intArray.Length * 2];
                //copy the data to the new array
                for (int i = 0; i < intArray.Length; i++)
                {
                    tempArray[i] = intArray[i];
                }

                intArray = tempArray;
            }
        }
        public void Display()
        {
            foreach (int x in intArray)
            {
                if (x != 0)
                {
                    Console.WriteLine(x);
                }
            }
        }
    }
}
