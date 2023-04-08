using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace _2isa
{
    internal class Class1
    {
        internal static double Sredne( int[] array) => array.Sum() / array.Length; //МЕТОД ПОИСКА СДРЕДНЕГО ЗНАЧЕНИЯ


        internal  static int  Max (int[] array )
        {
           int max = array[0];

            for ( int i = 0; i< array.Length; i++)
            {
                max = array[i] > max ? array[i] : max;
            }
            return max;
        }

        internal static int PEREVOR(int[] array)
        {
            int[] mass=new int[array.Length];
            int a = array.Length;
            for (int i=0;array.Length>i;i++)
            {
                mass[a] = array[i];
                Console.WriteLine(mass[i]);
                a--;
            }
            return mass[a];
        }
    }
}
