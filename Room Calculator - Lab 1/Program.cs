// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to John's Room Detail Generator!");

Console.Write("Enter Length: ");
double Length = double.Parse(Console.ReadLine());
Console.Write("Enter Width: ");
double Width = double.Parse(Console.ReadLine());
Console.Write("Enter Height: ");
double Height = double.Parse(Console.ReadLine());
double Perimeter = Length * 2 + Width * 2;
double Area = Length * Width;
double Volume = Length * Width * Height;
double SurfaceArea = 2 * Length + 2 * Width + 2 * Height;

if (Area <= 250)
{
    Console.WriteLine("This room is small.");
}
else if (Area < 650)
{
    Console.WriteLine("This room is medium.");
}
else
{
    Console.WriteLine("This room is large.");
}


Console.WriteLine("The perimeter is " + Perimeter);
Console.WriteLine("The area is " + Area);
Console.WriteLine("The volume is " + Volume);
Console.WriteLine("The surface area is " + SurfaceArea);

Console.WriteLine("Thank you for using the Room Detail Generator!");
Console.ReadLine();
