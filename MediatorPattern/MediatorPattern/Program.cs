using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			var cm = new ConcreteMediator();
			var c1 = new ConcreateColleague1(cm);
			var c2 = new ConcreateColleague2(cm);

			cm.SetColleague1(c1);
			cm.SetColleague2(c2);
			c1.Action();
			c2.Action();
			Console.ReadKey();
		}
	}

	public abstract class Mediator
	{
		public abstract void SendMessage(Colleague theColleague, string Message);
	}

	public abstract class Colleague
	{
		protected Mediator m_Mediator = null;

		public Colleague(Mediator theMediator)
		{
			m_Mediator = theMediator;
		}

		public abstract void Request(string Message);
	}

	public class ConcreateColleague1 : Colleague
	{
		public ConcreateColleague1(Mediator theMediator) : base(theMediator) { }

		public void Action()
		{
			m_Mediator.SendMessage(this, "Colleage1发出通知");
		}

		public override void Request(string Message)
		{
			Console.WriteLine("ConcreateColleague1.Request:" + Message);
		}
	}

	public class ConcreateColleague2 : Colleague
	{
		public ConcreateColleague2(Mediator theMediator) : base(theMediator) { }

		public void Action()
		{
			m_Mediator.SendMessage(this, "Colleage2发出通知");
		}

		public override void Request(string Message)
		{
			Console.WriteLine("ConcreateColleague2.Request:" + Message);
		}
	}

	public class ConcreteMediator : Mediator
	{
		ConcreateColleague1 m_Colleague1 = null;
		ConcreateColleague2 m_Colleague2 = null;

		public void SetColleague1(ConcreateColleague1 theColleague)
		{
			m_Colleague1 = theColleague;
		}

		public void SetColleague2(ConcreateColleague2 theColleague)
		{
			m_Colleague2 = theColleague;
		}

		public override void SendMessage(Colleague theColleague, string Message)
		{
			if (m_Colleague1 == theColleague)
				m_Colleague2.Request(Message);

			if (m_Colleague2 == theColleague)
				m_Colleague1.Request(Message);
		}
	}
}