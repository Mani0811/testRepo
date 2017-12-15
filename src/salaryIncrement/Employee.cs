using System;

namespace src.SalaryIncrement
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Salary { get; set; }

        public int Experience { get; set; }

        public Employee(String firstName, String lastName, int salary, int experience)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            Experience = experience;
        }
    }
}
