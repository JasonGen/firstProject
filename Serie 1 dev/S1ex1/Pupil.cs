using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1ex1
{
    class Pupil : Person
    {
        public int Grade { get; set; }
        public List<Activity> LstActivities { get; set; }
        
        public char[] TabEval { get; set; }

        public Pupil(String name, int age, int grade) : base(name, age)
        {
            Grade = grade;
            LstActivities = new List<Activity>();
            TabEval = new char[10];
        }

        public Pupil(String name, int age) : this(name, age, 1) { }

        public void AddActivity(Activity act)
        {
            LstActivities.Add(act);
        }

        public void AddEvaluation(String title = null, char evaluation = 'S')
        {
            int cpt = 0;
            int cptActivities = LstActivities.Count();
            foreach (Activity activity in LstActivities)
            {
                if (activity.Title == title)
                {
                    TabEval[cpt] = evaluation;
                }
                cpt++;   
            }
        }

        public override string ToString()
        {
            string msg = base.ToString();
            
            int cptActivities = LstActivities.Count();
            if(cptActivities == 0)
            {
                msg += " Il n'y a pas encore d'activité choisie.";
            }
            else
            {
                msg += " a choisi les activités suivantes:\n";
                foreach(Activity activity in LstActivities)
                {
                    msg += activity;
                }
            }
            return msg;
        }
       

    }
}
