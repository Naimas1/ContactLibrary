using System;
using System.Text.RegularExpressions;

namespace ContactLibrary
{
    public static class ContactValidator
    {
        public static bool ValidateName(string name)
        {
            return Regex.IsMatch(name, @"^[a-zA-Z\s]+$");
        }

        public static bool ValidateAge(string age)
        {
            return Regex.IsMatch(age, @"^\d+$");
        }

        public static bool ValidatePhone(string phone)
        {
            return Regex.IsMatch(phone, @"^\d{10}$");
        }

        public static bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
    }
}
