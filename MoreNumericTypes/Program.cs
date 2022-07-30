Console.WriteLine("How many miles did you drive on your trip?");
string strMiles = Console.ReadLine();
int miles = int.Parse(strMiles);

Console.WriteLine("How many gallons of gas did you use?");
string strGallons = Console.ReadLine();
int gallons = int.Parse(strGallons);

int mpg = miles / gallons;
Console.WriteLine("The MPG for the trip was: " + mpg);
