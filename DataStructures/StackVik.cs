using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class StackVik
    {
        private int currentPosition;
        private int[] stackArray;
        private int incrementFactor;

        public int IncrementFactor {
            get => incrementFactor;
            set => incrementFactor = value;
        }

        public StackVik()
        {
            stackArray = new int[10];
            currentPosition = -1;
            incrementFactor = 2;
        }

        public StackVik(int[] arrayParam)
        {
            stackArray = arrayParam;
            currentPosition = -1;
            incrementFactor = 2;
        }
        public int Push(int num)
        {
            try {
                currentPosition++;
                if (currentPosition >= stackArray.Length)
                {
                    IncreaseSizeByFactor(incrementFactor);
                }
                stackArray[currentPosition] = num;                
                return 0;
            }
            catch (Exception ex) {
                Console.WriteLine(ex.StackTrace);
                return -1;
            }
        }

        public int Pop()
        {
            try
            {
                int number;
                if (currentPosition < 0)
                {
                    Console.WriteLine("The stack is empty, no more elements to be popped");
                    return -1;
                }
                else
                {
                    number = stackArray[currentPosition];
                    --currentPosition;
                    return number;                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return -99;
            }

        }

        public bool IsEmpty()
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return true;
            }
        }

        public int AtPosition(int num)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return -99;
            }
        }

        public bool DoesExist()
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return false;
            }
        }

        public bool IncreaseSizeByFactor(int factor)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return false;
            }
        }

    }
}
