﻿int Mat = 100;
int vatten = 100;
int dag = 0;
int time = 12;

string val = "";
String nuvaranderum = "Flygner1";
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
    Console.WriteLine("Flygner2");




    Console.ReadLine();
}
void tidengår()
{
    time++;
    if (time == 24)
    {
        time = 0;
        dag++;
    }
    Mat = -5;
    vatten = -10;
    if (Mat > 0)
    {
        Deathofstarving();
    }
    if (vatten > 0)
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
        tidengår();
        Console.WriteLine("Du valde inget så du satt bara där i en timme innan du valde att försöka göra något igen");
    }

    Console.ReadLine();
}
void Corridor2()
{
    tidengår();
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