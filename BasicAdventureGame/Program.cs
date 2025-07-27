//Creiamo un piccolo gioco di ruolo in console
using System.Reflection.Metadata;
Random random = new Random();

Console.WriteLine("Avvio del gioco...\n");
Thread.Sleep(1000);
Console.WriteLine("Inserisci il tuo nome: \n");
string userName = Console.ReadLine();
Console.WriteLine($"\nBenvenuto nel gico {userName}, scegli la tua classe tra Guerriro, Arciere, Mago, Curatore.\n");
string userClass = Console.ReadLine().ToLower().Trim();

while (userClass != "guerriero" && userClass != "arciere" && userClass != "mago" && userClass != "curatore")
{
    Console.WriteLine("\nScegli una tra le classi disponibili...\n");
    userClass = Console.ReadLine().ToLower().Trim();
};
//Inizializziamo il loop del gioco
bool masterLoop = true;
while (masterLoop)
{
    string replayChoice = "";

    Console.WriteLine($"\nE` da tanto tempo che Narzelot aspettava un prode {userClass} come te {userName}... \nTi ritrovi in una foresta buia e hai 2 strade davanti a te... \nCosa sceglierai?\n \n(Destra / Sinistra)\n");
    string choice1 = Console.ReadLine().ToLower().Trim();
    //verifico che la scelta sia giusta
    while (choice1 != "destra" && choice1 != "sinistra")
    {
        Console.WriteLine("\nScegli Destra o Sinistra\n");
        choice1 = Console.ReadLine().ToLower().Trim();
    }

    if (choice1 == "destra")
    {
        Console.WriteLine("\nHai scelto di proseguire a Destra e ti sei imbattuto in un lupo mannaro... \nLa bestia non ti ha ancora visto... Cosa deciderai di fare?\n \n(Scappa / Combatti)\n");
        string choice2 = Console.ReadLine().ToLower().Trim();
        while (choice2 != "scappa" && choice2 != "combatti")
        {
            Console.WriteLine("\nScegli Scappa o Combatti\n");
            choice2 = Console.ReadLine().ToLower().Trim();
        }
        if (choice2 == "scappa")
        {
            Console.WriteLine("\nHai cercato di sfuggire invano...\nIl fiuto della bestia ha percepito il tuo odore e non hai potuto fare nulla...\nCon un salto rapido ti ha raggiunto e ti ha staccato la testa...\n");
            masterLoop = AskReplay();


        }
        if (choice2 == "combatti")
        {
            Console.WriteLine("\nPur sapendo che non hai possibilità contro il lupo mannaro hai comunque scelto di combattere?\nDavvero corraggioso da parte tua...\n" +
                "O magari non vedi l'ora di morire e di lasciare questo mondo?" +
                "\n");
            int luck = random.Next(1, 101);
            if (luck >= 90)
            {
                Console.WriteLine("Gli Dei ti amano... Una scarica arcana apre il cielo polverizzando la bestia e donandoti un aumento di tutte le statistiche permanente...");
                Console.ReadKey();
            }
            else if (luck >= 70)
            {
                Console.WriteLine("Per pura fortuna sei riuscito a sconfiggere la bestia senza nemmeno ferirti...");
                Console.ReadKey();
            }
            else if (luck >= 40)
            {
                Console.WriteLine("Sei riuscito ad uccidere la bestia non senza aver subito ingenti danni...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Purtroppo la bestia ha avuto la meglio e ti ha ucciso... ");
                masterLoop = AskReplay();
            }
        }

    }
    else if (choice1 == "sinistra")
    {
        Console.WriteLine("\nIn Sviluppo...\n");
        masterLoop = AskReplay();
    }



   
}

static bool AskReplay()
{
    Thread.Sleep(2000);
    Console.WriteLine("\nGame Over\nVuoi riprovare?\n(Si / No)\n");

    string replayChoice = Console.ReadLine().ToLower().Trim();

    if (replayChoice == "no")
    {
        return false;
    }

    return true;
}
    ;

Console.ReadKey();
