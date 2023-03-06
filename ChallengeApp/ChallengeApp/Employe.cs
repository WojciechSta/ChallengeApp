namespace ConsoleApp
{
    public class Employe
    {
        private List<int> scores = new List<int>();
        private string v;

        public string name { get; private set; }
        public string surname { get; private set; }

        public string age { get; private set; }
        public int Scores
        {
            get
            {
                return this.scores.Sum();

            }

        }
        public Employe(string name, string surname, string age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public Employe(string v)
        {
            this.v = v;
        }

        public void AddScores(int score)
        {
            scores.Add(score);
        }
    }
}
