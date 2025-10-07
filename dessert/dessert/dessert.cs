using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dessert
{
    abstract class Dessert
    {

        public void AddSugar()
        {
            Console.WriteLine("Step 1: Add Sugar");
        }


        public abstract void Prepare();


        public void Serve()
        {
            Console.WriteLine("Step 3: Serve to the Customer\n");
        }

        
        public void MakeDessert()
        {
            AddSugar();
            Prepare();   
            Serve();
        }
    }

    
    class IceCream : Dessert
    {
        public override void Prepare()
        {
            Console.WriteLine("Step 2: Churn and Freeze the mixture");
        }
    }

  
    class Cake : Dessert
    {
        public override void Prepare()
        {
            Console.WriteLine("Step 2: Bake in the oven");
        }
    }

    class GulabJamun : Dessert
    {
        public override void Prepare()
        {
            Console.WriteLine("Step 2: Fry dough balls and soak in syrup");
        }
    }
}
