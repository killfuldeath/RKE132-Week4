Random rnd = new Random();

//int myrandomnum = rnd.Next(0, 11); 
//Console.WriteLine(myrandomnum);

int rnda;

int kokku = 0;


for (int i = 0; i < 3; i++)
{
    rnda = rnd.Next(0, 11);
    kokku = kokku + rnda;
    Console.WriteLine(rnda);
}

Console.WriteLine($"kokku on need {kokku}");