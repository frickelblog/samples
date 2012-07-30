using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThreadTest
{
	// Der Delegat für den Event
	public delegate void OnFakeThreadHandler();

	class FakeThread
	{
		public FakeThread()
		{

		}

		// Der Event an sich
		public OnFakeThreadHandler Event_OnFakeThread;
		
		public void test()
		{ 
			// In der methode will ich einen Timer laufen lassen, der jede Sekunde  die GUI Akualisiert
			for (int i = 0; i < 10; i++)
			{
				if (this.Event_OnFakeThread != null)
				{
					this.Event_OnFakeThread.Invoke();
				}
				System.Threading.Thread.Sleep(1000);			
			}
		}
	}
}
