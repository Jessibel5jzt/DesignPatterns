using System;

namespace FactoryMethodPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			var theCreatorGM = new ConcreteCreator();
			var theProductA = theCreatorGM.FactoryMethod<ConcreteProductA>();
			var theProductB = theCreatorGM.FactoryMethod<ConcreteProductB>();
			Console.ReadKey();
		}

	}

	public class ConcreteProductA : Product
	{
		public ConcreteProductA()
		{
			Console.WriteLine("生成对象类A");
		}
	}

	public class ConcreteProductB : Product
	{
		public ConcreteProductB()
		{
			Console.WriteLine("生成对象类B");
		}
	}
	public abstract class Product { }

	interface ICreator
	{
		Product FactoryMethod<T>() where T : Product, new();
	}

	public class ConcreteCreator : ICreator
	{
		public ConcreteCreator()
		{
			Console.WriteLine("产生具体工厂：ConcreteCreator");
		}

		public Product FactoryMethod<T>() where T : Product, new()
		{
			return new T();
		}
	}

}
