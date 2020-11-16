using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sign_massive
{
    class Program
    {
        static int[] ReadMassive()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mas = new Int32[n];
            string[] s = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
                mas[i] = Convert.ToInt32(s[i]);
            return mas;
        }

        static void WriteMassive(int[] m)
        { 
            foreach(var el in m)
                Console.Write(el + " ");
            Console.WriteLine();
        }

        static int[] SelectDivisibleThree(int[] m)
        {
            int[] DivThree = new Int32[m.Length];
            int index = 0;
            for (int i = 0; i < m.Length; i++)
                if (m[i] % 3 == 0)
                {
                    DivThree[index++] = m[i];
                    //DivThree[index] = m[i];
                    //index++;
                }
            return DivThree;
        }

        static void Main(string[] args)
        {
            //1 ввод массива
            int[] a = ReadMassive();
            //2 обработка
            int[] b = SelectDivisibleThree(a); 
            //3 вывод результаты
            WriteMassive(b);
        }
    }
}
