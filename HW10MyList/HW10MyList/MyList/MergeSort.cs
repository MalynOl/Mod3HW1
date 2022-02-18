using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10MyList
{
    public class MergeSort
    {
        public static T[] Merge_Sort<T>(T[] mas)
        where T : IComparable<T>
        {
            if (mas.Length == 1)
            {
                return mas;
            }

            int m = mas.Length / 2;
            return Merge(Merge_Sort(mas.Take(m).ToArray()), Merge_Sort(mas.Skip(m).ToArray()));
        }

        public static T[] Merge<T>(T[] mass1, T[] mass2)
        where T : IComparable<T>
        {
            int a = 0, b = 0;
            T[] merged = new T[mass1.Length + mass2.Length];
            for (int i = 0; i < mass1.Length + mass2.Length; i++)
            {
                if (b < mass2.Length && a < mass1.Length)
                {
                    if (mass1[a].CompareTo(mass2[b]) < 0)
                    {
                        merged[i] = mass1[a++];
                    }
                    else
                    {
                        merged[i] = mass2[b++];
                    }
                }
                else
                {
                    if (b < mass2.Length)
                    {
                        merged[i] = mass2[b++];
                    }
                    else
                    {
                        merged[i] = mass1[a++];
                    }
                }
            }

            return merged;
        }
    }
}
