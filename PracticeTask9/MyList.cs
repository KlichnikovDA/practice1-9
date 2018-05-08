using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTask9
{
    class MyList
    {
        // Информационное поле
        int Data;
        // Указатели на предыдущий и следующий элементы списка
        MyList Prev, Next;

        // Свойства
        public int GetData
        {
            get { return Data; }
        }

        public MyList GetPrev
        {
            get { return Prev; }
        }

        public MyList GetNext
        {
            get { return Next; }
        }

        // Конструкторы
        public MyList()
        {
            Data = 0;
            Prev = Next = null;
        }

        public MyList (int dat)
        {
            Data = dat;
            Prev = Next = null;
        }

        public override string ToString()
        {
            return Data + " ";
        }

        public static MyList MakeList(int Size)
        {
            if (Size <= 0)
                return null;

            // Вспомогательная переменная для генерации содержимого списка
            Random rnd = new Random();
            int Info = rnd.Next(-100, 101);
            // Начальный элемент списка
            MyList Beginning = new MyList(Info);
            // Вспомогательный элемент для прохода по списку
            MyList Support = Beginning;

            // Генерация списка
            for (int i = 2; i <= Size; i++)
            {
                // Создаем новый элемент
                Support.Next = new MyList(rnd.Next(-100, 101));
                // Привязываем новый элемент к предыдущему
                Support.Next.Prev = Support;
                // Переходим на следующий элемент
                Support = Support.Next;
            }

            return Beginning;
        }

        // Поиск количества элементов списка, рекурсивный
        public static int GetLengthRecoursive(MyList Beginning)
        {
            int Length = 0;
            if (Beginning.Next != null)
                Length = GetLengthRecoursive(Beginning.Next);
            return Length + 1;
            
        }
    }
}
