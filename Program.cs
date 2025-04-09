double CalculateTriangleArea()
{
    Console.Write("Please enter a base length: ");
    double baseLength = Convert.ToDouble(Console.ReadLine());
    Console.Write("Please enter a height: ");
    double height = Convert.ToDouble(Console.ReadLine());
    return .5 * baseLength * height;
}

double CalculateRectangleArea()
{
    Console.Write("Please enter a length: ");
    double length = Convert.ToDouble(Console.ReadLine());
    Console.Write("Please enter a width: ");
    double width = Convert.ToDouble(Console.ReadLine());
    return length * width;
}

double CalculateSquareArea()
{
    Console.Write("Please enter a side length: ");
    double sideLength = Convert.ToDouble(Console.ReadLine());
    return sideLength * sideLength;
}

// Prints the selection menu
static void PrintMenu()
{
    Console.WriteLine("Please choose an option:");
    Console.WriteLine("\tt: Calculate triangle area");
    Console.WriteLine("\tr: Calculate rectangle area");
    Console.WriteLine("\ts: Calculate square area");
}

// Initialize area variable
double area = 0;
while(true)
{
    // Print menu and get user input
    PrintMenu();
    switch (Console.ReadLine().ToLower())
    {
        case "t":
            area = CalculateTriangleArea();
            break;

        case "r":
            area = CalculateRectangleArea();
            break;

        case "s":
            area = CalculateSquareArea();
            break;
        // Checks for invalid input and goes back to beginning of loop
        default:
            Console.WriteLine("Please enter a valid selection!\n");
            continue;
    }
    Console.WriteLine($"The calculated area is {area}\n");
    Console.WriteLine("Would you like to calculate another area? (y/n)");
    if(Console.ReadLine().ToLower() == "n")
    {
        break;
    }
    Console.WriteLine();
} 