Console.WriteLine("Game Gallows\nHave fun! And take care of your neck!");
Console.WriteLine("The task is to guess the word. You have 5 lifes.");

Random rnd = new Random();

string[] words = { "antonym", "deference", "erudite", "formative", "holistic", "irony", "jargon",
            "metaphor", "nemesis", "obtuse", "pedagogy", "simile", "virtual" };
sbyte i = Convert.ToSByte(rnd.Next(words.Length)), kilm = 0, life = 5;
List<string> zs = new List<string>();

while (true)
{
    if (life == 0)
    {
        Console.WriteLine($"You lose! The word was {words[i]}");
        Console.ReadKey();
        break;
    }

    Console.Write("Guess a letter: ");
    string playerGuess = Console.ReadLine().ToLower();
    Console.Write("\n");

    if (playerGuess == Convert.ToString(words[i]))
    {
        Console.WriteLine("Congratulations! You are win!");
        Console.ReadKey();
        break;
    }

    if (words[i].Contains(playerGuess[0].ToString()) & !zs.Contains(playerGuess[0].ToString()))
    {
        for (byte j = 0; j < words.Length; j++)
            if (words[j] == playerGuess[0].ToString())
                kilm++;
        Console.WriteLine($"This letter {playerGuess[0]} in the word");
        zs.Add(playerGuess[0].ToString());
    }

    else
    {
        life--;
        Console.WriteLine($"You have {life} attempts");
    }
}