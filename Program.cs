using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planeter_Opgave
{
    class Program
    {
        static void Main(string[] args)
        {
            // Her laver vi en liste der kan holde informationen om vores planeter
            List<Planeter> planets = new List<Planeter>();

            // Her opretter vi nye planeter
            Planeter mercury = new Planeter();
            Planeter venus = new Planeter();
            Planeter earth = new Planeter();
            Planeter mars = new Planeter();
            Planeter jupiter = new Planeter();
            Planeter saturn = new Planeter();
            Planeter uranus = new Planeter();
            Planeter neptune = new Planeter();
            Planeter pluto = new Planeter();

            // Her tilføjer vi navn og attributes til
            // en planet og adder den til listen
            planets.Add(mercury);
            mercury.Mass = 0.330f; // Brug f for at angive at det er en float
            mercury.Diameter = 4879;
            mercury.Density = 5427;
            mercury.Gravity = 3.7f;
            mercury.RotationPeriod = 1407.6f;
            mercury.DayLength = 4222.6f;
            mercury.SunDistance = 57.9f;
            mercury.OrbitPeriod = 88.0f;
            mercury.OrbitVelocity = 47.4f;
            mercury.Temperature = 167;
            mercury.Moons = 0;
            mercury.RingSystem = "No";
            mercury.Name = "Mercury";


            planets.Add(earth);
            earth.Mass = 5.97f;
            earth.Diameter = 12756;
            earth.Density = 5514;
            earth.Gravity = 9.8f;
            earth.RotationPeriod = 23.9f;
            earth.DayLength = 24f;
            earth.SunDistance = 149.6f;
            earth.OrbitPeriod = 365.2f;
            earth.OrbitVelocity = 29.8f;
            earth.Temperature = 15;
            earth.Moons = 1;
            earth.RingSystem = "No";
            earth.Name = "Earth";


            planets.Add(mars);
            mars.Mass = 0.642f;
            mars.Diameter = 6792;
            mars.Density = 3933;
            mars.Gravity = 3.7f;
            mars.RotationPeriod = 24.6f;
            mars.DayLength = 24.7f;
            mars.SunDistance = 227.9f;
            mars.OrbitPeriod = 687f;
            mars.OrbitVelocity = 24.1f;
            mars.Temperature = -65;
            mars.Moons = 2;
            mars.RingSystem = "No";
            mars.Name = "Mars";


            planets.Add(jupiter);
            jupiter.Mass = 1898f;
            jupiter.Diameter = 142984;
            jupiter.Density = 3933;
            jupiter.Gravity = 3.7f;
            jupiter.RotationPeriod = 9.9f;
            jupiter.DayLength = 9.9f;
            jupiter.SunDistance = 778.6f;
            jupiter.OrbitPeriod = 4331f;
            jupiter.OrbitVelocity = 13.1f;
            jupiter.Temperature = -110;
            jupiter.Moons = 67;
            jupiter.RingSystem = "Yes";
            jupiter.Name = "Jupiter";


            planets.Add(saturn);
            saturn.Mass = 568f;
            saturn.Diameter = 120536;
            saturn.Density = 687;
            saturn.Gravity = 9f;
            saturn.RotationPeriod = 10.7f;
            saturn.DayLength = 10.7f;
            saturn.SunDistance = 1433.5f;
            saturn.OrbitPeriod = 10747f;
            saturn.OrbitVelocity = 9.7f;
            saturn.Temperature = -140;
            saturn.Moons = 62;
            saturn.RingSystem = "Yes";
            saturn.Name = "Saturn";


            planets.Add(uranus);
            uranus.Mass = 86.8f;
            uranus.Diameter = 51118;
            uranus.Density = 1271;
            uranus.Gravity = 8.7f;
            uranus.RotationPeriod = -17.2f;
            uranus.DayLength = 17.2f;
            uranus.SunDistance = 2872.5f;
            uranus.OrbitPeriod = 30589f;
            uranus.OrbitVelocity = 6.8f;
            uranus.Temperature = -195;
            uranus.Moons = 27;
            uranus.RingSystem = "Yes";
            uranus.Name = "Uranus";


            planets.Add(neptune);
            neptune.Mass = 102f;
            neptune.Diameter = 49528;
            neptune.Density = 1638;
            neptune.Gravity = 11f;
            neptune.RotationPeriod = 16.1f;
            neptune.DayLength = 16.1f;
            neptune.SunDistance = 4495.1f;
            neptune.OrbitPeriod = 59800f;
            neptune.OrbitVelocity = 5.4f;
            neptune.Temperature = -200;
            neptune.Moons = 14;
            neptune.RingSystem = "Yes";
            neptune.Name = "Neptune";

            planets.Add(pluto);
            pluto.Mass = 0.0146f;
            pluto.Diameter = 2370;
            pluto.Density = 2095;
            pluto.Gravity = 0.7f;
            pluto.RotationPeriod = -153.3f;
            pluto.DayLength = 153.3f;
            pluto.SunDistance = 5906.4f;
            pluto.OrbitPeriod = 90560f;
            pluto.OrbitVelocity = 4.7f;
            pluto.Temperature = -225;
            pluto.Moons = 5;
            pluto.RingSystem = "No";
            pluto.Name = "Pluto";


            planets.Insert(1, venus);          
            venus.Mass = 4.87f;
            venus.Diameter = 12104;
            venus.Density = 5243;
            venus.Gravity = 8.9f;
            venus.RotationPeriod = -5832.5f;
            venus.DayLength = 2802f;
            venus.SunDistance = 108.2f;
            venus.OrbitPeriod = 224.7f;
            venus.OrbitVelocity = 35f;
            venus.Temperature = 464;
            venus.Moons = 0;
            venus.RingSystem = "No";
            venus.Name = "Venus";

            // Her udskriver vi en liste med navnene på planeterne
            foreach (Planeter globe in planets)
            {
                Console.Write(globe.Name + " ");
            }

            // Her finder vi pluto ved at løbe
            // igennem indexet på vores liste
            for (int i = 0; i < planets.Count; i++)
            {
                if (planets[i].Name == "Pluto")
                {
                    planets.RemoveAt(i);
                }
            }

            // \n giver os en ny linje
            Console.WriteLine("\nPlanets (Pluto excluded): ");

            // Her udskriver vi en liste med navnene på planeterne
            foreach (Planeter globe in planets)
            {
                Console.Write(globe.Name + " ");
            }

            // Indbygget loop som tjekker listen for 
            // variablen Pluto og fjerner den herefter
            //planets.RemoveAt(planets.IndexOf(pluto));

            // Her tilføjer vi Pluto til vores liste igen
            planets.Add(pluto);

            // For at lave et mellemrum imellem vores lister
            Console.WriteLine();

            // Her udskriver vi en liste med navnene på planeterne
            foreach (Planeter globe in planets)
            {
                Console.Write(globe.Name + " ");
            }

            // Udskriver hvor mange elementer vi har i vores liste
            Console.WriteLine("\n" + planets.Count);

            // Her laver vi en ny liste der skal indeholde
            // planeter med en temperatur på under 0 grader
            List<Planeter> coldplanets = new List<Planeter>();

            // Her tilføjer vi planeter til vores nye liste "coldplanets"
            // vi tager kun de elementer som passer indenfor vores parametre
            foreach (Planeter globe in planets)
            {
                if (globe.Temperature < 0)
                {
                    coldplanets.Add(globe);
                }
            }

            // Her udskriver vi vores coldplanets liste
            foreach (Planeter globe in coldplanets)
            {
                Console.Write(globe.Name + " ");
            }

            // Her laver vi en ny liste der skal indeholde planeter
            // med en diameter imellem 10000km og 50000km
            List<Planeter> bigplanets = new List<Planeter>();

            // Her tilføjer vi planeter til vores nye liste "bigplanets"
            // vi tager kun de elementer som passer indenfor vores parametre
            foreach (Planeter globe in planets)
            {                
                if (10000 < globe.Diameter && globe.Diameter < 50000) 
                {
                    bigplanets.Add(globe);
                }
            }

            // For at lave et mellemrum imellem vores lister
            Console.WriteLine();

            // Her udskriver vi vores bigplanets liste
            foreach (Planeter globe in bigplanets)
            {
                Console.Write(globe.Name + " ");
            }

            Console.WriteLine();

            // Her fjerner vi alle elementer i planets listen
            planets.Clear();

        }
    }
}
