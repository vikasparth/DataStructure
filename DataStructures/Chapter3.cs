using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Chapter3
    {
        

        public void ThreeStackInAnArray()
        {
            int[] stackArray = new int[30];
            StackVik stv1 = new StackVik(9, 0, stackArray);
            StackVik stv2 = new StackVik(19, 10, stackArray);
            StackVik stv3 = new StackVik(29, 20, stackArray);

            stv1.Push(10);
            stv1.Push(11);
            stv1.Push(12);
            stv1.Push(13);
            stv1.Push(14);
            stv1.Push(15);
            stv1.Push(16);
            stv1.Push(17);
            stv1.Push(18);
            stv1.Push(19);
            stv1.Push(51);
            stv1.Push(52);
            stv2.Push(20);
            stv2.Push(21);
            stv2.Push(22);
            stv3.Push(30);
            stv3.Push(31);
            stv3.Push(32);

            Console.WriteLine(stv1.Pop());
            Console.WriteLine(stv2.Pop());
            Console.WriteLine(stv3.Pop());
            Console.WriteLine(stv1.Pop());
            Console.WriteLine(stv2.Pop());
            Console.WriteLine(stv3.Pop());
            Console.WriteLine(stv1.Pop());
            Console.WriteLine(stv2.Pop());
            Console.WriteLine(stv3.Pop());
        }


    }
}
