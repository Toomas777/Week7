Console.WriteLine("Are You coming or Leaving? (in/out)");
string userChoice = Console.ReadLine();




if (userChoice == "in")
{
    PrintHello();
}
else
{
    PrintGoodBye();
}


static void PrintHello()
{

    Console.WriteLine("Hello world!");
}



static void PrintGoodBye()
{

    Console.WriteLine("See you later, aligator!");
}

