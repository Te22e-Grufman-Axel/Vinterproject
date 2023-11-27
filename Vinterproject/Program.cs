int Mat = 100;
int vatten = 100;
int dag = 0;
int time = 0;

List<string> Inventory = new List<string>();

string val = "";
String nuvaranderum = "Flygner2";
while (true)
{
    if (nuvaranderum == "Flygner1")
    {
        Console.Clear();
        Flygner1();
    }
    else if (nuvaranderum == "Flygner2")
    {
        Console.Clear();
        Flygner2();
    }
    else if (nuvaranderum == "Inventory")
    {
        Console.Clear();
        inventory();
    }
    else if (nuvaranderum == "Litenflod")
    {
        Console.Clear();
        Litenflod();
    }
    else if (nuvaranderum == "Hem")
    {
        Console.Clear();
        Hem();
    }
    else if (nuvaranderum == "Storöppnign")
    {
        Console.Clear();
        Storöppnign();
    }
    else if (nuvaranderum == "Helikopter")
    {
        Console.Clear();
        Helikopterner();
    }
    else if (nuvaranderum == "Orm")
    {
        Console.Clear();
        Orm();
    }
    else if (nuvaranderum == "Storflodkant")
    {
        Console.Clear();
        Storflodkant();
    }
    else if (nuvaranderum == "Evigvägupp")
    {
        Console.Clear();
        Evigvägupp();
    }
    else if (nuvaranderum == "Evigvägner")
    {
        Console.Clear();
        Evigvägner();
    }
    else if (nuvaranderum == "Båt")
    {
        Console.Clear();
        Båt();
    }
    else if (nuvaranderum == "Corridor1")
    {
        Console.Clear();
        Corridor1();
    }
    else if (nuvaranderum == "Corridor2")
    {
        Console.Clear();
        Corridor2();
    }
    else if (nuvaranderum == "Corridor3")
    {
        Console.Clear();
        Corridor3();
    }
    else if (nuvaranderum == "Corridor4")
    {
        Console.Clear();
        Corridor4();
    }
    else if (nuvaranderum == "Corridor5")
    {
        Console.Clear();
        Corridor5();
    }
    else if (nuvaranderum == "Corridor6")
    {
        Console.Clear();
        Corridor6();
    }
    else if (nuvaranderum == "Corridor7")
    {
        Console.Clear();
        Corridor7();
    }
    else if (nuvaranderum == "Corridor8")
    {
        Console.Clear();
        Corridor8();
    }
    else if (nuvaranderum == "Corridor9")
    {
        Console.Clear();
        Corridor9();
    }
    else if (nuvaranderum == "Corridor10")
    {
        Console.Clear();
        Corridor10();
    }
    else if (nuvaranderum == "Corridor11")
    {
        Console.Clear();
        Corridor11();
    }
    else if (nuvaranderum == "Corridor12")
    {
        Console.Clear();
        Corridor12();
    }
    else if (nuvaranderum == "Corridor13")
    {
        Console.Clear();
        Corridor13();
    }
    else if (nuvaranderum == "Corridor14")
    {
        Console.Clear();
        Corridor14();
    }
    else if (nuvaranderum == "Corridor15")
    {
        Console.Clear();
        Corridor15();
    }
    else if (nuvaranderum == "Corridor16")
    {
        Console.Clear();
        Corridor16();
    }
    else if (nuvaranderum == "Corridor17")
    {
        Console.Clear();
        Corridor17();
    }
    else if (nuvaranderum == "Corridor18")
    {
        Console.Clear();
        Corridor18();
    }
    else if (nuvaranderum == "Corridor19")
    {
        Console.Clear();
        Corridor19();
    }
    else if (nuvaranderum == "Corridor20")
    {
        Console.Clear();
        Corridor20();
    }
    else if (nuvaranderum == "Corridor21")
    {
        Console.Clear();
        Corridor21();
    }
}


