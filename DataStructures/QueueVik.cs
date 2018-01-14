using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
   public class QueueVik
    {
        private int[] array;
        private int startingPos;        
        private int nextPos;
        private int size;
        public QueueVik(int sizeParam)
        {
            size = sizeParam;
            if (size <= 0)
            {
                size = 10;
            }
            else
            {
                array = new int[size];
            }
            startingPos = 0;
            nextPos = 0;
        }

        private int increment(int position)
        {            
                return ((position + 1) % size);           
                       
        }
        /*Below method inserts elements into the Queue at next available position*/
        public int PushElement(int numParam)
        {            
            int tempNextPos = this.increment(nextPos);
            this.array[nextPos] = numParam;
            if (tempNextPos == startingPos)
            {
                this.IncreaseSizeByFactor(2);
                this.nextPos = (array.Length / 2);
            }
            else
            {
                this.nextPos = tempNextPos;
            }
            
            return 0;
        }

        /*Below method returns the element first in logical order from the Queue*/
        public int GetElement() {
            int num;
            
            if (this.IsEmpty())
            {
                Console.WriteLine("Queue is Empty, no element can be retrived");
                return -1;
            }
            else {
               num = this.array[startingPos];
                this.array[startingPos] = -1;
               this.startingPos = this.increment(startingPos);
                return num;
            }            
        }

        /*Below method should return the sequence in queue where a number will be returned*/
        public int IndexOf(int num)
        {
            if (this.IsEmpty())
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }

            int positionIndex = -99;
            if (startingPos < nextPos)
            {
                for (int i = startingPos; i < nextPos; i++)
                {
                    if (num == array[i])
                    {
                        positionIndex =((i - startingPos) + 1);
                    }
                }
            }
            else {                
                for (int i = startingPos; i < array.Length; i++)
                {
                    if (num == array[i])
                    {
                        positionIndex =((i - startingPos) + 1);
                    }
                }
                for (int i = 0; i < nextPos; i++)
                {
                    if (num == array[i])
                    {
                        positionIndex += (((array.Length - startingPos) + (i+1)));
                    }

                }

            }
          return positionIndex;
        }
        
        public bool DoesContain(int num)
        {
            if (this.IsEmpty())
            {
                Console.WriteLine("Queue is Empty");
                return false;
            }
            if (startingPos < nextPos)
            {
                for (int i = startingPos; i < nextPos; i++)
                {
                    if (num == array[i])
                    {
                        return true;
                    }
                }
            }
            else
            {
                for (int i = startingPos; i < array.Length; i++)
                {
                    if (num == array[i])
                    {
                        return true;
                    }
                }
                for (int i = 0; i < nextPos; i++)
                {
                    if (num == array[i])
                    {
                        return true;
                    }

                }

            }          
            return false;
        }
        /*Below method increases the size of an array by given factor. It is used when an Array has exhausted it's size*/
        private int IncreaseSizeByFactor(int factor)
        {
            try
            {
                int success = 0;
                int newSize = 0;
                int j = 0;
                newSize = (this.array.Length * factor);
                int[] temp = new int[newSize];
                if (nextPos > startingPos)
                {                    
                    for (int i = this.startingPos; i <= this.nextPos; i++)
                    {
                        temp[j] = this.array[i];
                        j++;
                    }                    
                }
                else
                {
                    for (int i = startingPos; i < this.array.Length; i++)
                    {
                        temp[j] = this.array[i];
                        j++;
                    }
                    for (int i = 0; i < this.startingPos; i++)
                    {
                        temp[j] = this.array[i];
                        j++;
                    }
                }
                array = temp;
                startingPos = 0;
                nextPos = j;
                size = newSize;
                return success;
            }
            catch (OutOfMemoryException ex) {
                Console.WriteLine("Failed to allocate memory  {0} \r\n {1}", ex.Message, ex.StackTrace);
                return -1;
            }
        }

        public bool IsEmpty() {
            if (startingPos == nextPos)
            {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
