﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrueRPG
{
	public interface IObject
	{
		CollideResult Collide(IGuy otherObject);
	}

}
