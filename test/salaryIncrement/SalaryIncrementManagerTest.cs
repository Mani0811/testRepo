using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using src.SalaryIncrement;

namespace test.SalaryIncrement
{
    /*
        We should increment employee salary based on their experience with a fixed percentage
        and get the total salary of all the employees
     */
     [TestClass]
    public class SalaryIncrementManagerTest
    {
        [TestMethod]
        public void ShouldComputeTotalSalaryAfterIncrementForEmployeesWithLessThan5YearExperience()
        {
            Employee employee1 = new Employee("John", "Snow", 25000, 3);
            Employee employee2 = new Employee("John", "Doe", 35000, 2);
            List<Employee> employees = new List<Employee>();
            employees.Add(employee1);
            employees.Add(employee2);

            SalaryIncrementManager calculator = new SalaryIncrementManager(employees);
            int totalSalaryOfAllTheEmployees = calculator.GetTotalSalaryOfAllEmployeesAfterIncrement();

            Assert.AreEqual(72000, totalSalaryOfAllTheEmployees);
        }

        [TestMethod]
        public void ShouldComputeTotalSalaryAfterIncrementForAllEmployeesWithVaryingExperience()
        {
            Employee employee1 = new Employee("John", "Snow", 25000, 3);
            Employee employee2 = new Employee("John", "Doe", 35000, 2);
            Employee employee3 = new Employee("Bare", "Ting", 100000, 6);
            Employee employee4 = new Employee("Susan", "Gowri", 325000, 17);
            Employee employee5 = new Employee("Harry", "Potter", 175000, 8);
            List<Employee> employees = new List<Employee>();
            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
            employees.Add(employee4);
            employees.Add(employee5);

            SalaryIncrementManager calculator = new SalaryIncrementManager(employees);
            int totalSalaryOfAllTheEmployees = calculator.GetTotalSalaryOfAllEmployeesAfterIncrement();

            Assert.AreEqual(739250, totalSalaryOfAllTheEmployees);
        }
    }

}
