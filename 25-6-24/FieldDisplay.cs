class CSharp
{
    public string DisplayText = "C#";

    public void PrintText()
    {
        Console.WriteLine(DisplayText);
    }
}

class Programming
{
    public string DisplayText = "programming";

    public void PrintText()
    {
        Console.WriteLine(DisplayText);
    }
}

class MainClass
{
    public static void Main(string[] args)
    {
        CSharp cSharpObject = new CSharp();
        Programming programmingObject = new Programming();

        cSharpObject.PrintText();  // Prints "C#"
        programmingObject.PrintText();  // Prints "programming"

        // Combine the strings (optional)
        Console.WriteLine($"{cSharpObject.DisplayText} {programmingObject.DisplayText}");  // Prints "C# programming"
    }
}
