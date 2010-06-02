using System;
using System.Text.RegularExpressions;

namespace console_app.library
{
    public static class StringHelper
    {
        public static bool Validate(this String nameToValidate)
        {
            return Regex.IsMatch(nameToValidate, @"^\D+$");   
        }
    }
}