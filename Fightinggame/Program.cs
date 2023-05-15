// En till (egen) loop
// En egen metod
// En lista eller array

// olika attacker
// crittar
// Random crit = new Random();
// int RandomNumber = random.Next(1, 101);
// if (RandomNumber <= 5)
// {
//     Console.WriteLine("du crittade, din motståndare har tagit 25% mer skada, vilken tur!);


//        damageA = (int)damageA(*1.5f);
//}


// vapen:
// Console.WriteLine($"{Spelare1}Välj ditt vapen: Händer eller paraply");
// string vapen1 = Console.ReadLine();
// if (vapen1 == "paraply"){

//     damageA = (int)(damageA * 1.35f);

// }
// else if{
// Console.WriteLine("tror du skrev fel, testa igen");
// goto vapen;
// }





Random generator = new Random();

Console.WriteLine("välkommen till slagsmålsspelet");
Console.WriteLine("välj vad din slagskämpe ska heta");

Console.WriteLine("namn 1 är James, namn 2 är Åsa, Namn 3 är Alex");
Console.WriteLine("skriv 0, 1 eller 2 för namnet du vill ha");

List<string> spelare1lista = new List <string> () {"James", "Åsa", "Alex"};


string spelare1namn;
int siffra1;

string input = Console.ReadLine();
int.TryParse(input, out siffra1);
spelare1namn = spelare1lista[siffra1];


Console.WriteLine("välj vad motståndarens slagskämpe ska heta");

Console.WriteLine("namn 1 är James, namn 2 är Micke, Namn 3 är Namn");
Console.WriteLine("skriv 0, 1 eller 2 för namnet du vill ha");

List<string> spelare2lista = new List <string> () {"James", "Micke", "Namn"};

string spelare2 = spelare2lista[0];


float hpA = 100;
float hpB = 100;
if (spelare1namn == spelare1lista[0])
{
    Console.WriteLine("det är ett fint namn, du har blivit belönad med 100 extra hp");
    hpA = 200;
}
if (spelare2 == spelare2lista[0])
{
    Console.WriteLine("det är ett fint namn, din motståndare har tyvärr blivit belönad med 100 extra hp, lycka till");
    hpB = 200;
}

while (hpA >= 0 && hpB >= 0)
{

    Console.WriteLine($"din slagskämpe {spelare1namn} lever (hp: {hpA})");
    Console.WriteLine($"din motståndare {spelare2} lever (hp: {hpB})");


    if (hpA == 0 && hpB == 0)
    {
        Console.WriteLine("det blev oavgjort");
    }

    // B slår A
    int damageB = generator.Next(26);



    hpA = hpA - damageB;
    if (hpA < 0)
    {
        hpA = 0;
        Console.WriteLine($"{spelare2} vann, grattis!");
    }
    Console.WriteLine($"du tog {damageB} skada");
    Console.WriteLine($"Du har nu {hpA} hp kvar");
    // A slår B
    float damageA = generator.Next(26);

    Random crit = new Random();

    Console.WriteLine($"{spelare1namn} Välj ditt vapen: Händer eller paraply");


    string vapen1 = Console.ReadLine();
    damageA = Vapen(vapen1, damageA);

   

    int RandomNumbr = generator.Next(1, 101);
    if (RandomNumbr <= 100)
    {
        Console.WriteLine("du crittade, din motståndare har tagit 25% mer skada, vilken tur!");

        damageA = (int)(damageA * 1.25f);
    }
        
    hpB = hpB - damageA;
    if (hpB < 0)
    {
        hpB = 0;
        
        Console.WriteLine($"{spelare1namn} vann, grattis!");
    }
    Console.WriteLine($"{spelare2} tog {damageA} skada");
    Console.WriteLine($"{spelare2} har nu {hpB} hp kvar");

    Console.ReadLine();
}




Console.ReadLine();






// Random generator = new Random();

// int result = generator.Next(5);


// Console.WriteLine(result);

// int hp = 5;


// while (hp > 0)
// {
//     Console.WriteLine("still alive");
//     Console.WriteLine(hp);
//     hp--;
// }



// Console.ReadLine();


static float Vapen(string vapen1, float damageA)
{
    while (vapen1 != "händer" && vapen1 !="paraply")
        {
            Console.WriteLine("skriv antingen händer eller paraply");

            if (vapen1 == "händer"){
                damageA = (int)(damageA * 1.0f);
                
            }
            if (vapen1 == "paraply"){
             damageA = (int)(damageA * 1.3f);
             
            }

        }

    return damageA;
    
}