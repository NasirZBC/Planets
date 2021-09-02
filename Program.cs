using System;
using System.Collections.Generic;

namespace Planets
{
    class Program
    {


        static void Main(string[] args)
        {
            //New list with the Planet data type
            List<Planet> Planets = new List<Planet>();

            //Instancing of planets
            Planet Mercury = new Planet();
            Planet Venus = new Planet();
            Planet Earth = new Planet();
            Planet Mars = new Planet();
            Planet Jupiter = new Planet();
            Planet Saturn = new Planet();
            Planet Uranus = new Planet();
            Planet Neptune = new Planet();
            Planet Pluto = new Planet();

            //Assign values to the Planet properties
            Mercury.Name = "Mercury";
            Venus.Name = "Venus";
            Earth.Name = "Earth";
            Mars.Name = "Mars";
            Jupiter.Name = "Jupiter";
            Saturn.Name = "Saturn";
            Uranus.Name = "Uranus";
            Neptune.Name = "Neptune";
            Pluto.Name = "Pluto";

            Mercury.Mass = 0.330f;
            Venus.Mass = 4.87f;
            Earth.Mass = 5.97f;
            Mars.Mass = 0.642f;
            Jupiter.Mass = 1849f;
            Saturn.Mass = 549f;
            Uranus.Mass = 86.8f;
            Neptune.Mass = 102f;
            Pluto.Mass = 0.0146f;

            Mercury.Diameter = 4879;
            Venus.Diameter = 12104;
            Earth.Diameter = 12756;
            Mars.Diameter = 6792;
            Jupiter.Diameter = 142984;
            Saturn.Diameter = 120536;
            Uranus.Diameter = 51118;
            Neptune.Diameter = 49528;
            Pluto.Diameter = 2370;

            Mercury.Density = 5427;
            Venus.Density = 5243;
            Earth.Density = 5514;
            Mars.Density = 3933;
            Jupiter.Density = 1326;
            Saturn.Density = 687;
            Uranus.Density = 1271;
            Neptune.Density = 1638;
            Pluto.Density = 2095;

            Mercury.Gravity = 3.7f;
            Venus.Gravity = 8.9f;
            Earth.Gravity = 9.8f;
            Mars.Gravity = 3.7f;
            Jupiter.Gravity = 23.1f;
            Saturn.Gravity = 9.0f;
            Uranus.Gravity = 8.7f;
            Neptune.Gravity = 11.0f;
            Pluto.Gravity = 0.7f;

            Mercury.RotationPeriod = 1407.6f;
            Venus.RotationPeriod = -5832.5f;
            Earth.RotationPeriod = 23.9f;
            Mars.RotationPeriod = 24.6f;
            Jupiter.RotationPeriod = 9.9f;
            Saturn.RotationPeriod = 10.7f;
            Uranus.RotationPeriod = -17.2f;
            Neptune.RotationPeriod = 16.1f;
            Pluto.RotationPeriod = -153.3f;

            Mercury.LengthOfDay = 4222.6f;
            Venus.LengthOfDay = 2802.0f;
            Earth.LengthOfDay = 24.0f;
            Mars.LengthOfDay = 24.7f;
            Jupiter.LengthOfDay = 9.9f;
            Saturn.LengthOfDay = 10.7f;
            Uranus.LengthOfDay = 17.2f;
            Neptune.LengthOfDay = 16.3f;
            Pluto.LengthOfDay = 153.3f;

            Mercury.DistanceFromSun = 57.9f;
            Venus.DistanceFromSun = 108.2f;
            Earth.DistanceFromSun = 149.6f;
            Mars.DistanceFromSun = 227.9f;
            Jupiter.DistanceFromSun = 778.6f;
            Saturn.DistanceFromSun = 1433.5f;
            Uranus.DistanceFromSun = 2872.5f;
            Neptune.DistanceFromSun = 4495.1f;
            Pluto.DistanceFromSun = 5906.4f;

            Mercury.OrbitalPeriod = 88.0f;
            Venus.OrbitalPeriod = 224.7f;
            Earth.OrbitalPeriod = 365.2f;
            Mars.OrbitalPeriod = 687.0f;
            Jupiter.OrbitalPeriod = 4331f;
            Saturn.OrbitalPeriod = 10.747f;
            Uranus.OrbitalPeriod = 30589f;
            Neptune.OrbitalPeriod = 59.8f;
            Pluto.OrbitalPeriod = 90.56f;

            Mercury.OrbitalVelocity = 47.4f;
            Venus.OrbitalVelocity = 35.0f;
            Earth.OrbitalVelocity = 29.8f;
            Mars.OrbitalVelocity = 24.1f;
            Jupiter.OrbitalVelocity = 13.1f;
            Saturn.OrbitalVelocity = 9.7f;
            Uranus.OrbitalVelocity = 6.8f;
            Neptune.OrbitalVelocity = 5.4f;
            Pluto.OrbitalVelocity = 4.7f;

            Mercury.MeanTemp = 167;
            Venus.MeanTemp = 464;
            Earth.MeanTemp = 15;
            Mars.MeanTemp = -65;
            Jupiter.MeanTemp = -110;
            Saturn.MeanTemp = -140;
            Uranus.MeanTemp = -195;
            Neptune.MeanTemp = -200;
            Pluto.MeanTemp = -225;

            Mercury.NumberOfMoons = 0;
            Venus.NumberOfMoons = 0;
            Earth.NumberOfMoons = 1;
            Mars.NumberOfMoons = 2;
            Jupiter.NumberOfMoons = 67;
            Saturn.NumberOfMoons = 62;
            Uranus.NumberOfMoons = 27;
            Neptune.NumberOfMoons = 14;
            Pluto.NumberOfMoons = 5;

            Mercury.RingSystem = false;
            Venus.RingSystem = false;
            Earth.RingSystem = false;
            Mars.RingSystem = false;
            Jupiter.RingSystem = true;
            Saturn.RingSystem = true;
            Uranus.RingSystem = true;
            Neptune.RingSystem = true;
            Pluto.RingSystem = false;

            //Add planets to the Planets list
            Planets.Add(Mercury);
            Planets.Add(Earth);
            Planets.Add(Mars);
            Planets.Add(Jupiter);
            Planets.Add(Saturn);
            Planets.Add(Neptune);
            Planets.Add(Pluto);

            //Write the name of all planets that exist in the list.
            foreach (Planet element in Planets)
            {
                Console.WriteLine(element.Name);
            }

            
            //Run through the items of Planets and check where Mercury is and add Venus to item+1 
            Console.WriteLine();
            for(int i = 0; i < Planets.Count; i++)
            {
                Console.WriteLine(Planets[i].Name);
                if(Planets[i].Name == "Mercury")
                {
                    Planets.Insert(i + 1, Venus);
                }
            }

            Console.WriteLine();
            //Remove Pluto
            for (int i = 0; i < Planets.Count; i++)
            {

                if (Planets[i].Name == "Pluto")
                {
                    Planets.RemoveAt(i);
                }
                else
                {
                    Console.WriteLine(Planets[i].Name);
                }
            }


            Planets.Add(Pluto);

            Console.WriteLine();
            //Use of count method to get count elements in the Planets list
            Console.WriteLine("Antallet af elementer i listen: " + Planets.Count);
            Console.WriteLine();

            List<Planet> subZeroPlanets = new List<Planet>();
            List<Planet> fatPlanets = new List<Planet>();

            //Check all items in Planets
            //if MeanTemp is lower than 0 add to subZeroPlanets list
            //if Diameter is bigger than 10000 and smaller than 50000 add to fatPlanets list
            foreach (Planet element in Planets)
            {
                if (element.MeanTemp < 0)
                {
                    subZeroPlanets.Add(element);
                }
                if(element.Diameter > 10000 && element.Diameter < 50000)
                {
                    fatPlanets.Add(element);
                }
            }
            
            foreach(Planet element in subZeroPlanets)
            {
                Console.WriteLine("Planet: " + element.Name + " Temp: " + element.MeanTemp);
            }
            Console.WriteLine();
            foreach (Planet element in fatPlanets)
            {
                Console.WriteLine("Planet: " + element.Name + " Diameter: " + element.Diameter);
            }

            Console.WriteLine();

            //Remove all items from the Planets list
            Planets.Clear();
            Console.WriteLine("Planets list items: " + Planets.Count);

        }
    }
}
