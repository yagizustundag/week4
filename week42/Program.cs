

Random rnd = new Random();

int MyRandom = rnd.Next(1, 4);
int UserG;

bool LoopActive = true;

int Atemps = 0;

while (LoopActive && (Atemps < 3))
{
    Console.WriteLine("Try to guess the cpu number:");
    UserG = int.Parse(Console.ReadLine());
    Atemps++;

    if (UserG == MyRandom)
    {
        Console.WriteLine("You won!");
        LoopActive = false;
    }
}
Console.WriteLine($"Number of tries: {Atemps}");
Console.WriteLine("Have a nice day!");

