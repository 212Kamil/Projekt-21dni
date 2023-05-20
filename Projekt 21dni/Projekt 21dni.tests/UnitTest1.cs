using System.Reflection.Metadata;

namespace Projekt_21dni.tests
{
    public class Tests
    {
        [Test]
        public void dwapunkty()
        {

            var user = new Employee("Kamil", "hejhej231");
            user.AddScore(5);
            user.AddScore(6);
            user.AddScore(-8);

            var result = user.Result;

            Assert.That(result, Is.EqualTo(3));
        }
    }

}