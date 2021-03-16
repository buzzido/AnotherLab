using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGid
{
    public class MyStructClass
    {
        struct Students
        {
            public string name;
            public int kurs;
            public string gender;
            public enum gend
            {
                man = 1,
                woman,
                notch
            }
        }
        Students[] studArray;
        public MyStructClass()
        {
            Console.WriteLine("Введите количество студентов: ");
            studArray = new Students[Convert.ToInt32(Console.ReadLine())];
            Console.Clear();
            for (int i = 0; i < this.studArray.Length; i++)
            {
                Console.WriteLine("Введите имя " + (i + 1) + "-го студента: ");
                studArray[i].name = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Введите курс " + (i + 1) + "-го студента: ");
                studArray[i].kurs = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите пол " + (i + 1) + "-го студента: (1 - Мужчина, 2 - Женщина, 3 - Не указано)");
                int type = Convert.ToInt32(Console.ReadLine());
                if (type == (int)Students.gend.man)
                {
                    studArray[i].gender = "Мужчина";
                }
                if (type == (int)Students.gend.woman)
                {
                    studArray[i].gender = "Женщина";
                }
                if (type == (int)Students.gend.notch)
                {
                    studArray[i].gender = "Не указано";
                }
                Console.Clear();
            }
        }
        public void PrintStruct()
        {
            Console.Clear();
            Console.WriteLine("Имя\tКурс\tПол\t");
            Console.WriteLine();
            for (int i = 0; i < studArray.Length; i++)
            {
                Console.WriteLine(studArray[i].name + "\t" + studArray[i].kurs.ToString() + "\t" + studArray[i].gender);
            }
        }
        public void SortStruct()
        {
            for (int i = 0; i < studArray.Length - 1; i++)
            {
                for (int j = 0; j < studArray.Length - i - 1; j++)
                {
                    if (studArray[j].kurs.CompareTo(studArray[j + 1].kurs) == 1)
                    {
                        Students kurs = studArray[j];
                        studArray[j] = studArray[j + 1];
                        studArray[j + 1] = kurs;
                    }

                }
            }
        }
        public void Search(int Searchkurs)
        {
            for (int i = 0; i < studArray.Length; i++)
            {
                if (studArray[i].kurs == Searchkurs)
                {

                    Console.WriteLine(studArray[i].name + "dz \t" + studArray[i].kurs.ToString() + "\t" + studArray[i].gender);
                }
                else
                {
                    Console.WriteLine("Введенных данных не существует");
                }
            }
            Console.WriteLine("Нажмите любую кнопку...");
            Console.ReadKey();
            Console.Clear();

        }
    }
}
