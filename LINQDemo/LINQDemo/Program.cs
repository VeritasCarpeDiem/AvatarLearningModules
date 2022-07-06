using LINQDemo;
using System.Collections.Generic;
using System.Text.Json;
// using UnityEngine;
using Newtonsoft.Json;


namespace LINQDEMO
{
    class Program
    {
        static void Main(string[] args)
        {
            #region JSON Serialize example:
            string file = File.ReadAllText(@"C:\Users\jinho\OneDrive\Documents\Visual Studio 2022\Projects\LINQDemo\LINQDemo\Player.json");

            List<Player> players = JsonConvert.DeserializeObject<List<Player>>(file);

            foreach (var user in players)
            {
                Console.WriteLine(user.ToString());
            }

            Console.WriteLine(new String('-', 50));
            #endregion

            #region LINQ demo:

            //Where: filter

            List<Player> playerWithProgressGreaterThan40 = new List<Player>();

            foreach (var player in players)
            {
                if(player.progress > 40)
                {
                    playerWithProgressGreaterThan40.Add(player);
                }
            }

            playerWithProgressGreaterThan40.ForEach(Console.WriteLine);

            Console.WriteLine(new String('-', 50));

            //This is equivalent to the above:
            IEnumerable<Player> equivalent = players.Where(x => x.progress > 40);

            foreach (var player in equivalent)
            {
                Console.WriteLine(player);
            }


            //Select: transform one data into another type

            IEnumerable<string> names = players.Select(x => x.name);

            foreach (var  name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine(new String('-', 50));

            //You can chain LINQ methods since they are extension methods

            //i.e. This is perfectly valid:

            var bronzePlayerNames = players.OrderBy(x => x.progress)
                             .Where(x => x.rank == "Bronze")
                             .Select(x => x.name)
                             .ToList();

            foreach (var name in bronzePlayerNames)
            {
                Console.WriteLine(name);
            }
            // For more LINQ query methods: https://code-maze.com/linq-csharp-basic-concepts/
            #endregion

            #region Extension Methods:
            int[] arr = new int[] { 1, 3, 4 };

            string[] stringArr = arr.Where(x => x > 2).Select(x => x.ToString()).ToArray();

            arr = stringArr.SelectDemo();

            #endregion
        }
    }
}
