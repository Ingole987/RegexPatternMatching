// See https://aka.ms/new-console-template for more information
using RegexMatching;

Console.WriteLine("Regex Program");

Patterns patterns = new Patterns();
//Console.WriteLine(patterns.validatePinCode("xyz@bridgelabz.com.in.in.in"));
Console.WriteLine(patterns.validateFirstName("Pratik"));
Console.WriteLine(patterns.validateLastName("Ingole"));
Console.WriteLine(patterns.validateEmailId("abc-@yahoo.com"));
Console.WriteLine(patterns.validateEmailId("abc111@abc.com"));
Console.WriteLine(patterns.validateEmailId("abc.100@yahoo.com"));
Console.WriteLine(patterns.validateEmailId("abc-100@abc.net"));
Console.WriteLine(patterns.validateEmailId("abc.100@yahoo.com,"));
Console.WriteLine(patterns.validateEmailId("pratik.ingole98@gmail.com"));
Console.WriteLine(patterns.validatePhoneNumber("7709197897"));
if (patterns.validatePassword("Pass@123"))
{
    Console.Write("Valid");
}
else
    Console.Write("Invalid");
Console.ReadKey();
