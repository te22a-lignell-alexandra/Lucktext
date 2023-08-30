// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please type the name of a color:");
String surname = Console.ReadLine();
Console.WriteLine("Please type the name of a piece of furtniture:");
String furniture = Console.ReadLine();
Console.WriteLine("Please type the name of a bodypart:");
String bodypart = Console.ReadLine();
Console.WriteLine("Please type a period of time (Example: one week):");
String time = Console.ReadLine();
Console.WriteLine("Please type your name:");
String name = Console.ReadLine();
Console.WriteLine("");
Console.WriteLine($"Dear Mr. {surname},");
Console.WriteLine("");
Console.WriteLine($"I won't be coming to school today. Yesterday I tripped on a {furniture} and broke my {bodypart}, so as you can probably understand I'll need to take at least {time} off to rest. I'll return as soon as I've healed up.");
Console.WriteLine("");
Console.WriteLine($"Kind regards,");
Console.WriteLine(name);
Console.ReadLine();