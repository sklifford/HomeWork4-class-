using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Group
    {
        private Student[] Std;
        private int Quantity; //количество человек в группе
        private String GroupeName; //название группы
        private String GroupSpec; //спецификация
        private int CourceNumber; //номер курса
        public Group() : this(10) {}
        public Group(int Quantity)
        {
            Std = new Student[Quantity];
            String[] MaleName = {"Захар", "Иван", "Александр", "Константин", "Степан", "Антон", "Роман", "Федор", "Кирил", "Петр", "Владимир", "Вадим", "Виктор", "Михаил", "Герасим", "Олег"};
            String[] FemaleName = {"Альбина", "Алла", "Антонина", "Ирина", "Светлана", "Мария", "Маргарита", "Яна", "Юлия", "Анна", "Ольга", "Елена", "Людмила", "Екатерина", "Элеонора"};
            String[] LastName = {"Иванов", "Петров", "Сидоров", "Орлов", "Комаров", "Прохоров", "Романов", "Смирнов", "Тарасов", "Воробьев", "Карпов", "Неволин", "Власов", "Щукин"};
            int Sex;

            for(int i = 0; i < Std.Length; i++)
            {
                int Temp1, Temp2, Temp3;
                Sex = new Random().Next(1,2);
                if(Sex == 1)
                {
                    Temp1 = new Random().Next(0, MaleName.Length - 1);
                    Std[i].SetName(MaleName[Temp1]);
                    Temp1 = new Random().Next(0, LastName.Length - 1);
                    Std[i].SetLastName(LastName[Temp1]);
                    Temp1 = new Random().Next(0, MaleName.Length - 1);
                    Std[i].SetPatronymic(MaleName[Temp1] + "ович");
                } else
                {
                    Temp1 = new Random().Next(0, FemaleName.Length - 1);
                    Std[i].SetName(FemaleName[Temp1]);
                    Temp1 = new Random().Next(0, LastName.Length - 1);
                    Std[i].SetLastName(LastName[Temp1] + "а");
                    Temp1 = new Random().Next(0, MaleName.Length - 1);
                    Std[i].SetPatronymic(MaleName[Temp1] + "овна");
                }
                
                Temp1 = new Random().Next(1951, 2000);
                Temp2 = new Random().Next(1, 12);
                Temp3 = new Random().Next(1, 28);
                Std[i].SetBirthday(Temp1, Temp2, Temp3);
                for(int j = 0; j < 10; j++)
                {
                    Temp1 = new Random().Next(1);
                    Temp2 = new Random().Next(1, 12);
                    Temp3 = new Random().Next(1, 12);
                    Std[i].SetCredit((Int16)Temp1);
                    Std[i].SetCourseWork((Int16)Temp2);
                    Std[i].SetExam((Int16)Temp3);
                }
            }
            this.Quantity = Quantity;
            GroupeName = "Тест";
            GroupSpec = "Без спецификации";
            CourceNumber = 1;
        }
        public Group(Student[] S)
        {
            Std = new Student[1];
            for(int i = 0; i < S.Length; i++)
            {
                this.AddStudent(S[i]);
            }
            Quantity = S.Length;
            GroupeName = "Новая";
            GroupSpec = "Без спецификации";
            CourceNumber = 1;
        }
        public Group(Group Gcopy)
        {
            Std = new Student[Gcopy.Quantity];
            for(int i = 0; i < Std.Length; i++)
            {
                this.Std[i] = Gcopy.Std[i];
            }
            this.Quantity = Gcopy.Quantity;
            this.GroupeName = Gcopy.GroupeName;
            this.GroupSpec = Gcopy.GroupSpec;
            this.CourceNumber = Gcopy.CourceNumber;
        }
        public void ShowAll()
        {
            Console.WriteLine(GroupeName + " " + GroupSpec);
            Array.Sort(Std);
            for(int i = 0; i < Std.Length; i++)
            {
                Console.WriteLine("{0} {1} {2} {3}", i+1, Std[i].GetLastName(), Std[i].GetName(), Std[i].GetPatronymic());
            }
        }
        public void AddStudent(Student S)
        {
            Array.Resize(ref this.Std, this.Std.Length + 1);
            Std[Std.Length - 1].SetLastName(S.GetLastName());
            Std[Std.Length - 1].SetName(S.GetName());
            Std[Std.Length - 1].SetPatronymic(S.GetPatronymic());
            Std[Std.Length - 1].SetBirthday(S.GetBirthday());
            Std[Std.Length - 1].SetAddress(S.GetAddress());
            Std[Std.Length - 1].SetPhoneNumber(S.GetPhoneNumber());
            int index = 0;
            while(S.GetCredits(index) != -1)
            {
                Std[Std.Length - 1].SetCredit(S.GetCredits(index));
                index++;
            }
            index = 0;
            while(S.GetCourseWork(index) != -1)
            {
                Std[Std.Length - 1].SetCourseWork(S.GetCourseWork(index));
                index++;
            }
            index = 0;
            while(S.GetExam(index) != -1)
            {
                Std[Std.Length - 1].SetExam(S.GetExam(index));
                index++;
            }
        }
        /*public void SetGroup(???)
        {

        }
        public void SetStudent(int index, )
        {

        }
        public int GetQuantity()
        {
            return this.Quantity;
        }*/
    }
}
