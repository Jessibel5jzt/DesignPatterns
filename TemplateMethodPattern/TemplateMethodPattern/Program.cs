using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			AbstractClass theClass = new ConcreteClassA();
			theClass.TemplateMethod();

			theClass = new ConcreteClassB();
			theClass.TemplateMethod();
			Console.ReadKey();
		}
	}
	public abstract class AbstractClass
	{
		public void TemplateMethod()
		{
			PrimitiveOperation1();
			PrimitiveOperation2();
		}
		protected abstract void PrimitiveOperation1();
		protected abstract void PrimitiveOperation2();
	}

	public class ConcreteClassA : AbstractClass
	{
		protected override void PrimitiveOperation1()
		{
			Console.WriteLine("ConcreteClassA.PrimitiveOperation1");
		}
		protected override void PrimitiveOperation2()
		{
			Console.WriteLine("ConcreteClassA.PrimitiveOperation2");
		}
	}

	public class ConcreteClassB : AbstractClass
	{
		protected override void PrimitiveOperation1()
		{
			Console.WriteLine("ConcreteClassB.PrimitiveOperation1");
		}
		protected override void PrimitiveOperation2()
		{
			Console.WriteLine("ConcreteClassB.PrimitiveOperation2");
		}
	}
}
