// skapa 4 pokemons
Pokemon pok1 = new Pokemon("Tore");
pok1.health = 120;

Pokemon pok2 = new Pokemon("Siri");
pok2.damage = 25;

Pokemon pok3 = new Pokemon("Rouge");
pok3.health = 80;
pok3.damage = 30;

Pokemon pok4 = new Pokemon("Tank");
pok4.health = 200;
pok4.damage = 10;


// två semi-final fighter
Battle semiFinal1 = new Battle("Semi-Final 1", pok1, pok2);
Battle semiFinal2 = new Battle("Semi-Final 2", pok3, pok4);

Pokemon semiFinal1Winner = semiFinal1.Start();
Pokemon semiFinal2Winner = semiFinal2.Start();

Battle final = new Battle("Final", semiFinal1Winner, semiFinal1Winner);
final.Start();

// en final fight