using System;
using System.Linq;

namespace Assignment
{
    internal class Instructor1

    {
        public string Name { get; set; }
        public float avgfeedback { get; set; }
        public int experience { get; set; }
        public string[] instructorskill { get; set;  }
        public Instructor1(string name, float avgfeedback,int experience, string[] instructorskill) 
        {
            this.Name = name;
            this.avgfeedback = avgfeedback;
            this.experience = experience;
            this.instructorskill = instructorskill;

        }
        public bool CheckSkill(string technology)
        {
            if (validateEligibilty() && instructorskill.Contains(technology))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool validateEligibilty()
        {
            if(experience>3&&avgfeedback>=4.5)
            {
                return true;
            }
            else if (experience <= 3 && avgfeedback >= 4)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Experience" + experience);
                Console.WriteLine("Avg feedback" + avgfeedback);
                return false;
            }
        }

        static void Main(string[] args)
        {
            String[] skill = new string[] { "c#", "java", "sql" };
            Instructor1 i = new Instructor1("usha", 4.2f, 3, skill);
            Console.WriteLine("is instructor eligible" + i.validateEligibilty());
            Console.WriteLine("does instructor have skill in python"+i.CheckSkill("python"));

        }
    }
}
