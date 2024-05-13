using System;
namespace CarLotSimulator
{
	public class Car
	{

        //DONE- Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        //DONE- Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //DONE- The methods should take one string parameter: the respective noise property

        public Car()
		{
		}

		public int Year { get; set; }
		public string Make { get; set; }
		public string Model { get; set; }
		public string EngineNoise { get; set; }
		public string HonkNoise { get; set; }
		public bool IsDrivable { get; set; }

		public void MakeEngineNoise(string engineNoise)
		{
			Console.WriteLine(engineNoise);
		}

		public static void MakeHonkNoise(string honkNoise)
		{
			Console.WriteLine(honkNoise);
		}
	}
}

