// while loop
bool loop23 = true;
while(loop23 == true)
{
    Console.BackgroundColor = ConsoleColor.Black;
    Console.Clear();
    Console.WriteLine("Please enter a number between 10 and 99. To exit type exit");
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
            Console.ReadKey();
            continue;
        }
        if(twentythree==69 || twentythree== 92)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.ReadKey();
            continue;
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.ReadKey();
            continue;
        }
    }
    else{
        Console.WriteLine("Please enter a number or exit");
    }
    
}
// do while loop
bool loop34 = true;

do
{
    
    Console.BackgroundColor = ConsoleColor.Black;
    Console.Clear();
    Console.WriteLine("Chose a number between 10 and 99. Type exit to exit");
    string thirtyfourtext = Console.ReadLine();
    if(thirtyfourtext == "exit")
    {
        loop34 = false;
        Console.WriteLine("thank you for palying");
        break;
    }
    int thirtyfour = Convert.ToInt32(thirtyfourtext);
    if(thirtyfour<10 || thirtyfour>99)
    {
        Console.WriteLine("invalide number");
        continue;
    }
    if(thirtyfour>10 && thirtyfour<99){
        if (thirtyfour== 34 || thirtyfour == 68)
        {
             Console.BackgroundColor = ConsoleColor.Green;
             Console.Clear();
             Console.ReadKey();
             continue;
         }
         else
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.ReadKey();
            continue; 
        }
    }
    else
    {
        Console.WriteLine("Please enter a number or exit");
    }
}while(loop34 == true);

//for loop
 
 for(int exit=1;exit ==1;)
 {
   
    Console.BackgroundColor = ConsoleColor.Black;
    Console.Clear();
    Console.WriteLine("finale count down. please chose a number between 10 and 99. type exit to end program!");
    string thirtythreetext = Console.ReadLine();
    if(thirtythreetext == "exit")
    {
        exit =0;
        Console.WriteLine("thank you for palying");
        break;
    }
    int thirtythree = Convert.ToInt32(thirtythreetext);
    if(thirtythree<10 || thirtythree>99)
    {
        Console.WriteLine("invalide number");
        continue;
    }
    if(thirtythree>10 && thirtythree<99){
        if (thirtythree== 33 || thirtythree == 66 || thirtythree ==99)
        {
             Console.BackgroundColor = ConsoleColor.Green;
             Console.Clear();
             Console.ReadKey();
             continue;
         }

         else
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.ReadKey();
            continue; 
        }
    }
    else
    {
        Console.WriteLine("Please enter a number or exit");
    }
 }