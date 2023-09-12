Console.WriteLine("Enter the first integer");
int first = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second integer");
int second = Convert.ToInt32(Console.ReadLine());

Menu();

Console.WriteLine("Input your choice");
int input = Convert.ToInt32(Console.ReadLine());

static void Menu()
{
    Console.WriteLine("Here are the options: \nAddition (1)\nSubtraction (2)\nMultiplication (3)\nDivision (4)\nExit(5)");
  
}

if (input == 1)
{
    int addition = first + second;
    Console.WriteLine("The Addition of " + first + " and " + second + " is " + addition);
}

if (input == 2)
{
    int subtraction = first - second;
    Console.WriteLine("The Subtraction of " + first + " and " + second + " is " + subtraction);
}

if (input == 3)
{
    int multiplication = first*second;
    Console.WriteLine("The Addition of " + first + " and " + second + " is " + multiplication);
}

if (input == 4)
{
    int division = first / second;
    Console.WriteLine("The Addition of " + first + " and " + second + " is " + division);
}




