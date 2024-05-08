using System;
using ContactLibrary;

class Program1
{
    static void Main(string[] args)
    {
        string name = "John Doe";
        string age = "25";
        string phone = "1234567890";
        string email = "john.doe@example.com";

        Console.WriteLine($"Name validation result: {ContactValidator.ValidateName(name)}");
        Console.WriteLine($"Age validation result: {ContactValidator.ValidateAge(age)}");
        Console.WriteLine($"Phone validation result: {ContactValidator.ValidatePhone(phone)}");
        Console.WriteLine($"Email validation result: {ContactValidator.ValidateEmail(email)}");
    }
}
