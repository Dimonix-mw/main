﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChargeService.Utility.Models
{
    public class ApiErrorResponse
    {
        public string Message { get; set; }
        public string Details { get; set; }
        public string StackTrace { get; set; }
        public bool IsSuccess { get; set; } = false;
        public int StatusCode { get; set; }
    }
}
