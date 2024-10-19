int sum = 0;

for (int i = 0; i < 10; i++) //nägin i-- varianti, pole vaja teha enda poolt
{
    Console.WriteLine($"i = {i}"); //näeb ausalt parem välja
    Console.WriteLine($"Current total = {sum}");
    sum = sum + i;
}

Console.WriteLine($"Final total is {sum}");