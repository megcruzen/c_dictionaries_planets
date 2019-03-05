using System;
using System.Collections.Generic;

namespace dictionaries_planets
{
    class Program
    {
        static void Main(string[] args)
        {
            //  1. Use the list of planets you created in the previous chapter or create a new one with all eight planets.

            List<string> planetList = new List<string>(){"Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune"};

            // 2. Create another list containing dictionaries. Each dictionary will hold the name of a spacecraft that we have launched, and the name of the planet that it has visited. If it visited more than one planet, just pick one.

            List<Dictionary<string, string>> probes = new List<Dictionary<string, string>>();
            probes.Add (new Dictionary<string, string>(){ {"Uranus", "Voyager 2"} });
            probes.Add (new Dictionary<string, string>(){ {"Jupiter", "Pioneer 10"} });
            probes.Add (new Dictionary<string, string>(){ {"Jupiter", "Cassini"} });
            probes.Add (new Dictionary<string, string>(){ {"Mars", "Pathfinder"} });
            probes.Add (new Dictionary<string, string>(){ {"Mars", "Curiosity"} });
            probes.Add (new Dictionary<string, string>(){ {"Venus", "Mariner 2"} });
            probes.Add (new Dictionary<string, string>(){ {"Mercury", "Mariner 10"} });


            // 3. Iterate over planetList, and inside that loop, iterate over the list of dictionaries. Write to the console, for each planet, which satellites have visited which planet.

            foreach (string planet in planetList) // iterate planets
                {
                    List<string> matchingProbes = new List<string>();

                    foreach(Dictionary<string, string> probe in probes) // iterate probes
                    {
                        /*
                            Does the current Dictionary contain the key of
                            the current planet? Investigate the ContainsKey()
                            method on a Dictionary.

                            If so, add the current spacecraft to `matchingProbes`.
                        */

                        if (probe.ContainsKey(planet)) {
                            foreach (KeyValuePair<string, string> kvp in probe) {
                                matchingProbes.Add(kvp.Value);
                            }
                        }
                    }
                    /*
                        Use String.Join(",", matchingProbes) as part of the
                        solution to get the output below. It's the C# way of
                        writing `array.join(",")` in JavaScript.
                    */
                    // String.Join(",", matchingProbes);
                    // Console.WriteLine($"{}: {}");

                    Console.WriteLine($"{planet}: {String.Join(", ", matchingProbes)}");
                }

            // Example Output in the Terminal
            // Mars: Viking, Opportunity, Curiosity
            // Venus: Mariner, Venera
        }
    }
}
