﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uc1anduc5CalculatingFare
{
    public class CustomException : Exception
    {
        public ExceptionType type;
        public string message;

        public enum ExceptionType
        {
            INVALID_DISTANCE, INVALID_TIME
        }
        public CustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
