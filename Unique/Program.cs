using System;
using System.Collections.Generic;

namespace Unique
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3, 5, 2, 9, 7, 8, 0, 4, 1, 6
            int[] array = { 3, 5, 2, 9, 2, 0, 7, 3, 5, 8, 0, 3, 4, 2, 1, 8, 8, 6, 1, 5, 4, 9, 0, 3, 2, 1, 9, 7, 4, 9, 6, 2, 6, 9, 1 };

            Console.WriteLine("Array completo: \n");

            foreach (var i in array)
                Console.Write(i + ", ");

            Console.WriteLine("\n\nTotal de Elementos: {0}", array.Length);

            List<int> list = new List<int>();
            list.Add(array[0]);

            for (int i = 0; i < array.Length; i++)
            {
                int t = array[i];
                bool has = true;

                foreach (var item in list)
                {
                    if (t == item)
                    {
                        has = false;
                        break;
                    }
                }

                if (has)
                    list.Add(t);
            }

            Console.WriteLine("----------------------------------\n\n");
            Console.WriteLine("Lista filtrada:\n");

            foreach (int i in list)
                Console.Write(i + ", ");

            Console.WriteLine("\n\nTotal de Elementos: {0}", list.Count);
            Console.WriteLine("----------------------------------");
            Console.ReadLine();
        }
    }
}
