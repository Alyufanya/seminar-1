// check the square number between two numbers
Console.Write("Enter your numberA: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Enter numberB: ");
int numberB = int.Parse(Console.ReadLine());
if (numberA == numberB*numberB)
{
    Console.Write("yes, its square number of the second number");
}
else
{
    Console.Write("no, its not square number of the second number");
}