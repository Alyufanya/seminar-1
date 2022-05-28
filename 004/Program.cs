Console.Write("enter your numberA: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("enter your numberB: ");
int numberB = int.Parse(Console.ReadLine());
if (numberA>numberB)
{
    Console.WriteLine("numberA is bigger");
    Console.WriteLine("numberB is less");
}
else if (numberA<numberB)
{
    Console.WriteLine("nummberA is less");
    Console.WriteLine("numberB is bigger");
}
else
{
    Console.WriteLine("numbers are equal");
}