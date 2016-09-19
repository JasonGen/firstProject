using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil p1 = new Pupil("Spencer", 18, 15);
            Activity a1 = new Activity("biology", false);
            Activity a2 = new Activity("math", true);
            Activity a3 = new Activity("Coloriage", true);
            
            p1.AddEvaluation("Coloriage");
            
            


            p1.AddActivity(a1);
            p1.AddActivity(a2);
            p1.AddActivity(a3);

            for (int i = 0; i < 10; i++)
            {
                System.Console.Write(i);
                System.Console.Write(p1.TabEval[i]);

            }
            System.Console.Write(p1);
            System.Console.Read();


        }
    }
}
