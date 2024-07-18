using System;

public class CSharp
{
    public string DisplayText { get; private set; }

    public CSharp()
    {
        DisplayText = "C#";
    }

    public void PrintText()
    {
        Console.WriteLine(DisplayText);
    }
}

public class Programming
{
    public string DisplayText { get; private set; }

    public Programming()
    {
        DisplayText = "programming";
    }

    public void PrintText()
    {
        Console.WriteLine(DisplayText);
    }
}

public class MainClass
{
    public static void Main(string[] args)
    {
        CSharp cSharpObject = new CSharp();
        Programming programmingObject = new Programming();

        cSharpObject.PrintText();         // Prints "C#"
        programmingObject.PrintText();    // Prints "programming"

        // Combine the strings (optional)
        string combinedText = cSharpObject.DisplayText + " " + programmingObject.DisplayText;
        Console.WriteLine(combinedText);  // Prints "C# programming"
    }
}
