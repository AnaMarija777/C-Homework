// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region For Loops
 for (int i = 0; i<= 10; i++)
{
    Console.WriteLine(i);
}
Console.ReadLine();

//for (; ;  )
//{
//    Console.WriteLine("Infinity for loop");
//}

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine("Army:" + i);
    if (i == 5)
    {
        Console.WriteLine("Problem with army:" + i);
        continue;
    }
    if (i == 7)
    {
        Console.WriteLine("Army is broke down1");
        break;
    }

    Console.WriteLine("Army army test");


}
#endregion
#region While loop
Console.WriteLine("======== While loop ========");
int counter = 0;

while (counter <= 10)
{
    Console.WriteLine(counter);
    counter++;
}
while (true)
{
    Console.WriteLine("Infinity while loop");
    string input = Console.ReadLine();
    if (input == "lis") continue;
    Console.WriteLine("win win win");
    if (input == "X" || input == "x") break;
}
#endregion
//#region Do While loop //ne se koristi

//int doWhileCounter = 11;
//do
//{
//    Console.WriteLine(doWhileCounter);
//    doWhileCounter++;

//}
//while (doWhileCounter <= 10);
//#endregion