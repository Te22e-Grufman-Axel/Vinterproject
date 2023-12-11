int Mat = 100;
int vatten = 100;
int dag = 0;
int time = 0;

List<string> Inventory = new List<string>();

String nuvaranderum = "Corridor18";
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
        (nuvaranderum, Mat, vatten) = Rooms.Flygner2(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Inventory")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Rooms.inventory(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Litenflod")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Rooms.Litenflod(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Hem")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Rooms.Hem(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Storöppnign")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Rooms.Storöppnign(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Helikopter")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Rooms.Helikopterner(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Orm")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Rooms.Orm(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Storflodkant")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Rooms.Storflodkant(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Evigvägupp")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Rooms.Evigvägupp(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Evigvägner")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Rooms.Evigvägner(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Båt")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Rooms.Båt(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Corridor1")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Rooms.Corridor1(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Corridor2")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Rooms.Corridor2(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Corridor3")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Rooms.Corridor3(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Corridor4")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Rooms.Corridor4(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Corridor5")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Rooms.Corridor5(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Corridor6")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Rooms.Corridor6(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Corridor7")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Rooms.Corridor7(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Corridor8")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Rooms.Corridor8(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Corridor9")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Rooms.Corridor9(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Corridor10")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Rooms.Corridor10(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Corridor11")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Rooms.Corridor11(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Corridor12")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Rooms.Corridor12(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Corridor13")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Rooms.Corridor13(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Corridor14")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Rooms.Corridor14(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Corridor15")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Rooms.Corridor15(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Corridor16")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Rooms.Corridor16(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Corridor17")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Rooms.Corridor17(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Corridor18")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Rooms.Corridor18(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Corridor19")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Rooms.Corridor19(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Corridor20")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Rooms.Corridor20(Inventory, Mat, vatten, nuvaranderum);
    }
    else if (nuvaranderum == "Corridor21")
    {
        Console.Clear();
        tidengår();
        (nuvaranderum, Mat, vatten) = Rooms.Corridor21(Inventory, Mat, vatten, nuvaranderum);
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
// -------------------------------------------------------------------------------------------------------------------------
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
// -------------------------------------------------------------------------------------------------------------------------
static void Deathofstarving()
{
    Console.WriteLine("Du dog av hunger");
    Console.ReadLine();
}
// -------------------------------------------------------------------------------------------------------------------------
static void Deathofthirst()
{
    Console.WriteLine("Du dog av turst");
    Console.ReadLine();
}
// -------------------------------------------------------------------------------------------------------------------------
static void Deathofsnake()
{
    Console.WriteLine("Du dog av ormen");
    Console.ReadLine();
}