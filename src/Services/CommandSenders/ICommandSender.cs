﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.CommandSenders
{
	public interface ICommandSender
	{
		Task SendCommandAsync(string message);
		Task SendSignedRequestAsync(string message);
	}
}
