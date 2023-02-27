using ConsoleApp;

namespace ChallengeApp.Tests;

public class Tests
{
    [Test]
    public void WhenEmployeGetAddScores() 
    {
        // arrage
        var user = new Employe("Rafa³", "Kopek", "22");
        user.AddScores(10);
        user.AddScores(1);
        user.AddScores(5);
        user.AddScores(6);
        user.AddScores(-10);
        // sct
        int result = user.Scores;
        // assert
        Assert.That(result, Is.EqualTo(12));
    }
}        