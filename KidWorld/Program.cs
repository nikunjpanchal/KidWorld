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
        List<Playstuff> PlaystuffList;

        public Kids(string name, int age, int zipCode)
        {
            Name = name;
            Age = age;
            ZipCode = zipCode;
            PlaystuffList = new List<Playstuff>();
        }

        public void AddPlayStuff(Playstuff ps)
        {
            PlaystuffList.Add(ps);
        }

        public void RemovePlayStuff(Playstuff ps)
        {
            PlaystuffList.Remove(ps);
        }

        public void Display()
        {
            Console.WriteLine("Name:{0}",Name);
            Console.WriteLine("Age:{0}", Age);
            Console.WriteLine("Zipcode:{0}",ZipCode);

            foreach(var ps in PlaystuffList)
            {
                var messageToPrint = String.Format(" Title : {0}, Condition : {1}", ps.Title, ps.Condition);
                Console.WriteLine(messageToPrint);
            }
        }

        public void BorrowPs()
        {
            throw new System.NotImplementedException();
        }

        public void LoanPs()
        {
            throw new System.NotImplementedException();
        }

        public void DonatePs()
        {
            throw new System.NotImplementedException();
        }
    }

    public class Playstuff
    {
        public int RecAge;
        public string Condition;
        public string Title;
        private int Category;

        //public string type;

        public Playstuff(int recAge,string condition,string title)
        {
            RecAge = recAge;
            Condition = condition;
            Title = title;
        }

        public void CheckCondition()
        {
            throw new System.NotImplementedException();
        }

        public void RepairPs()
        {
            throw new System.NotImplementedException();
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Kids k1 = new Kids("Aaria", age:4, zipCode:98033);
            Playstuff ps = new Playstuff(recAge:3,title:"jigshawPuzzle", condition:" good");
            Kids k2 = new Kids("Manya", age:4, zipCode:98052);

            k1.Display();
            k2.Display();

            Console.ReadKey();

        }
    }
}
            