// See https://aka.ms/new-console-template for more information
string[][] lyrics = new string[][]
{

        new string[] {"I'm not going to wait until you're done"},
        new string[] {"Pretending you don't need anyone"},
        new string[] { "I'm standing here naked (naked, naked)" },
        new string[] { "I'm standing here naked (naked, naked)" },
        new string[] { "I'm not going to try 'til you decide" },
        new string[] { "You're ready to swallow all your pride" },
        new string[] { "I'm standing here naked (naked, naked)" },
        new string[] { "I'm standing here naked (naked, naked)" }

};

int[] delay = { 100,110,130,130,115,100,125,125 };
for(int i = 0; i < lyrics.Length; i++)
{

    for(int j = 0; j < lyrics[i].Length; j++)
    {
        foreach(var line in lyrics[i][j])
        {
            Console.Write(line + "");
            Thread.Sleep(delay[i]);
            
        }
    }
    Console.WriteLine();
}