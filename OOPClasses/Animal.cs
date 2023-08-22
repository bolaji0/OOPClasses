using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPClasses
{
    public class Animal
    {
        public string Name { get; set; }
        
        public void AnimalSound()
        {
            Console.WriteLine($"This is animal {Name} Sound is roaar");
        }
    }


}
