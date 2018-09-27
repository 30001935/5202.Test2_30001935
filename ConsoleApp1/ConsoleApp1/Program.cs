/*
priyanka dhakal
 student Id=30001935
  */using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        string name, specices, sex weight, bandno
       public string name
        {
            get { return name; }
            set { name = Value; }

        }
        public string species
        {
            get { return species; }
            set { specices = Value; }

        }
        public string sex
        {
            get { return sex; }
            set { sex = Value; }

        }
        public string Weight
        {
            get { return weight; }
            set { weight = Value; }

        }
        public string Bandno
        {
            get { return bandno; }
            set { bandno = Value; }

        }
        public Bird(string _name, string _species, string _sex, string _weight, string bandno)
        {
            Name = _name;
            Species = _species;
            Sex = _sex;
            Weight = _weight;
            Bandno = _bandno;
        }
    }
    publi string Birdname()
    {
        return "bird name=" + Bird + "Species=" + Species + "Sex of Bird" + Sex + " Weight of Bird" + Weight + " Bandnumber" + Bandno;



        static void Main(string[] args)
        {
            Console.WriteLine("Please enter bird name: ");
            string bird = Console.ReadLine();
            Console.WriteLine("Please enter species name: ");
            string species = Console.ReadLine();
            Console.WriteLine("Please enter sex name: ");
            string sex = Console.ReadLine();
            Console.WriteLine("Please enter weight name: ");
            string weight = Console.ReadLine();
            Console.WriteLine("Please enter bandno name: ");
            string bandno = Console.ReadLine();
            Bird first = new Bird(Birdtype, Species, sex, Weight, Bandno);
            Console.WriteLine(first.Birdname());




        }
    }
}