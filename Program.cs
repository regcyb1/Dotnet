// Random dice= new Random();
// int roll=dice.Next(1,7);
// Console.WriteLine(roll);




// Random num= new Random();
// int roll=num.Next();
// int roll1=num.Next(100,1000);
// int roll2=num.Next(1,7);

// Console.WriteLine($"first Random={roll}");
// Console.WriteLine($"Sec Random={roll1}");
// Console.WriteLine($"Th Random={roll2}");

Random dice =new Random();
int roll1=dice.Next(1,6);
int roll2=dice.Next(1,6);
int roll3=dice.Next(1,6);

int total=roll1+roll2+roll3;

if (total>9){
    Console.WriteLine("you Win");

}
if (total<8){
    Console.WriteLine("you lose");
}
