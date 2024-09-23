Console.WriteLine("SheiyvaneT miRebuli qula");

int Qula = int.Parse(Console.ReadLine());



if (Qula <= 100 && Qula >= 90 )
{
    Console.WriteLine("Tqveni shedegi: A");
}
else if (Qula <= 89 && Qula >= 80)
{
    Console.WriteLine("Tqveni shedegi: B");
}
else if (Qula <= 79 && Qula >= 70)
{
    Console.WriteLine("Tqveni shedegi: C");
}
else if (Qula <= 69 && Qula >= 60)
{
    Console.WriteLine("Tqveni shedegi: D");
}
else if (Qula <= 59 && Qula >= 00)
{
    Console.WriteLine("Tqveni shedegi: F");
}
else
{
    Console.WriteLine("Tqven sheiyvanet araswori kodi");
}


Console.ReadLine();