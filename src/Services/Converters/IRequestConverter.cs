﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Services.Models;

namespace Services.Converters
{
	public interface IRequestConverter
    {
	    string CreateMessage(Request request);
    }
}
