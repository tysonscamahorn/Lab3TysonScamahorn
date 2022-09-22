// while loop
bool loop23 = true;
while(loop23 == true)
{
    Console.WriteLine("Please enter a number between 10 and 99");
    string twentythreetext = (Console.ReadLine());
    if(twentythreetext == "exit")
    {
        loop23 = false;
        Console.WriteLine("thank you for playing");
        break;
    }
    int twentythree =Convert.ToInt32(twentythreetext);
    if(twentythree<10 || twentythree>99)
    {
        Console.WriteLine("invalide number");
        continue;
    }
    if(twentythree>=10 && twentythree<=99)
    {
        if(twentythree==23 || twentythree == 46)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();
            continue;
        }
        if(twentythree==69 || twentythree== 92)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();
            continue;
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            continue;
        }
    }
    
}
// do while loop
bool loop34 = true;
do
{

}while(loop34 == true);