using System; 


class Program
{
    static void Main(string[] args)
    {
        string template = "I couldn't finish my homework because my {0} exploded";

        string wildcard = "microwave";

        string excuse = string.Format(template, wildcard);


        //Output 
        Console.WriteLine("Generated Excuse:");
        Console.WriteLine(excuse);
    }
}