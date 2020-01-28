using System;
using System.Text.RegularExpressions;
/*
NOTE: Points will be awarded for items that are written correctly in themselves but don’t
actually work because other things are broken.There is a total of 10 points available for
this lab.
Task: Write a program that will recognize invalid inputs using regular expressions.
What will the application do?
● The program will validate different kinds of input.
Build Specifications:
● 2 Point: Write a method that will validate names.Names can only have alphabets,
they should start with a capital letter, and they have a maximum length of 30.
● 2 Point: Write a method that will validate emails.An email should be in the
following format: {
combination of alphanumeric characters, with a length between 5
and 30, and there are no special characters}@{combination of alphanumeric
characters, with a length between 5 and 10, and there are no special
characters}.{domain can be a combination of alphanumeric characters with a length
of two or three}
● 2 Point: Write a method that will validate phone numbers.A phone number should
be in the following format: { area code of 3 digits} - {3 digits} - {4 digits}
● 2 Point: Write a method that will validate date based on the following format:
(dd/mm/yyyy)
Additional Requirements:
● 1 Point: For answering Lab Summary when submitting to the LMS
● -2 Points: if there are any syntax errors or if the program does not run(for example,
in a Main method).
Extended Exercises:
● 1 Point: Write a method that validates HTML elements(Example: <p> </p> is a valid
html element, and<h1<h1> is not valid.Don’t worry about special cases where you
have self-contained HTML elements).
Hints:
● Use https://regexr.com/ to try out the regular expressions before adding them to
your C# code.
*/

namespace RegularExpressionsLab
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(NameExpression());
            Console.WriteLine(Emails());
            Console.WriteLine(PhoneNumbers());
            Console.WriteLine(Date());
            
        }

        public static string NameExpression()
        {
             Console.Write("Please enter a valid name: ");
             string name = Console.ReadLine();

            if (Regex.IsMatch(name, @"([A-Z][a-zA-Z]*)"))

            {
                return $"Hello, {name}!";
            }

            else
            {
                return "Sorry, name is not valid.";
            }        
        }

        public static string Emails()
        {
            Console.Write("Please enter an email:");
            string email = Console.ReadLine();

            if (Regex.IsMatch(email, @"^\w{5,30}@[a-zA-Z]{5,10}?\.[a-zA-Z]{2,3}$"))
            {
                return $"The email you entered is valid: {email}";
            }
            else
            {
                return $"The email you entered is invaild.";
            }
        }
        public static string PhoneNumbers ()
        {
            Console.Write("Please enter a valid phone number: ");
             string phoneNumber = Console.ReadLine();

            if (Regex.IsMatch(phoneNumber, @"\d{3}[ -]\d{3}[ -]\d{4}")) 
            
            {
                return $"The phone number you entered is valid: {phoneNumber}";
            }
            
            else
            {
                return $"The phone number you entered is invalid.";
            }
                      
        }

        public static string Date()
        {
            Console.Write("Please enter a valid date: ");
            string date = Console.ReadLine();
            
            if (Regex.IsMatch(date, @"^(0[1 - 9] |[12][0 - 9] | 3[01])[- /.](0[1 - 9] | 1[012])[- /.](19 | 20)\d\d$"))
            
                {
                return $"The date you entered is valid: {date}";
                }

            else
            {
                return $"The date you entered is invalid.";
            }
        }
    }

}
