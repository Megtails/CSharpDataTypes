string firstLine = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";

Console.WriteLine(firstLine);
Console.WriteLine("What sentence would you like to look for in the sentence above?");
string searchTerm = Console.ReadLine();
string comparisonSearchTerm = searchTerm.ToLower();
string comparisonFirstLine = firstLine.ToLower();

int index = comparisonFirstLine.IndexOf(comparisonSearchTerm, 0);
int lengthSearchTerm = searchTerm.Length;
string newLine = firstLine.Remove(index, lengthSearchTerm);

if (index != -1) {
    Console.WriteLine("true");
    Console.WriteLine("Found at index: " + index);
    Console.WriteLine("It is " + lengthSearchTerm + " characters long.");
    Console.WriteLine(newLine);
}
else {
    Console.WriteLine("Not found.");
}