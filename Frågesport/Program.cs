// Generell info //
int points = 0;
Console.WriteLine(@"
    \_/
  --(_)--  .
    / \   /_\
          |Q|
    .-----' '-----.
   /____[SCHOOL]___\
    | [] .-.-. [] |
  ..|____|_|_|____|");

Console.WriteLine("Välkommen till Smartare Än En Femte Klassare!");

// Fråga 1 //
Console.WriteLine("");
Console.WriteLine("Vad heter Europas längsta flod?");
Console.WriteLine("a) Volga  b) Donau  c) Rhen  d)  Elbe");
string svar1 = Console.ReadLine();
if (svar1 =="a")
{
    points++;
    Console.WriteLine("Det stämmer!");
}
else
{
    Console.WriteLine("Aj, där stämde det inte riktigt");
}

// Fråga 2 //
Console.WriteLine("");
Console.WriteLine(@"            -.            .      .-.
                     '       /      / ./
              _  __,     .--'      / <
             ~_-~ /     <         <   \_ .-~7
           _. \   >      \.-'\     >`   ~ .-~
          <  ><  /         ,  7   <      ~7
          /_/  ! \       .-L  \  _//   <'~
          ~  .-~  !      ! /o& `' .     7
             _>_._ >  _.-' '-._.-._.--./
            '-~   ~._/                                                .'
              ,-.-'                                                .-~<
             <                                                  __/    > -'
              \                                               -~ ___--/
               7                                ..   .       /_//     \__
               !       _.-.     ..             <  ~v~       '            \
        .-~---'   .-.-~    ~\  <  \            /            |          __/
        )         >      o  <   >  \           \_.--._      |O        |    .__,--_
       /       .-'      <>   \  \   7       .  '            )        / d  . _>   /.
       7       > . - '        > _\  !   _,-' `.             \       /.._  .)    <
       ~--,.--'           ._ /.- ~` <   \ .   \              `     |<   \  `-.__/
                          7/ ~       \.,< .  ` `-~-.-~       |    /  \__//.--...<|
                                        __  . `              '-.__\\  - ' '--~|/");
Console.WriteLine("Hur många stjärnor finns i EU-flaggan?");
Console.WriteLine("a) 18  b) 16  c) 14  d) 12");
string svar2 = Console.ReadLine();
if (svar2 =="d")
{
    points++;
    Console.WriteLine("Det stämmer!");
}
else
{
    Console.WriteLine("Aj, där stämde det inte riktigt");
}

// Fråga 3 //
Console.WriteLine("");
Console.WriteLine(@".__                __               __  .__.__  .__   
|  | ___.__. ____ |  | _______    _/  |_|__|  | |  |  
|  |<   |  |/ ___\|  |/ /\__  \   \   __\  |  | |  |  
|  |_\___  \  \___|    <  / __ \_  |  | |  |  |_|  |__
|____/ ____|\___  >__|_ \(____  /  |__| |__|____/____/
     \/         \/     \/     \/                      ");
Console.WriteLine("Vilket av dessa ord är en preposition?");
Console.WriteLine("a) Som  b) Ska  c) På  d) Eller");
string svar3 = Console.ReadLine();
if (svar3 =="c")
{
    points++;
    Console.WriteLine("Det stämmer!");
}
else
{
    Console.WriteLine("Aj, där stämde det inte riktigt");
}

// Avslutning //
Console.WriteLine("");
Console.WriteLine(@"
     
                                   `,
                                ___ #
                                |/  ?
                                 | , )\
                                /__/\ \____              
                           ,-   /   \_/    \           
                         |/|   / < _____ _> \          
                        -|.|--/___/  ,___/___\-        
                    _____'-'______|\/______________    
                   [_______________________________]    
                    |                             | 
                    |         ,-'      '-_        |
                    |        /            \       |
                    |       |              .      |
                    |       | / / \| ||_)| |      |
                    |        \\_\_/|_|| \|/       |
                    |         -_        ,-        |
                    |           `-...,-'          |
                    |                             |
                    |_____________________________||");
Console.WriteLine("");
Console.WriteLine($"Du lyckades få {points} poäng.");
if (points == 0)
{
    Console.WriteLine("Seriöst? Jag förväntade mig mer.");
}
else if (points < 3)
{
    Console.WriteLine("Du är INTE smartare än en femte klassare, adjö");
}
else
{
    Console.WriteLine("Du är SMARTARE än en femte klassare, bravo!");
}

Console.WriteLine("Tryck ENTER för avsluta.");
Console.ReadKey();