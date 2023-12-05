int Mat = 100;
int vatten = 100;
int dag = 0;
int time = 0;

List<string> Inventory = new List<string>();

string val = "";
String nuvaranderum = "Corridor2";
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
        tidengår();
        (nuvaranderum, Mat, vatten) = Flygner2(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Inventory")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = inventory(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Litenflod")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Litenflod(Inventory, Mat, vatten);
    }
    else if (nuvaranderum == "Hem")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Hem(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Storöppnign")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Storöppnign(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Helikopter")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Helikopterner(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Orm")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Orm(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Storflodkant")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Storflodkant(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Evigvägupp")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Evigvägupp(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Evigvägner")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Evigvägner(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Båt")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Båt(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Corridor1")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Corridor1(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Corridor2")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Corridor2(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Corridor3")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Corridor3(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Corridor4")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Corridor4(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Corridor5")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Corridor5(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Corridor6")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Corridor6(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Corridor7")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Corridor7(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Corridor8")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Corridor8(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Corridor9")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Corridor9(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Corridor10")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Corridor10(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Corridor11")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Corridor11(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Corridor12")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Corridor12(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Corridor13")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Corridor13(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Corridor14")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Corridor14(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Corridor15")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Corridor15(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Corridor16")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Corridor16(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Corridor17")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Corridor17(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Corridor18")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Corridor18(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Corridor19")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Corridor19(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Corridor20")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Corridor20(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Corridor21")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Corridor21(Inventory, Mat, vatten, nuvaranderum);
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
static (string, int, int) Flygner2(List<string> Inventory, int mat, int vatten, string nuvaranderum)
{
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
    nuvaranderum = "Corridor1";
    return (nuvaranderum, mat, vatten);
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
static (string, int, int) Litenflod(List<string> Inventory, int mat, int vatten, string nuvaranderum)
{
    Console.ReadLine();
    return (nuvaranderum, mat, vatten);
}
static (string, int, int) Hem(List<string> Inventory, int mat, int vatten, string nuvaranderum)
{
    Console.ReadLine();
    return (nuvaranderum, mat, vatten);
}
static (string, int, int) Storöppnign(List<string> Inventory, int mat, int vatten, string nuvaranderum)
{
    Console.WriteLine("Storöppnign");
    Console.ReadLine();
    return (nuvaranderum, mat, vatten);
}
static (string, int, int) Helikopterner(List<string> Inventory, int mat, int vatten, string nuvaranderum)
{
    Console.ReadLine();
    return (nuvaranderum, mat, vatten);
}
static (string, int, int) Orm(List<string> Inventory, int mat, int vatten, string nuvaranderum)
{
    Console.ReadLine();
    return (nuvaranderum, mat, vatten);
}
static (string, int, int) Storflodkant(List<string> Inventory, int mat, int vatten, string nuvaranderum)
{
    Console.ReadLine();
    return (nuvaranderum, mat, vatten);
}
static (string, int, int) Evigvägupp(List<string> Inventory, int mat, int vatten, string nuvaranderum)
{
    Console.ReadLine();
    return (nuvaranderum, mat, vatten);
}
static (string, int, int) Evigvägner(List<string> Inventory, int mat, int vatten, string nuvaranderum)
{
    Console.ReadLine();
    return (nuvaranderum, mat, vatten);
}
static (string, int, int) Båt(List<string> Inventory, int mat, int vatten, string nuvaranderum)
{
    Console.ReadLine();
    return (nuvaranderum, mat, vatten);
}
static (string, int, int) Corridor1(List<string> Inventory, int mat, int vatten, string nuvaranderum)
{
    string val = "";
    Console.WriteLine("Du är nu i en korridor i skogen mellan där planet ligger och en stor öppnign");
    Console.WriteLine("vill du gå till flygplanet(F) eller vill du gå till den storra öppnignen(Ö)");

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
    return (nuvaranderum, mat, vatten);
}

static (string, int, int) Corridor2(List<string> Inventory, int mat, int vatten, string nuvaranderum)
{
    String Val = "";

    List<string> Corridor2 = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
    Corridor2.Add("1 pinne");
    Corridor2.Add("1 pinne");
    Corridor2.Add("1 pinne");
    Corridor2.Add("1 Sten");
    Corridor2.Add("1 Sten");

    Console.WriteLine("Du är nu i en corridor någonstans i junglen");  //lite text som bärätar vad du kan göra
    Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i corridoren");
    Console.WriteLine("Skriva 'Back' för att gå tillbaka eller skriv 'Framåt' för att gå framåt");
    Console.WriteLine("Skriv 'Höger' för att gå till höger och skriv 'vänster' för att gå vänster");
    Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
    while (nuvaranderum == "Corridor2")
    {
        Val = Console.ReadLine();
        Val.ToLower();

        if (Val == "leta")
        {
            Console.WriteLine("Du hittade:");      //om man väljer att leta
            for (int i = 0; i < Corridor2.Count; i++)
            {
                Console.WriteLine(Corridor2[i]);
                Inventory.Add(Corridor2[i]);
            }

            Val = "";
        }
        else if (Val == "inventory")
        {
            Console.Clear();      //Om man vill öppna inventoriet
            (mat, vatten) = inventory(Inventory, mat, vatten);
            Val = "";
        }
        else if (Val == "back")
        {
            nuvaranderum = "";

        }
        else if (Val == "höger")       //Dom olika hållen man kan gå
        {
            nuvaranderum = "";
        }
        else if (Val == "vänster")
        {
            nuvaranderum = "";
        }
        else if (Val == "framåt")
        {
            nuvaranderum = "";
        }

    }
    // ---------------------------------------------------------------------------------------
    Console.ReadLine();
    return (nuvaranderum, mat, vatten);
}
static (string, int, int) Corridor3(List<string> Inventory, int mat, int vatten, string nuvaranderum)
{
    Console.ReadLine();
    return (nuvaranderum, mat, vatten);
}
static (string, int, int) Corridor4(List<string> Inventory, int mat, int vatten, string nuvaranderum)
{
    Console.ReadLine();
    return (nuvaranderum, mat, vatten);
}
static (string, int, int) Corridor5(List<string> Inventory, int mat, int vatten, string nuvaranderum)
{
    Console.ReadLine();
    return (nuvaranderum, mat, vatten);
}
static (string, int, int) Corridor6(List<string> Inventory, int mat, int vatten, string nuvaranderum)
{
    Console.ReadLine();
    return (nuvaranderum, mat, vatten);
}
static (string, int, int) Corridor7(List<string> Inventory, int mat, int vatten, string nuvaranderum)
{
    Console.ReadLine();
    return (nuvaranderum, mat, vatten);
}
static (string, int, int) Corridor8(List<string> Inventory, int mat, int vatten, string nuvaranderum)
{
    Console.ReadLine();
    return (nuvaranderum, mat, vatten);
}
static (string, int, int) Corridor9(List<string> Inventory, int mat, int vatten, string nuvaranderum)
{
    Console.ReadLine();
    return (nuvaranderum, mat, vatten);
}
static (string, int, int) Corridor10(List<string> Inventory, int mat, int vatten, string nuvaranderum)
{
    Console.ReadLine();
    return (nuvaranderum, mat, vatten);
}
static (string, int, int) Corridor11(List<string> Inventory, int mat, int vatten, string nuvaranderum)
{
    Console.ReadLine();
    return (nuvaranderum, mat, vatten);
}
static (string, int, int) Corridor12(List<string> Inventory, int mat, int vatten, string nuvaranderum)
{
    Console.ReadLine();
    return (nuvaranderum, mat, vatten);
}
static (string, int, int) Corridor13(List<string> Inventory, int mat, int vatten, string nuvaranderum)
{
    Console.ReadLine();
    return (nuvaranderum, mat, vatten);
}
static (string, int, int) Corridor14(List<string> Inventory, int mat, int vatten, string nuvaranderum)
{
    Console.ReadLine();
    return (nuvaranderum, mat, vatten);
}
static (string, int, int) Corridor15(List<string> Inventory, int mat, int vatten, string nuvaranderum)
{
    Console.ReadLine();
    return (nuvaranderum, mat, vatten);
}
static (string, int, int) Corridor16(List<string> Inventory, int mat, int vatten, string nuvaranderum)
{
    Console.ReadLine();
    return (nuvaranderum, mat, vatten);
}
static (string, int, int) Corridor17(List<string> Inventory, int mat, int vatten, string nuvaranderum)
{
    Console.ReadLine();
    return (nuvaranderum, mat, vatten);
}
static (string, int, int) Corridor18(List<string> Inventory, int mat, int vatten, string nuvaranderum)
{
    Console.ReadLine();
    return (nuvaranderum, mat, vatten);
}
static (string, int, int) Corridor19(List<string> Inventory, int mat, int vatten, string nuvaranderum)
{
    Console.ReadLine();
    return (nuvaranderum, mat, vatten);
}
static (string, int, int) Corridor20(List<string> Inventory, int mat, int vatten, string nuvaranderum)
{
    Console.ReadLine();
    return (nuvaranderum, mat, vatten);
}
static (string, int, int) Corridor21(List<string> Inventory, int mat, int vatten, string nuvaranderum)
{
    Console.ReadLine();
    return (nuvaranderum, mat, vatten);
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
static (int, int) inventory(List<string> inventory, int vatten, int mat)
{
    Console.WriteLine("Welcome to the inventory");
    Console.WriteLine("Items you have:");
    Console.WriteLine("");


    for (int i = 0; i < inventory.Count; i++)
    {
        Console.WriteLine(inventory[i]);
    }



    List<string> Cancraft = new List<string>();

    if (inventory.Contains("1 Tröja") || inventory.Contains("1 Par byxor"))
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

    if (val == "drink" && inventory.Contains("1 Vatten"))
    {
        inventory.Remove("1 Vatten");
        if (vatten + 30 <= 100)
        {
            vatten = vatten + 30;
        }
        else if (vatten + 30 > 100)
        {
            vatten = 100;
        }
    }
    if (val == "eat" && inventory.Contains("1 Snacks bar"))
    {
        inventory.Remove("1 Snacks bar");
        if (mat + 20 <= 100)
        {
            vatten = vatten + 20;
        }
        else if (mat + 20 > 100)
        {
            vatten = 100;
        }
    }





    Console.ReadLine();

    return (mat, vatten);
}