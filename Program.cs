// Random dice= new Random();
// int roll=dice.Next(1,7);
// Console.WriteLine(roll);




Random num= new Random();
int roll=num.Next();
int roll1=num.Next(100,1000);
int roll2=num.Next(1,7);

Console.WriteLine($"first Random={roll}");
Console.WriteLine($"Sec Random={roll1}");
Console.WriteLine($"Th Random={roll2}");