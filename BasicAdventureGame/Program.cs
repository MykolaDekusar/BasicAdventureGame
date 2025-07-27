//Creiamo un piccolo gioco di ruolo in console
using System.Reflection.Metadata;

Console.WriteLine("Avvio del gioco...");
Thread.Sleep(1000);
Console.WriteLine("Inserisci il tuo nome: ");
string userName = Console.ReadLine();
Console.WriteLine($"\nBenvenuto nel gico {userName}, scegli la tua classe tra Guerriro, Arciere, Mago, Curatore.");
string userClass = Console.ReadLine().ToLower().Trim();

while (userClass != "guerriero" && userClass != "arciere" && userClass != "mago" && userClass != "curatore")
{
    Console.WriteLine("Scegli una tra le classi disponibili...");
    userClass = Console.ReadLine().ToLower().Trim();
};
//Inizializziamo il loop del gioco

Console.WriteLine($"\nE` da tanto tempo che Narzelot aspettava un prode {userClass} come te {userName}... \nTi ritrovi in una foresta buia e hai 2 strade davanti a te... \nCosa sceglierai? \n(Destra / Sinistra)");
string choice1 = Console.ReadLine().ToLower().Trim();
//verifico che la scelta sia giusta
while (choice1 != "destra" && choice1 != "sinistra"){
    Console.WriteLine("\nScegli Destra o Sinistra");
    choice1 = Console.ReadLine().ToLower().Trim();
}

if(choice1 == "destra")
{
    Console.WriteLine("\nHai scelto di proseguire a Destra e ti sei imbattuto in un lupo mannaro... \nLa bestia non ti ha ancora visto... Cosa deciderai di fare? \n(Scappa / Combatti)");
    string choice2 = Console.ReadLine().ToLower().Trim();
    while (choice2 != "scappa" && choice2 != "combatti"){
        Console.WriteLine("\nScegli Scappa o Combatti");
        choice2 = Console.ReadLine().ToLower().Trim();
    }
    if(choice2 == "scappa")
    {
        Console.WriteLine("\nHai cercato di sfuggire invano...\nIl fiuto della bestia ha percepito il tuo odore e non hai potuto fare nulla...\nCon un salto rapido ti ha raggiunto e ti ha staccato la testa...\n");
        Thread.Sleep(3000);
        Console.WriteLine("\nGame Over");
        return;
    }
    if(choice2 == "combatti")
    {
        Console.WriteLine("\nPur sapendo che non hai possibilità contro il lupo mannaro hai comunque scelto di combattere?\n Davvero corraggioso da parte tua..." +
            "\nO magari non vedi l'ora di morire e di lasciare questo mondo?" +
            "\n");
    }

}else if (choice1 == "sinistra")
{
    Console.WriteLine("In Sviluppo...");
}





    Console.ReadKey();
