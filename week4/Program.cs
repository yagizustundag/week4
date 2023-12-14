//for(int i = 0; i < 3; i++)
//{
//    Console.WriteLine($"{i + 1}. I will not skip Zoom classes.");
//}

Random rnd = new Random();

int MyRandom;

for (int i = 0; i < 5; i++)
{
    MyRandom = rnd.Next(1, 11);
    Console.WriteLine($"{i}. {MyRandom}");
}
