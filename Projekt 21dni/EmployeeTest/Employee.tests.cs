using NUnit.Framework;
using System.ComponentModel;

namespace Projekt_21dni.tests
{
    public class EmployeeTests
    {
        [Test]
        public void TESTMAX()
        {

            var employee = new Employee("Kamil", "A");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);


            var statistics = employee.GetStatistics();

            Assert.AreEqual(6, statistics.Max);


        }
        [Test]
        public void TESTMIN()
        {

            var employee = new Employee("Kamil", "A");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);


            var statistics = employee.GetStatistics();

            Assert.AreEqual(2, statistics.Min);
        }
        [Test]
        public void TESTAVERAGE()
        {

            var employee = new Employee("Kamil", "A");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);


            var statistics = employee.GetStatistics();

            Assert.AreEqual(Math.Round(3.33, 2), Math.Round(statistics.Average, 2));
        }
    }
}

