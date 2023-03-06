
using ConsoleApp;
using System.Runtime.CompilerServices;

namespace EmployeTests
{
    public class Test
    {
        [Test]
        public void GetIntValues_ShoulRetrunEquals()
        {
            int number1 = 8;
            int number2 = 8;

            Assert.AreEqual(number1, number2);
        }
        [Test]
        public void GetFloatValues_ShouldRetrunEqual()
        {
            float firstfloat = 1.0f;
            float secondfloat = 1.0f;
            Assert.AreEqual(firstfloat, secondfloat);
        }
        [Test]
        public void GetStringValues_ShouldRetrunDiffrent()
        {
            string name1 = "hello";
            string name2 = "hello";
            Assert.AreEqual(name1, name2);
        }
        private Employe GetEmploye (string name)
        {
            return new Employe(name);
        }
    }
}