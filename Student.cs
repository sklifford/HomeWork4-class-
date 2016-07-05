using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Student
    {
        private string Name; //имя
        private string LastName; //фамилия
        private string Patronymic; //отчество
        private DateTime Birthday; //дата рождения
        private string Address; //домашний адрес
        private string PhoneNumber; //телефонный номер
        private Int16[] Credits; //зачеты
        private Int16[] Coursework; //курсовые работы
        private Int16[] Exam; //экзамены

        public Student() : this("Пусто", "Аноним", "Пусто", 2000, 1, 1, "Пусто", "Пусто") {}
        public Student(string LastName, string Name, string Patronymic) : this(LastName, Name, Patronymic, 2000, 1, 1, "Пусто", "Пусто"){}
        public Student(string LastName, string Name, string Patronymic, int Birthday_Year, int Birthday_Month, int Birthday_Day) : this(LastName, Name, Patronymic, Birthday_Year, Birthday_Month, Birthday_Day, "Пусто", "Пусто") {}
        public Student(string LastName, string Name, string Patronymic, int Birthday_Year, int Birthday_Month, int Birthday_Day, string Address, string PhoneNumber)
        {
            this.LastName = LastName;
            this.Name = Name;
            this.Patronymic = Patronymic;
            this.Address = Address;
            this.PhoneNumber = PhoneNumber;
            this.Birthday = new DateTime(Birthday_Year, Birthday_Month, Birthday_Day);
            Credits = new Int16[1];
            Coursework = new Int16[1];
            Exam = new Int16[1];
        }

        public string GetName()
        {
            return Name;
        }
        public string GetLastName()
        {
            return LastName;
        }
        public string GetPatronymic()
        {
            return Patronymic;
        }
        public string GetAddress()
        {
            return Address;
        }
        public string GetPhoneNumber()
        {
            return PhoneNumber;
        }
        public DateTime GetBirthday()
        {
            return Birthday;
        }
        public Int16 GetCredits(int index)
        {
            if (index < Credits.Length)
            {
                return Credits[index];
            }
            else
            {
                return -1;
            }
        }
        public Int16 GetCourseWork(int index)
        {
            if(index < Coursework.Length)
            {
                return Coursework[index];
            }
            else
            {
                return -1;
            }
        }
        public Int16 GetExam(int index)
        {
            if(index < Exam.Length)
            {
                return Exam[index];
            }
            else
            {
                return -1;
            }
        }
        public void SetName(string Name)
        {
            this.Name = Name;
        }
        public void SetLastName(string LastName)
        {
            this.LastName = LastName;
        }
        public void SetPatronymic(string Patronymic)
        {
            this.Patronymic = Patronymic;
        }
        public void SetAddress(string Address)
        {
            this.Address = Address;
        }
        public void SetPhoneNumber(string PhoneNumber)
        {
            this.PhoneNumber = PhoneNumber;
        }
        public void SetBirthday(int Year, int Month, int Day)
        {
            this.Birthday = new DateTime(Year, Month, Day);
        }
        public void SetBirthday(DateTime Date)
        {
            this.Birthday = Date;
        }
        public void SetCredit(Int16 value, int index)
        {
            if(index < this.Credits.Length)
            {
                this.Credits[index] = value;
            }
        }
        public void SetCredit(Int16 value)
        {
            Array.Resize(ref this.Credits, this.Credits.Length + 1);
            this.Credits[Credits.Length - 1] = value;
        }
        public void SetCourseWork(Int16 value, int index)
        {
            if(index < this.Coursework.Length)
            {
                this.Coursework[index] = value;
            }
        }
        public void SetCourseWork(Int16 value)
        {
            Array.Resize(ref this.Coursework, this.Coursework.Length + 1);
            this.Coursework[Coursework.Length - 1] = value;
        }
        public void SetExam(Int16 value, int index)
        {
            if(index < this.Exam.Length)
            {
                this.Exam[index] = value;
            }
        }
        public void SetExam(Int16 value)
        {
            Array.Resize(ref this.Exam, this.Exam.Length + 1);
            this.Exam[Exam.Length - 1] = value;
        }
        public void Show()
        {
            Console.WriteLine(this.LastName + " " + this.Name + " " + this.Patronymic);
            Console.WriteLine("Дата рождения: " + this.Birthday);
            Console.WriteLine("Телефон: " + this.PhoneNumber);
            Console.WriteLine("Домашний адрес: " + this.Address);
            Console.Write("Зачеты: ");
            foreach(Int16 i in this.Credits)
            {
                Console.Write("{0} ",i);
            }
            Console.Write("\nОценки за курсовые работы: ");
            foreach (Int16 i in this.Coursework)
            {
                Console.Write("{0} ", i);
            }
            Console.Write("\nОценки за экзамены: ");
            foreach (Int16 i in this.Exam)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine("\n---------------------------------------------------------------");
        }
    }
}
