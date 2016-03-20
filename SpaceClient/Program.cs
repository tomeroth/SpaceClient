using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceClient
{
    class Program
    {
        public static void PresentCrew(ServiceSpace.Starship starship)
        {
            Console.WriteLine("###########################################################");
            Console.WriteLine("###                  Crew Members                       ###");
            Console.WriteLine("###########################################################");
            Console.WriteLine("### Captain: " + starship.Captain.Name + ", age:" + starship.Captain.Age);
            int i = 1;
            foreach (ServiceSpace.Person p in starship.Crew)
            {
                Console.WriteLine("###########################################################");
                Console.WriteLine("### Nr:" + i + " | " + p.Name + ", age:" + p.Age);
                i++;
            }
            Console.WriteLine("###########################################################");
            Console.WriteLine();
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            ServiceSpace.BlackHoleClient myClientBlackHole = new ServiceSpace.BlackHoleClient();

            ServiceSpace.Starship myShip = new ServiceSpace.Starship();
            myShip.Name = "Icharus";
            myShip.Captain = new ServiceSpace.Person() { Name = "Capitan Jack Sparrow", Age = 43 };
            myShip.Crew = new ServiceSpace.Person[] { new ServiceSpace.Person() { Name = "Barbossa", Age = 65 }, new ServiceSpace.Person() { Name = "Hook", Age = 78 }, new ServiceSpace.Person() { Name = "Kraken", Age = 11 }, new ServiceSpace.Person() { Name = "Turner", Age = 67 } , new ServiceSpace.Person() { Name = "Blackbeard", Age = 54 } };
            PresentCrew(myShip);
            
            var newShip=myClientBlackHole.PullStarship(myShip);
            Console.WriteLine(myClientBlackHole.UltimateAnwser());
            Console.WriteLine();
            Console.WriteLine();
            PresentCrew(newShip);

            Console.ReadLine();
        }
    }
}
