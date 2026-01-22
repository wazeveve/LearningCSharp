Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");
Console.WriteLine("Hello \"World\"!");
Console.WriteLine("c:\\source\\repos");
Console.WriteLine(@"   c:\source\repos
            (this is where your code goes)");

Console.WriteLine("\n\nGenerating invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021 \t\tComplete!");
Console.WriteLine("Invoice: 1022 \t\tComplete!");
Console.Write("\nOutput Directory:\t");
Console.Write(@"c:\invoices");

Console.WriteLine("\n\u3053\u3093\u306B\u3061 World!");

// Combine Strings using String Concatenation


string firstName = "Bob";
string greeting = "Hello";
Console.WriteLine(greeting + " " + firstName + "!");

// Combine Strings using String interpolation

Console.WriteLine($"Hello {firstName}!");

int version = 11;
string updateText = "Update to Windows"; 
Console.WriteLine($"{updateText} {version}");

string projectName1 = "First-Project";
Console.WriteLine($@"C:\Output\{projectName1}\Data");

// Challenge

string projectName = "ACME";

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";


Console.WriteLine($"View English Output: \n\tc:\\Exercise\\{projectName}\\data.txt");

Console.Write($@"{russianMessage}:
    c:\Exercise\ACME\ru-RU\data.txt");