namespace ChallengeApp
{
    public class Suprvisior : IEmployee
    {
        private List<float> grades = new List<float>();
        private string Age;
        private object scoresSupervisior;
        private string grade;

        public Suprvisior(string Name, string surname, string age) 
        {
            this.name = Name;
            this.surname = Surname;
            this.age = Age;
        }
        public string name { get; private set; }
        public string surname { get; private set; }
        public string age { get; private set; }
        public void AddScore(float grade) 
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else 
            {
              throw new Exception("Invalid grade value");
            }
        }
        public string Name => throw new NotImplementedException();

        public string Surname => throw new NotImplementedException();

        public void AddGrade(float grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(double grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(int grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrade(char grade)
        {
            throw new NotImplementedException();
        }

        public Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }

        public void AddGrade(string grade)
        {
            throw new NotImplementedException();
        }

        public void AddGrage(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                switch (grade)
                {
                    case "6":
                        this.grades.Add(100);
                        break;
                    case "-6":
                        this.grades.Add(95);
                        break;
                    case "+5":
                        this.grades.Add(85);
                        break;
                    case "5":
                        this.grades.Add(80);
                        break;
                    case "-5":
                        this.grades.Add(75);
                        break;
                    case "+4":
                        this.grades.Add(65);
                        break;
                    case "4":
                        this.grades.Add(60);
                        break;
                    case "-4":
                        this.grades.Add(55);
                        break;
                    case "+3":
                        this.grades.Add(45);
                        break;
                    case "3":
                        this.grades.Add(40);
                        break;
                    case "-3":
                        this.grades.Add(35);
                        break;
                    case "+2":
                        this.grades.Add(25);
                        break;
                    case "2":
                        this.grades.Add(20);
                        break;
                    case "-2":
                        this.grades.Add(15);
                        break;
                    case "1":
                        this.grades.Add(0);
                        break;
                    default:
                        throw new Exception("invalid grade value");
                }
            }
        }
        public Statistics AverageValue()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            statistics.Average = statistics.Average / this.grades.Count;
            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
            return statistics;

        }
    }
}
