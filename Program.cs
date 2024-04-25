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

// Random dice =new Random();
// int roll1=dice.Next(1,6);
// int roll2=dice.Next(1,6);
// int roll3=dice.Next(1,6);

// int total=roll1+roll2+roll3;

// if (total>9){
//     Console.WriteLine("you Win");

// }
// if (total<8){
//     Console.WriteLine("you lose");
// }


// Random dice=new Random();
// int roll1=dice.Next(1,6);
// int roll2=dice.Next(1,6);
// int roll3=dice.Next(1,6);

// int total=roll1 + roll2 + roll3;
// Console.WriteLine($"DiceRoll: {roll1}+{roll2}+{roll3}={total}");

// if((roll1==roll2)||(roll2==roll3)||(roll1==roll3)){
//     Console.WriteLine("You rolled a Double! Total+2");
//     total+=2;
// }
// if((roll1==roll2)&&(roll2==roll3)){
//     Console.WriteLine("Your rolled  three of the same number +6 Bonus");
//     total+=6;
// }
// if (total >= 15){
//     Console.WriteLine("You Win");
// }else{
//     Console.WriteLine("You lose");
//}

int[] inventory = { 200, 450, 700, 175, 250 };
int sum=0;
int bin=0;
foreach(int value in inventory){
    sum+= value;
    bin++;
    Console.WriteLine($"Bin {bin} = {value} items (Running total: {sum})");
}
Console.Write($"The Inventory Sum is {sum}\n");