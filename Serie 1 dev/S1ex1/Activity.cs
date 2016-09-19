using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1ex1
{
    class Activity
    {
        public String Title { get; set; }
        public Boolean Compulsory { get; set; }

        public Activity(String title, Boolean compulsory)
        {
            Title = title;
            Compulsory = compulsory;
        }

        public override string ToString()
        {
            String msg;
            msg = Title + " n'est  pas un cours obligatoire\n";

            if (Compulsory)
            {
                msg = Title + " est un cours obligatoire\n";
            }
            return msg;
        }
    }
}
