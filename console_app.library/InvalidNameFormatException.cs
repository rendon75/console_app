using System;

namespace console_app.library
{
    public class InvalidNameFormatException : Exception
    {
        public InvalidNameFormatException(string message) : base(message){}
    }
}
