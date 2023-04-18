namespace ChallengeApp
{
    public abstract class Person
    {
        public Person(string name, string surname) : this(name)
        {
        }

        public Person(string name,string surname,char sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = Sex;
        }

        protected Person(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
        public string Surname { get; }
        public string  Sex { get; private set; }
    }
}
