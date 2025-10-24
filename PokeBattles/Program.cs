// skapa 4 pokemons
Pokemon pok1 = new Pokemon("Tore", 120, 20);
Pokemon pok2 = new Pokemon("Siri", 110, 25);
Pokemon pok3 = new Pokemon("Egil", 180, 10);
Pokemon pok4 = new Pokemon("Gunhild", 80, 30);

Console.WriteLine("PokeBattle(TM)");
Console.WriteLine("---");
Console.WriteLine("Pokemons i turneringen:");
pok1.PrintInfo();
pok2.PrintInfo();
pok3.PrintInfo();
pok4.PrintInfo();

Console.WriteLine();
Console.WriteLine("Tryck på en tange för att börja turneringen...");
Console.ReadLine();

// två semi-final fighter
Battle semiFinal1 = new Battle("Semi-Final 1", pok1, pok2);
Battle semiFinal2 = new Battle("Semi-Final 2", pok3, pok4);

Pokemon semiFinal1Winner = semiFinal1.Start();
Pokemon semiFinal2Winner = semiFinal2.Start();

Battle final = new Battle("Final", semiFinal1Winner, semiFinal2Winner);
final.Start();

// en final fight