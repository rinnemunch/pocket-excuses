using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var excuseTemplates = new Dictionary<string, List<string>>
        {
            { "school", new List<string>
                {
                    "I couldn’t finish my homework because my {0} exploded.",
                    "I got locked out after chasing my {0} down the street.",
                    "My {0} caught fire while I was writing my essay."
                }
            },
            { "work", new List<string>
                {
                    "I couldn’t make the meeting because my {0} crashed.",
                    "I was late because I rescued a {0} on the freeway.",
                    "My alarm didn’t go off — blame the {0} update."
                }
            },
            { "dating", new List<string>
                {
                    "Sorry I ghosted — my ex kidnapped my {0}.",
                    "I thought today was {0}, not our date day.",
                    "I tripped on a {0} and blacked out. True story."
                }
            }
        };

        string[] wildcards = { "microwave", "printer", "dog", "hamster", "bacon" };

        Random random = new Random();
        var categories = new List<string>(excuseTemplates.Keys);
        string selectedCategory = categories[random.Next(categories.Count)];

        var templates = excuseTemplates[selectedCategory];
        string selectedTemplate = templates[random.Next(templates.Count)];

        string selectedWord = wildcards[random.Next(wildcards.Length)];

        string excuse = string.Format(selectedTemplate, selectedWord);

        Console.WriteLine($"Category: {selectedCategory}");
        Console.WriteLine(excuse);
    }
}
