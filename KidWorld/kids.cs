using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidWorld
{
    class Kids
    {
        //Kid's Information
        string Name;
        int Age;
        int ZipCode;

        public void GetDetails()
        {
            Name = "Aaria";
            Age = 4;
            ZipCode = 98033;
        }
        public void Display()
        {
            Console.WriteLine("Name:{0}", Name);
            Console.WriteLine("Age:{0}", Age);
            Console.WriteLine("Zipcode:{0}", ZipCode);
        }
    }
}
