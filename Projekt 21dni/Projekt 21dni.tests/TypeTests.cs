namespace Projekt_21dni.tests
{
    public class TypeTests
    {
        [Test]
        public void TEST()
        {

            // arrange
            var user1 = GetUser("Kamil");
            var user2 = GetUser("Emilka");

            // act


            // assert
            Assert.AreNotEqual(user1, user2);
        }
        [Test]
        public void INT()
        {

            // arrange
            int number1 = (1);
            int number2 = (1);

            // act


            // assert
            Assert.AreEqual(number1, number2);
        }
        [Test]
        public void String()
        {

            // arrange
            string name1 = ("Karolina");
            string name2 = ("Kuba");

            // act


            // assert
            Assert.AreNotEqual(name1, name2);
        }


        private Employee GetUser(string name)
        {
            return new Employee(name);
        }
    }
}

//test