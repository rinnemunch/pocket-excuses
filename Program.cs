using System; 


class Program
{
    static void Main(string[] args)
    {
        string template = "I couldn't finish my homework because my {0} exploded";

        string[] wildcards = { "microwave", "printer", "dog", "hamster", "bacon" };

        Random random = new Random();
        int index = random.Next(wildcards.Length);
        string selectedWord = wildcards[index]; 

        string excuse = string.Format(template, selectedWord);


        //Output 
        Console.WriteLine("Generated Excuse:");
        Console.WriteLine(excuse);
    }
}