using ConsoleApp;

var user1 = new Employe("Stefan", "Mucha", "Lat 30");
var user2 = new Employe("Jan", "Tyczka", "Lat 55");
var user3 = new Employe("Anna", "Fantik", "Lat 25");

user1.AddScores(5);
user1.AddScores(5);
user1.AddScores(5);
user1.AddScores(5);
user1.AddScores(5);

user2.AddScores(10);
user2.AddScores(10);
user2.AddScores(10);
user2.AddScores(10);
user2.AddScores(10);

user3.AddScores(2);
user3.AddScores(3);
user3.AddScores(8);
user3.AddScores(6);
user3.AddScores(1);


List<Employe> users = new List<Employe>()
{
  user1,user2,user3

};
int MaxResult = -1;
Employe UserWithMaxResult = null;
foreach (var user in users)
{
    if (user.Scores > MaxResult)
    {
        MaxResult = user.Scores;
        UserWithMaxResult = user;
    }


}
Console.WriteLine($"Najlepszy pracownik " +
    $"{UserWithMaxResult.name} {UserWithMaxResult.surname}" +
    $" {UserWithMaxResult.age}" + $" posiada {UserWithMaxResult.Scores} Punktów");