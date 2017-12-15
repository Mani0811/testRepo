using System.Collections.Generic;
using System.Diagnostics;

namespace src.SalaryIncrement
{
    public class SalaryIncrementManager
    {
        private static int _percentIncreaseForBelow5YearExp = 20;
        private static int _percentageIncreaseForBelow10YearAndAbove5YearExp = 15;
        private static int _percentageIncreaseAbove10YearExp = 8;
        private List<Employee> _employees;
        public SalaryIncrementManager(List<Employee> employees)
        {
            _employees = employees;
        }

        public int GetTotalSalaryOfAllEmployeesAfterIncrement()
        {
            int totalSalary = 0;
            foreach (var emply in _employees)
            {
                if(emply.Experience<5)
                {
                    totalSalary += (int) (emply.Salary + emply.Salary * _percentIncreaseForBelow5YearExp*.01);
                    continue;
                }
                else if (emply.Experience < 10)
                {
                    totalSalary += (int) (emply.Salary + emply.Salary * _percentageIncreaseForBelow10YearAndAbove5YearExp*.01);
                    continue;
                }
                totalSalary += (int) (emply.Salary + emply.Salary * _percentageIncreaseAbove10YearExp*.01);
            }
            return totalSalary;
        }
    }
}
