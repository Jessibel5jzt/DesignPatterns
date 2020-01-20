using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
	class Program
	{
		static void Main(string[] args)
		{
			Context theContext = new Context();
			theContext.SetState(new ConcreteStateA(theContext));
			theContext.Request(5);
			theContext.Request(15);
			theContext.Request(25);
			theContext.Request(35);
			Console.ReadLine();
		}
	}

	public class Context
	{
		State m_State = null;

		public void Request(int Value)
		{
			m_State.Handle(Value);
		}

		public void SetState(State theState)
		{

			Console.WriteLine("Context.SetState:" + theState);
			m_State = theState;
		}
	}

	public abstract class State
	{
		protected Context m_Context = null;
		public State(Context theConText)
		{
			m_Context = theConText;
		}
		public abstract void Handle(int Value);
	}

	//状态A
	public class ConcreteStateA : State
	{
		public ConcreteStateA(Context theContext) : base(theContext) { }

		public override void Handle(int Value)
		{
			Console.WriteLine("ConcreteStateA.Handle");
			if (Value > 10)
				m_Context.SetState(new ConcreteStateB(m_Context));
		}
	}

	//状态B
	public class ConcreteStateB : State
	{
		public ConcreteStateB(Context theContext) : base(theContext) { }

		public override void Handle(int Value)
		{
			Console.WriteLine("ConcreteStateA.Handle");
			if (Value > 20)
				m_Context.SetState(new ConcreteStateC(m_Context));
		}
	}

	//状态C
	public class ConcreteStateC : State
	{
		public ConcreteStateC(Context theContext) : base(theContext) { }

		public override void Handle(int Value)
		{
			Console.WriteLine("ConcreteStateA.Handle");
			if (Value > 30)
				m_Context.SetState(new ConcreteStateA(m_Context));
		}
	}


}
