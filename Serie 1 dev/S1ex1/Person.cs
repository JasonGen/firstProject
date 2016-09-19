using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1ex1
{
    class Person
    {
        
        

        public Person(String name, int age)
        {
            Name = name;
            Age = age;
        }

        public Person(string name, int age, int v) : this(name, age)
        {
            this.v = v;
        }

        public String Name { get; set; }
        //double tab -> voir doc msdn windows
        private int age;
        private int v;

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = (value > 0) ? value : 1;
            }
            
        }
        
        public override string ToString()
        {
            return Name + " agée de " + Age + " ans.";
        }

    }
}
