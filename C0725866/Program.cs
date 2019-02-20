using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0725866
{

    class Program
    {
        static void Main(string[] args)
        {
            var a = new CountrySide();
            a.Run();
        }
    }
    class mr
    { 
        public void motivator()
        {
            Console.WriteLine("Trace");
            int sum = 0;
            sum = sum + 1;
            motivator();
        }
    }
    class UsingRecursion
    {
        // Create an application which 
        // calculates the sum of all the numbers from n to m recursively:

        public static int CalculateRecursively(int n, int m)
        {
            int sum = n;

            if (n < m)
            {
                n++;
                return sum += CalculateRecursively(n, m);

            }
            return sum;
        }
        
    

    }

    class CountrySide
    {
        // Create the LinkedList to reflect the Map in the PowerPoint Instructions
        Village Maeland;
        Village Helmholtz;
        Village Alst;
        Village Wessig;
        Village Badden;
        Village Uster;
        Village Schvenig;

        public void Run()
        {
            Village Alst = new Village("Alst", false);
            Village Schvenig = new Village("Schvenig", false);
            Village Wessig = new Village("Wessig", false);
            Alst.west = Schvenig;
            Alst.east = Wessig;
            Alst.distanceToEastVillage = 14;
            Alst.distanceToWestVillage = 19;

        }
        public Village travelVillages(Village currentVillage)
        {

        }


        class Village
        {
            public Village(string _villageName, bool _isAHere)
            {
                isAstrildgeHere = _isAHere;
                VillageName = _villageName;
            }

            public Village west;
            public Village east;
            public string VillageName;
            public int distanceToWestVillage;
            public int distanceToEastVillage;
            public bool isAstrildgeHere;
        }
    }


}
