

using ConsoleUI;

PersonModel person = new PersonModel();

person.FirstName = "Justin";
//person.LastName = "Spencer";
person.SSN = "123-45-6789";

Console.WriteLine(person.FullName);
Console.WriteLine(person.SSN);

Console.ReadLine();