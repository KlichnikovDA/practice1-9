using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTask9
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            MyList List = MyList.MakeList(rnd.Next(0, 101));

            Console.WriteLine("В созданном списке {0} элементов.", MyList.GetLengthRecoursive(List));

            Console.WriteLine("В созданном списке {0} элементов.", MyList.GetLength(List));

            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
