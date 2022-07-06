using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LINQDemo
{
   
    //using System;

	//prototype class (design pattern) to save player info that could be easily retrieved via Unity scripts
	public class Player
	{
		[JsonProperty("name")]
		public string name { get; } //Getters & setters: https://codeasy.net/lesson/properties

		[JsonProperty("progress")]
		public int progress { get; private set; }

		[JsonProperty("id")]
		private string id { get; set; }

		[JsonProperty("rank")]
		public string rank { get; set; }

		public Player(string id, string name, int progress, string rank)
		{
			this.id = id;
			this.name = name;
			this.progress = progress;
			this.rank = rank;
		}

		public override string ToString()
		{
			return $"Player: Name: {name}, Progress: {progress}, Account Type: {id}, Rank: {rank}";
		}
	}

}
