using NUnit.Framework;
using System.ComponentModel;

namespace Projekt_21dni.tests
{
    public class TypeTests
    {
    [Test]
        public void TEST()
        {
            var employee = new Employee("Kamil", "A");
            employee.AddGrade(2);
            employee.AddGrade(7);
            employee.AddGrade(5);
            
            
            var statistics = employee.GetStatistics();
            Assert.AreEqual 



        }
    }