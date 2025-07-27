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




Console.ReadKey();
