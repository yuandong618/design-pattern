﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod {
	public class AddFactory:IFactory {
		public Operation CreateOperation()
		{
			return new AddOperation();
		}
		
	}
}
