int Mat = 100;
int vatten = 100;
int dag = 0;
int time = 12;

string val = "";
String nuvaranderum = "Flygner1";
while(true){
if(nuvaranderum == "Flygner1")
{
flygner1();
}
else if(nuvaranderum == "Flygner2")
{
Flygner2();
}
else if(nuvaranderum == "litenflod")
{
Litenflod();
}
else if(nuvaranderum == "hem")
{
hem();
}
else if(nuvaranderum == "Storöppnign")
{
Storöppnigne();
}
else if(nuvaranderum == "Helikopter")
{
Helikopterner();
}
else if(nuvaranderum == "Orm")
{
orm();
}
else if(nuvaranderum == "Storflodkant")
{
storflodkant();
}
else if(nuvaranderum == "Evigvägupp")
{
evigvägupp();
}
else if(nuvaranderum == "Evigvägner")
{
evigvägner();
}
else if(nuvaranderum == "Båt")
{
båt();
}
else if(nuvaranderum == "Corridor1")
{
corridor1();
}
else if(nuvaranderum == "Corridor2")
{
corridor2();
}
else if(nuvaranderum == "Corridor3")
{
corridor3();
}
else if(nuvaranderum == "Corridor4")
{
corridor4();
}
else if(nuvaranderum == "Corridor5")
{
corridor5();
}
else if(nuvaranderum == "Corridor6")
{
corridor6();
}
else if(nuvaranderum == "Corridor7")
{
corridor7();
}
else if(nuvaranderum == "Corridor8")
{
corridor8();
}
else if(nuvaranderum == "Corridor9")
{
corridor9();
}
else if(nuvaranderum == "Corridor10")
{
corridor10();
}
else if(nuvaranderum == "Corridor11")
{
corridor11();
}
else if(nuvaranderum == "Corridor12")
{
corridor12();
}
else if(nuvaranderum == "Corridor13")
{
corridor13();
}
else if(nuvaranderum == "Corridor14")
{
corridor14();
}
else if(nuvaranderum == "Corridor15")
{
corridor15();
}
else if(nuvaranderum == "Corridor16")
{
corridor16();
}
else if(nuvaranderum == "Corridor17")
{
corridor17();
}
else if(nuvaranderum == "Corridor18")
{
corridor18();
}
else if(nuvaranderum == "Corridor19")
{
corridor19();
}
else if(nuvaranderum == "Corridor20")
{
corridor20();
}
else if(nuvaranderum == "Corridor21")
{
corridor11();
}
}




void flygner1()
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
}
void Flygner2()
{
    time++;
    if (time == 24)
    {
        time = 0;
        dag++;
    }
    Console.WriteLine("");







    Console.ReadLine();
}
void Litenflod()
{
time++;
if (time == 24)
{
    time = 0;
    dag++;
}
    Console.ReadLine();
}
void hem()
{
time++;
if (time == 24)
{
    time = 0;
    dag++;
}
    Console.ReadLine();
}
void Storöppnigne()
{
time++;
if (time == 24)
{
    time = 0;
    dag++;
}
    Console.ReadLine();
}
void Helikopterner()
{
time++;
if (time == 24)
{
    time = 0;
    dag++;
}
    Console.ReadLine();
}
void orm()
{
time++;
if (time == 24)
{
    time = 0;
    dag++;
}
    Console.ReadLine();
}
void storflodkant()
{
time++;
if (time == 24)
{
    time = 0;
    dag++;
}
    Console.ReadLine();
}
void evigvägupp()
{
time++;
if (time == 24)
{
    time = 0;
    dag++;
}
    Console.ReadLine();
}
void evigvägner()
{
time++;
if (time == 24)
{
    time = 0;
    dag++;
}
    Console.ReadLine();
}
void båt()
{
time++;
if (time == 24)
{
    time = 0;
    dag++;
}
    Console.ReadLine();

}
void corridor1()
{
    time++;
    if (time == 24)
    {
        time = 0;
        dag++;
    }
    Console.WriteLine("Du är nu i en sort korridor i skogen mellan där planet ligger och en stor öppnign");
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
        nuvaranderum = "Storaöppnign";
    }
    else
    {
        val = "";
        time++;
        Console.WriteLine("Du valde inget så du satt bara där i en timme innan du valde att försöka göra något igen");
    }

    Console.ReadLine();
}
void corridor2()
{
    

time++;
if (time == 24)
{
    time = 0;
    dag++;
}
    Console.ReadLine();
}
void corridor3()
{
time++;
if (time == 24)
{
    time = 0;
    dag++;
}
    Console.ReadLine();
}
void corridor4()
{
time++;
if (time == 24)
{
    time = 0;
    dag++;
}
    Console.ReadLine();
}
void corridor5()
{
time++;
if (time == 24)
{
    time = 0;
    dag++;
}
    Console.ReadLine();
}
void corridor6()
{
time++;
if (time == 24)
{
    time = 0;
    dag++;
}
    Console.ReadLine();
}
void corridor7()
{
time++;
if (time == 24)
{
    time = 0;
    dag++;
}
    Console.ReadLine();
}
void corridor8()
{
time++;
if (time == 24)
{
    time = 0;
    dag++;
}
    Console.ReadLine();
}
void corridor9()
{
time++;
if (time == 24)
{
    time = 0;
    dag++;
}
    Console.ReadLine();
}
void corridor10()
{
time++;
if (time == 24)
{
    time = 0;
    dag++;
}
    Console.ReadLine();
}
void corridor11()
{
time++;
if (time == 24)
{
    time = 0;
    dag++;
}
    Console.ReadLine();
}
void corridor12()
{
time++;
if (time == 24)
{
    time = 0;
    dag++;
}
    Console.ReadLine();
}
void corridor13()
{
time++;
if (time == 24)
{
    time = 0;
    dag++;
}
    Console.ReadLine();
}
void corridor14()
{
time++;
if (time == 24)
{
    time = 0;
    dag++;
}
    Console.ReadLine();
}
void corridor15()
{
time++;
if (time == 24)
{
    time = 0;
    dag++;
}
    Console.ReadLine();
}
void corridor16()
{
time++;
if (time == 24)
{
    time = 0;
    dag++;
}
    Console.ReadLine();
}
void corridor17()
{
time++;
if (time == 24)
{
    time = 0;
    dag++;
}
    Console.ReadLine();
}
void corridor18()
{
time++;
if (time == 24)
{
    time = 0;
    dag++;
}
    Console.ReadLine();
}
void corridor19()
{
time++;
if (time == 24)
{
    time = 0;
    dag++;
}
    Console.ReadLine();
}
void corridor20()
{
time++;
if (time == 24)
{
    time = 0;
    dag++;
}
    Console.ReadLine();
}
void corridor21()
{
time++;
if (time == 24)
{
    time = 0;
    dag++;
}
    Console.ReadLine();
}