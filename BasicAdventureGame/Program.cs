//Creiamo un piccolo gioco di ruolo in console
using System.Reflection.Metadata;

Console.WriteLine("Avvio del gioco...");
Thread.Sleep(1000);
Console.WriteLine("Inserisci il tuo nome: ");
string userName = Console.ReadLine();
Console.WriteLine($"\nBenvenuto nel gico {userName}, scegli la tua classe tra Guerriro, Arciere, Mago, Curatore.");
string userClass = Console.ReadLine();
Console.WriteLine($"\nE` da tanto tempo che Narzelot aspettava un prode {userClass} come te {userName}... \nTi ritrovi in una foresta buia e hai 2 strade davanti a te... \nCosa sceglierai? (Destra / Sinistra)");
string choice1 = Console.ReadLine().ToLower();
//verifico che la scelta sia giusta
do
{
    Console.WriteLine("Scegli Destra o Sinistra");
    choice1 = Console.ReadLine().ToLower();
} while (choice1 != "destra" && choice1 != "sinistra");

if(choice1 == "right")
{
    Console.WriteLine("Hai scelto di proseguire a Destra e ti sei imbattuto in un lupo mannaro... \n La bestia non ti ha ancora visto... Cosa deciderai di fare? (Scappa / Combatti)");
    string choice2 = Console.ReadLine().ToLower();
    do
    {
        Console.WriteLine("Scegli Scappa o Combatti");
        choice2 = Console.ReadLine().ToLower();
    } while (choice2 != "scappa" && choice2 != "combatti");

}




Console.ReadKey();
