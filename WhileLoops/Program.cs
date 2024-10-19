

Random random = new Random();

int cpurandom;

bool loopactiv = true;

while (loopactiv)
{
    cpurandom = random.Next(0, 2947);
    Console.WriteLine(cpurandom);
    Console.WriteLine("Guess a number or you're fat:");
    int usenumb = Int32.Parse(Console.ReadLine());

   

    if (usenumb == cpurandom)
    {
        Console.WriteLine("Cool, you actually did it.");
        break;
    }
    else {
        Console.WriteLine("Failed, still fat.");
} }
//kui te kuidagi võidate, ma järeldan et te olete kas pikalt mänginud, koodi muutnud või vaatasite numbrit. Iga nendest valikustest on halb.