void Flygner1()
{
    Console.WriteLine("Du vaknar upp i din stol");
    Console.WriteLine("Du undrar var du är, vad hände");
    Console.WriteLine("Du börjar komma ihåg");
    Console.WriteLine("Du var på väg till philipinerna när dit plan började störta");
    Console.WriteLine("Du antar att planet krashade och du blev medvetslös");

    Console.WriteLine("");
    Console.WriteLine("Du kollar runt dig men ser att alla andra är döda");
    Console.WriteLine("Du ställer dig upp i stolen och ser att planet är i två delar");
    Console.WriteLine("Du tar dig ur flygplanet och ser att du är i en jungel");
    Console.WriteLine("Du ser en väg genom träden och väljer att följa den");


    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("Tryck på space för att fortsätta");
    Console.ReadKey();
    nuvaranderum = "Corridor1";
}
void Flygner2()
{
    tidengår();

    Console.WriteLine("Du gick tillbaka till flygplanet");
    Console.WriteLine("Du bästämer dig för att kolla runt lite");
    Console.WriteLine("Du hittar 2 flaskor vatten och 3 snacks bars när du kollar i matkorgen");
    Console.WriteLine("Du hittar också 1 Medecin låda i toaleten ");
    Console.WriteLine("Du hittar också 2 tröjor och 1 par byxor");


    Inventory.Add("1 Vatten");
    Inventory.Add("1 vatten");
    Inventory.Add("1 Medecin");
    Inventory.Add("1 Snacks bar");
    Inventory.Add("1 Snacks bar");
    Inventory.Add("1 Snacks bar");
    Inventory.Add("1 Tröja");
    Inventory.Add("1 Tröja");
    Inventory.Add("1 Par byxor");
    Console.ReadLine();
    Console.Clear();
    inventory();
}
void tidengår()
{
    time++;
    if (time == 24)
    {
        time = 0;
        dag++;
    }
    Mat = Mat - 5;
    vatten = vatten - 10;
    if (Mat < 0)
    {
        Deathofstarving();
    }
    if (vatten < 0)
    {
        Deathofthirst();
    }
}
void Litenflod()
{
    tidengår();
    Console.ReadLine();
}
void Hem()
{
    tidengår();
    Console.ReadLine();
}
void Storöppnign()
{
    tidengår();
    Console.WriteLine("Storöppnign");
    Console.ReadLine();
}
void Helikopterner()
{
    tidengår();
    Console.ReadLine();
}
void Orm()
{
    tidengår();
    Console.ReadLine();
}
void Storflodkant()
{
    tidengår();
    Console.ReadLine();
}
void Evigvägupp()
{
    tidengår();
    Console.ReadLine();
}
void Evigvägner()
{
    tidengår();
    Console.ReadLine();
}
void Båt()
{
    tidengår();
    Console.ReadLine();

}
void Corridor1()
{
    tidengår();
    Console.WriteLine("Du är nu i en korridor i skogen mellan där planet ligger och en stor öppnign");
    Console.WriteLine("vill du gå till flygplanet(F) eller vill du gå till den storra öppnignen(Ö)");
    Console.WriteLine(time);
    Console.WriteLine(dag);
    Console.WriteLine(Mat);
    Console.WriteLine(vatten);

    val = Console.ReadLine();
    val.ToLower();
    if (val == "f")
    {
        val = "";
        nuvaranderum = "Flygner2";
    }
    else if (val == "ö")
    {
        val = "";
        nuvaranderum = "Storöppnign";
    }
    else
    {
        val = "";
        Console.WriteLine("Du valde inget så du satt bara där i en timme innan du valde att försöka göra något igen");
        Console.ReadLine();
    }
}
void Corridor2()
{
    tidengår();
List<string> Corridor2 = new List<string>();
Corridor2.Add("1 pinne");
Corridor2.Add("1 pinne");
Corridor2.Add("1 pinne");
Corridor2.Add("1 Sten");
Corridor2.Add("1 Sten");

Console.WriteLine("Du är nu i en corridor någonstans i junglen");
Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i corridoren");
Console.WriteLine("Skriva 'Back' för att gå tillbaka");
Console.WriteLine("");


    Console.ReadLine();
}
void Corridor3()
{
    tidengår();
    Console.ReadLine();
}
void Corridor4()
{
    tidengår();
    Console.ReadLine();
}
void Corridor5()
{
    tidengår();
    Console.ReadLine();
}
void Corridor6()
{
    tidengår();
    Console.ReadLine();
}
void Corridor7()
{
    tidengår();
    Console.ReadLine();
}
void Corridor8()
{
    tidengår();
    Console.ReadLine();
}
void Corridor9()
{
    tidengår();
    Console.ReadLine();
}
void Corridor10()
{
    tidengår();
    Console.ReadLine();
}
void Corridor11()
{
    tidengår();
    Console.ReadLine();
}
void Corridor12()
{
    tidengår();
    Console.ReadLine();
}
void Corridor13()
{
    tidengår();
    Console.ReadLine();
}
void Corridor14()
{
    tidengår();
    Console.ReadLine();
}
void Corridor15()
{
    tidengår();
    Console.ReadLine();
}
void Corridor16()
{
    tidengår();
    Console.ReadLine();
}
void Corridor17()
{
    tidengår();
    Console.ReadLine();
}
void Corridor18()
{
    tidengår();
    Console.ReadLine();
}
void Corridor19()
{
    tidengår();
    Console.ReadLine();
}
void Corridor20()
{
    tidengår();
    Console.ReadLine();
}
void Corridor21()
{
    tidengår();
    Console.ReadLine();
}
void Deathofstarving()
{
    Console.WriteLine("Du dog av hunger");
    Console.ReadLine();
}
void Deathofthirst()
{
    Console.WriteLine("Du dog av turst");
    Console.ReadLine();
}
void Deathofsnake()
{
    Console.WriteLine("Du dog av ormen");
    Console.ReadLine();
}
void inventory()
{
    Console.WriteLine("Welcome to the inventory");
    Console.WriteLine("Items you have:");
    Console.WriteLine("");


    for (int i = 0; i < Inventory.Count; i++)
    {
        Console.WriteLine(Inventory[i]);
    }



    List<string> Cancraft = new List<string>();

    if (Inventory.Contains("1 Tröja") || Inventory.Contains("1 Par byxor"))
    {
        Cancraft.Add("3 Cloth");
    }

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Items du kan crafta:");

    for (int i = 0; i < Cancraft.Count; i++)
    {
        Console.WriteLine(Cancraft[i]);
    }


    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Skriv 'Back' För att gå tillbaka");
    Console.WriteLine("Skriv 'Craft' För att crafta");
    Console.WriteLine("Skriv 'Eat' För att äta");
    Console.WriteLine("Skriv 'Drink' för att dricka");
    string val = Console.ReadLine();
    val.ToLower();

    if (val == "drink" && Inventory.Contains("1 Vatten"))
    {
        Inventory.Remove("1 Vatten");
        if (vatten + 30 <= 100)
        {
            vatten = vatten + 30;
        }
        else if (vatten + 30 > 100)
        {
            vatten = 100;
        }
    }
    if (val == "eat" && Inventory.Contains("1 Snacks bar"))
    {
        Inventory.Remove("1 Snacks bar");
        if (Mat + 20 <= 100)
        {
            vatten = vatten + 20;
        }
        else if (Mat + 20 > 100)
        {
            vatten = 100;
        }
    }





    Console.ReadLine();
}