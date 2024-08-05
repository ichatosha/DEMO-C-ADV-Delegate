using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_C__ADV_Delegate
{
    // more generic 
    public delegate TResult CompareFuncDelegate< in T ,out TResult>(T A, T B );
    

    internal class SortingAlgorithms<T>
    {

        public static void BubleSort(T[] array , CompareFuncDelegate<T , bool> compareFunc)
        {
            if (array is not null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for(int j = 0; j < array.Length - i - 1 ; j++)
                    {
                        // function programming -- store function in varible : 
                        if (compareFunc.Invoke(array[i], array[j+1]))
                        {
                            SWAP(ref array[j], ref array[i + 1]);
                        }
                    }
                }
            }
        }


        private static void SWAP(ref T v1, ref T v2)
        {
            T temp = v1;
            v1 = v2;
            v2 = temp;
        }
    }
}
