﻿using NPOI.XWPF.UserModel;
using System.Drawing.Text;

namespace ChallengeApp
{
    public class Employee : Person
    {

        private List<float> grades = new List<float>();
        private string v;

        public Employee(string name, string surname, char sex)
            : base(name, surname, sex)
        {
           
        }

        public Employee(string name,string surname)
            : base(name,surname)
        {
            
        }

        public Employee(string name) 
            : base(name) 
        {
        
        }


        public string Surname { get; private set; }
        public int a { get; private set; }

        public void AddGrade(float grade)
        {
            // 3.33
            // 3
            int valueInInt = (int)grade;
            float f = valueInInt;

            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else 
            {
                throw new Exception("Grade value should be between 0 and 100");
                //Console.WriteLine("invalid grade value");
            }
        }
        public void AddGrade(int grade)
        {
            float valueInIntFloat = (float)grade;
            this.AddGrade(valueInIntFloat);
        }

        public void AddGrade(char grade)
        {
            switch (grade) 
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;
                default:
                    throw new Exception("Wrong Letter");
            }
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else 
            {
                throw new Exception("Invalid grade value, only A-E and numercial allowed");
               
            }
        }
        public void AddGrade(double grade) 
        {
            float valueInIntFloat = (float)grade;
            this.grades.Add(valueInIntFloat);
        }
        public void AddGrade(long grade) 
        { 
            float valueInIntLong = (float)grade;
            this.grades.Add(valueInIntLong);
        }


        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            
            foreach (var grade in this.grades)
            {
                if (grade >= 0) 
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;
                }
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