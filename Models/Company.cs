using System;
using System.Collections.Generic;
using System.Text;

namespace Homework19._4._2022.Models
{
    class Company
    {
        private string _name;
        public int Limit;

        private Employee[] Employees;

        public string Name
        {
            get
            {
                return Name;
            }
            set
            {
                if (char.IsUpper(value[0]))
                {
                    foreach (char item in value)
                    {
                        if (!char.IsDigit(item) && !char.IsWhiteSpace(item) && !char.IsLetter(item))
                        {

                            Console.WriteLine("Daxil etdiyiniz Company Name duzgun deyil");
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Duzgun daxil edin");
                    return;
                }
            }
        }
        public Employee[] GetEmployee()
        {
            return Employees;
        }
        public void AddEmoployee(Employee employe)
        {
            if (Employees.Length < Limit)
            {
                Array.Resize(ref Employees, Employees.Length + 1);
                employe.No = Employees.Length;
                Employees[Employees.Length - 1] = employe;

            }
            else
            {
                Console.WriteLine("Yer Yoxdur");
            }

        }
    }
}
    
