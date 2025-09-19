using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetPerson
{
    public class Greet
    {


        String name;
        public Greet()
        {
            name = " Kartik ";
        }

        public Greet(string name)
        {
            this.name = name;
        }

        public void greet()
        {
            Console.WriteLine($"Good morning,{name}!");
        }
    }
}


