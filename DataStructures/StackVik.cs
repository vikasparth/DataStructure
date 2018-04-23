using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class StackVik
    {
        private int max;
        private int top;
        private int[] stackArray;
        private int bottom;
        private int incrementFactor;

        public int IncrementFactor {
            get => incrementFactor;
            set => incrementFactor = value;
        }

        public StackVik()
        {
            stackArray = new int[10];
            top = -1;
            incrementFactor = 2;
        }

        public StackVik(int maxParam, int bottomParam, int[] stackArrayParam)
        {
            stackArray = stackArrayParam;
            max = maxParam;
            bottom = bottomParam;
            top = bottomParam-1;
        }

        public StackVik(int[] arrayParam)
        {
            stackArray = arrayParam;
            top = -1;
            incrementFactor = 2;
        }
        public int Push(int num)
        {
            try {
                top++;
                if (top >= max)
                {
                    Console.WriteLine("Stack is full, no more elements can be added");
                    top--;
                    return -1;
                }
                stackArray[top] = num;                
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
                if (top < bottom)
                {
                    Console.WriteLine("The stack is empty, no more elements to be popped");
                    return -1;
                }
                else
                {
                    number = stackArray[top];
                    --top;
                    return number;                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return -1;
            }

        }

        public bool IsEmpty()
        {
            try
            {
                if (top < bottom)
                    return true;
                else
                    return false;
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
