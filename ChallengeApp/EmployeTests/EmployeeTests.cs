using ChallengeApp;

namespace ChalllengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void EmployeeCheckPointsLetterChar()
        {
            //arange
            var employee = new Employee("Jan","Tyczka");
            employee.AddGrade('a');
            employee.AddGrade('b');
            employee.AddGrade('c');
            //act
            var statistics = employee.GetStatistics();
            //assert
            Assert.AreEqual('A', statistics.AverageLetter);


        }
        [Test]
        public void EmployeeCheckPointsLetterString() 
        {
            var employee = new Employee("Jan", "Tyczka");
            employee.AddGrade("65");
            employee.AddGrade("20");
            employee.AddGrade("40");
            var statistics = employee.GetStatistics();
            Assert.AreEqual('C', statistics.AverageLetter);
        }
    }
}
