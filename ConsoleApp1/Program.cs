// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Prueba2
//Honda

if (args.Length > 0)
{
    Console.WriteLine("Arguments passed to the program:");
    foreach (var arg in args)
    {
        Console.WriteLine(arg);
    }
}
else
{
    Console.WriteLine("No arguments were passed to the program.");
}

Console.WriteLine("olas");