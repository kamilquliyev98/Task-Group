using System;
using System.Collections.Generic;
using System.Text;

namespace Task_Group.Models
{
    class Student
    {
        public string Fullname
        {
            get
            {
                return _fullname;
            }
            set
            {
                string[] fn = value.Split(' ');
                if (fn.Length < 2)
                {
                    Console.WriteLine("Ad ve soyadi duzgun daxil etmediniz.");
                    return;
                }
                _fullname = value;
            }
        }
        private string _fullname;
        public string GroupNo
        {
            get
            {
                return _groupNo;
            }
            set
            {
                int digit;
                if (value.Length != 4 || !Char.IsUpper(value[0]) || !int.TryParse(value.Substring(1, 3), out digit))
                {
                    Console.WriteLine("Qrup nomresini duzgun daxil etmediniz.");
                    return;
                }
                _groupNo = value;
            }
        }
        private string _groupNo;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Yas duzgun daxil olunmadi.");
                    return;
                }

                _age = value;
            }
        }
        private int _age;

        public Student(string fullname, string groupNo, int age)
        {
            if (!CheckFullname(fullname))
            {
                Console.WriteLine("Ad soyadi duzgun daxil etmediniz.");
                return;
            }

            if (!CheckGroupNo(groupNo))
            {
                Console.WriteLine("Qrup nomresini duzgun daxil etmediniz.");
                return;
            }

            _fullname = fullname;
            _groupNo = groupNo;
            _age = age;
        }

        public static bool CheckGroupNo(string groupNo)
        {
            int digit;
            if (groupNo.Length != 4 || !Char.IsUpper(groupNo[0]) || !int.TryParse(groupNo.Substring(1, 3), out digit))
            {
                return false;
            }

            return true;
        }

        public static bool CheckFullname(string fullname)
        {
            string[] fn = fullname.Split(' ');
            if (fn.Length < 2 || String.IsNullOrWhiteSpace(fullname))
            {
                return false;
            }

            return true;
        }

        public override string ToString()
        {
            return $"Ad Soyad: {_fullname}\nQrup nomresi: {_groupNo}\nYas: {_age}\n\n";
        }
    }
}
