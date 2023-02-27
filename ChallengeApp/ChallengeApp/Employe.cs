namespace ConsoleApp
{
    internal class Employe
    {
        private List<int> scores = new List<int>();
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
        public void AddScores(int score)
        {
            scores.Add(score);
        }
    }
}}
