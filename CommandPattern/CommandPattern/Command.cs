﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern {
	public abstract class Command
	{
		protected Receiver receiver;

		public Command(Receiver receiver)
		{
			this.receiver = receiver;
		}

		abstract public void Execute();
	}
}
