Console.WriteLine("Are you coming or leavingg & (in/out)");
string UserChoice = Console.ReadLine();

if(UserChoice == "in")
{
    PrintHello();
}
else
{
    PrintGoodBye();
}


static void PrintHello() //finction//method
{
Console.WriteLine("Hello, world");
}

static void PrintGoodBye()
{
    Console.WriteLine("See you later, aligator");
}