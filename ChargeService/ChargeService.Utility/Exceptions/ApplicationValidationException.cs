﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChargeService.Utility.Exceptions
{
    public class ApplicationValidationException : Exception
    {
        public ApplicationValidationException(string message) : base(message)
        {
        }
    }
}
