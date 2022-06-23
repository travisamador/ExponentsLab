Console.WriteLine("Welcome to the exponents program!");
while (true)
{
    //ask user for integer
    Console.WriteLine("Please enter a positive integer from 1 to 1290.");
    int input = int.Parse(Console.ReadLine());
    //reject zeros and negatives
    if (input < 1 || input > 1290)
    {
        Console.WriteLine("Unaccepted input");
        continue;
    }
    //display table of squares and cubes aligned right
    Console.WriteLine(string.Format("{0, 9}{1, 9}{2, 9}", "Number\t","Squared\t","Cubed"));
    Console.WriteLine(string.Format("{0, 9}{1, 9}{2, 9}", "=======\t","=======\t","======"));
    for (int i = 1; i <= input; i++)
    {
        Console.WriteLine(string.Format("{0, 9}{1, 9}{2, 9}", $"{i}\t", $"{getSquare(i)}\t", $"{getCube(i)}"));
    }
    //ask if user wants to continue 
    Console.WriteLine();
    Console.WriteLine("Continue? (yes/y, anything else to exit)");
    string exit = Console.ReadLine();
    if (exit.ToLower().Trim() != "yes" && exit.ToLower().Trim() != "y")
    {
        break;
    }
    else
    {
        Console.WriteLine();
    }
}
//make methods getSquare and getCube
static double getSquare(int num)
{
    return Math.Pow(num, 2);
}
static double getCube(int num)
{
    return Math.Pow(num, 3);
}