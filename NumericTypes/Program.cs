//Calculating area of a rectangle
Console.WriteLine("What is the length of the rectangle in feet?");
string strLength = Console.ReadLine();
int length = int.Parse(strLength);
Console.WriteLine("What is the height of the rectangle?");
string strHeight = Console.ReadLine();
int height = int.Parse(strHeight);
int area = length * height;
Console.WriteLine("The area of your rectangle is " + area);