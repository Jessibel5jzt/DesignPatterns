using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			Context ct = new Context();
			ct.SetStrategy(new StrategyA());
			ct.ContextInterface();
			ct.SetStrategy(new StrategyB());
			ct.ContextInterface();
			ct.SetStrategy(new StrategyC());
			ct.ContextInterface();
			Console.ReadKey();
		}
	}

	public abstract class Strategy
	{
		public abstract void AlgorithmInterface();
	}

	public class StrategyA : Strategy
	{
		public override void AlgorithmInterface()
		{
			Console.WriteLine("StrategyA.AlgorithmInterface");
		}
	}

	public class StrategyB : Strategy
	{
		public override void AlgorithmInterface()
		{
			Console.WriteLine("StrategyB.AlgorithmInterface");
		}
	}

	public class StrategyC : Strategy
	{
		public override void AlgorithmInterface()
		{
			Console.WriteLine("StrategyC.AlgorithmInterface");
		}
	}

	public class Context
	{
		Strategy m_Strategy = null;

		public void SetStrategy(Strategy theStrategy)
		{
			m_Strategy = theStrategy;
		}

		public void ContextInterface()
		{
			m_Strategy.AlgorithmInterface();
		}
	}
}
