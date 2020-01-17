using System;

namespace SingletonPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			Singleton.Ins.Hahaha();
			Singleton.Ins.Heiheihei();
			Singleton.Ins.Wuwuwu();

			Console.WriteLine("FINAL VALUE == " + Singleton.Ins.IntA);
			Console.ReadKey();
		}
	}


	class Singleton
	{
		public static Singleton Ins { get { return GetInstance(); } private set { } }

		private static Singleton _instance = null;
		private static Singleton GetInstance()
		{
			if (_instance == null)
			{
				_instance = new Singleton();
				Console.WriteLine("Go Singleton");
			}
			return _instance;
		}

		private Singleton()
		{
		}

		public int IntA { get; private set; }
		public void Hahaha()
		{
			IntA++;
			Console.WriteLine("Hahaha ——" + IntA);
		}

		public void Heiheihei()
		{
			IntA++;
			Console.WriteLine("Heiheihei ——" + IntA);
		}
		public void Wuwuwu()
		{
			IntA++;
			Console.WriteLine("Wuwuwu ——" + IntA);
		}
	}

}
