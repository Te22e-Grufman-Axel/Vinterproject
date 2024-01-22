class Rooms
{
    public static (string, int, int, string) Flygner2(List<string> Inventory, int mat, int vatten, string nuvaranderum, string LastRoom)
    {
        String Val = "";

        List<string> flygner2 = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        flygner2.Add("1 pinne");
        flygner2.Add("1 Sten");
        flygner2.Add("1 Sten");
        flygner2.Add("1 Tröja");
        flygner2.Add("1 Tröja");
        flygner2.Add("1 Tröja");
        flygner2.Add("1 Vatten");
        flygner2.Add("1 Vatten");
        flygner2.Add("1 Vatten");
        flygner2.Add("1 Snacks bar");
        flygner2.Add("1 Snacks bar");
        flygner2.Add("1 Par byxor");
        flygner2.Add("1 Par byxor");
        flygner2.Add("1 Par byxor");
        (mat, vatten) = kanse_blir_törstig(mat, vatten);
        Console.WriteLine("Du är nu tillbaka vid flygplanet");  //lite text som berättar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i korridoren");
        Console.WriteLine("Skriva 'Back' för att gå tillbaka");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
        while (nuvaranderum == "Flygner2")
        {
            Val = Console.ReadLine();
            Val.ToLower();

            if (Val == "leta")
            {
                Console.WriteLine("Du hittade:");      //om man väljer att leta
                for (int i = 0; i < flygner2.Count; i++)
                {
                    Console.WriteLine(flygner2[i]);
                    Inventory.Add(flygner2[i]);
                }
                                for (int i = 0; i < flygner2.Count; i++)
                {
                    flygner2.RemoveAt(i);
                }

                Val = "";
            }
            else if (Val == "inventory")
            {
                Console.Clear();      //Om man vill öppna inventoriet
                (nuvaranderum, mat, vatten, LastRoom) = inventory(Inventory, mat, vatten, nuvaranderum, LastRoom);
                Val = "";
            }
            else if (Val == "back")
            {
                nuvaranderum = "Corridor1";
            }                              //Dom olika hållen man kan gå
            else
            {
                Console.WriteLine("Du valde inget så du bara satt där i en timma och väntar");
            }

        }
        return (nuvaranderum, mat, vatten, LastRoom);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int, string) Litenflod(List<string> Inventory, int mat, int vatten, string nuvaranderum, string LastRoom)
    {
        String Val = "";

        List<string> Litenflod = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Litenflod.Add("1 pinne");
        Litenflod.Add("1 Sten");
        Litenflod.Add("1 Snacks bar");

        (mat, vatten) = kanse_blir_törstig(mat, vatten);
        Console.WriteLine("Du hittade en liten flod");
        Console.WriteLine("Skriv 'Drick' för att dricka vatten från floden"); //lite text som berättar vad du kan göra
        Console.WriteLine("Skriv 'Leta' för att kolla om du kan hitta något i korridoren");
        Console.WriteLine("Skriv 'Back' för att gå tillbaka");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
        while (nuvaranderum == "Litenflod")
        {
            Val = Console.ReadLine();
            Val.ToLower();

            if (Val == "leta")
            {
                Console.WriteLine("Du hittade:");      //om man väljer att leta
                for (int i = 0; i < Litenflod.Count; i++)
                {
                    Console.WriteLine(Litenflod[i]);
                    Inventory.Add(Litenflod[i]);
                }
                for (int i = 0; i < Litenflod.Count; i++)
                {
                    Litenflod.RemoveAt(i);
                }
                Val = "";
            }
            else if (Val == "inventory")
            {
                Console.Clear();      //Om man vill öppna inventoriet
                (nuvaranderum, mat, vatten, LastRoom) = inventory(Inventory, mat, vatten, nuvaranderum, LastRoom);
                Val = "";
            }
            else if (Val == "back")
            {
                nuvaranderum = "Storöppnign";
            }
            else if (Val == "drick")
            {
                if(vatten + 30 > 100)
                {
                    vatten = 100;
                }
                else if(vatten + 30 < 100)
                {
                vatten = +30;
                }
                Console.WriteLine("Du drack vatten");
                Val = "";
            }                       //Dom olika hållen man kan gå
            else
            {
                Console.WriteLine("Du valde inget så du bara satt där i en timma och väntar");
            }
        }
        return (nuvaranderum, mat, vatten, LastRoom);
    }

    public static (string, int, int, string) Storöppnign(List<string> Inventory, int mat, int vatten, string nuvaranderum, string LastRoom)
    {

        String Val = "";

        List<string> Storöppnign = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Storöppnign.Add("1 pinne");

        (mat, vatten) = kanse_blir_törstig(mat, vatten);
        Console.WriteLine("Du är nu i en stor öppning någonstans i djungeln");  //lite text som berättar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i korridoren");
        Console.WriteLine("Skriv 'Flod' för att gå till floden");
        Console.WriteLine("Skriv 'Flygplan' för att gå till flygplanet");
        Console.WriteLine("Skriv 'Neråt' för att gå neråt eller skriv 'Höger' för att gå till höger");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
        while (nuvaranderum == "Storöppnign")
        {
            Val = Console.ReadLine();
            Val.ToLower();

            if (Val == "leta")
            {
                Console.WriteLine("Du hittade:");      //om man väljer att leta
                for (int i = 0; i < Storöppnign.Count; i++)
                {
                    Console.WriteLine(Storöppnign[i]);
                    Inventory.Add(Storöppnign[i]);
                }
                for (int i = 0; i < Storöppnign.Count; i++)
                {
                    Storöppnign.RemoveAt(i);
                }
                Val = "";
            }
            else if (Val == "inventory")
            {
                Console.Clear();      //Om man vill öppna inventoriet
                (nuvaranderum, mat, vatten, LastRoom) = inventory(Inventory, mat, vatten, nuvaranderum, LastRoom);
                Val = "";
            }
            else if (Val == "flod")//Dom olika hållen man kan gå
            {
                nuvaranderum = "Litenflod";
            }
            else if (Val == "flygplan")
            {
                nuvaranderum = "Corridor1";
            }
            else if (Val == "neråt")
            {
                nuvaranderum = "Corridor2";
            }
            else if (Val == "höger")
            {
                nuvaranderum = "Corridor18";
            }
            else
            {
                Console.WriteLine("Du valde inget så du bara satt där i en timma och väntar");
            }

        }



        return (nuvaranderum, mat, vatten, LastRoom);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int, string) Helikopterner(List<string> Inventory, int mat, int vatten, string nuvaranderum, string LastRoom)
    {
        String Val = "";

        List<string> Helikopter = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Helikopter.Add("1 spak");
        Helikopter.Add("1 knapp");

        (mat, vatten) = kanse_blir_törstig(mat, vatten);
        Console.WriteLine("Du hittade en helikopter som har kraschat");
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i korridoren");
        Console.WriteLine("Skriva 'Back' för att gå tillbaka eller skriv 'Framåt' för att gå framåt");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");        //lite text som berättar vad du kan göra

        while (nuvaranderum == "Helikopter")
        {
            Val = Console.ReadLine();
            Val.ToLower();

            if (Val == "leta")
            {
                Console.WriteLine("Du hittade:");      //om man väljer att leta
                for (int i = 0; i < Helikopter.Count; i++)
                {
                    Console.WriteLine(Helikopter[i]);
                    Inventory.Add(Helikopter[i]);
                }
                for (int i = 0; i < Helikopter.Count; i++)
                {
                    Helikopter.RemoveAt(i);
                }
                Val = "";
                Console.WriteLine("");
                Console.WriteLine("Kanske kan använda dom för att fly");
            }
            else if (Val == "inventory")
            {
                Console.Clear();      //Om man vill öppna inventoriet
                (nuvaranderum, mat, vatten, LastRoom) = inventory(Inventory, mat, vatten, nuvaranderum, LastRoom);
                Val = "";
            }
            else if (Val == "back")
            {
                nuvaranderum = "Corridor3";         //Dom olika hållen man kan gå
            }
            else
            {
                Console.WriteLine("Du valde inget så du bara satt där i en timma och väntar");
            }

        }

        return (nuvaranderum, mat, vatten, LastRoom);

    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int, string) Orm(List<string> Inventory, int mat, int vatten, string nuvaranderum, string LastRoom)
    {

        Random Skada = new Random();
        Random misschans = new Random();
        Random aitypavattack = new Random();//massa variablar
        int HP = 100;
        int maxskada = 35;
        int lightattackmisschans = 20;
        int hardattackmisschans = 40;
        int nuvaranespelarhp = HP;
        int nuvaraneaihp = HP;

        bool VaritHärTidigare = false;

        String Val = "";
        String spelaretypavattack = "";
        string ormlever = "ja";


        Console.WriteLine("Du gick in i ett stort runt rum i djungeln");
        Console.WriteLine("Och du ser en motor i mitten");
        Console.WriteLine("Undrar hur den kom dit");
        Console.WriteLine("När du går fram för att ta blir du slagen av något och kastas bakåt");
        Console.WriteLine("Du ser att det är en stor orm framför dig");
        Console.WriteLine("Och då kommer fram till att du inte kan fly utan måste slåss");
        while (ormlever == "ja")
        {

            int tmpaitypavattack = aitypavattack.Next(2);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Vad vill du göra?");
            Console.WriteLine("Hard attack'H', Light attack'L' eller försöka fly'F'");

            spelaretypavattack = Console.ReadLine();
            spelaretypavattack = spelaretypavattack.ToLower();
            Console.WriteLine("");
            Console.WriteLine("");
            // ------------------------------------------------------------------
            if (spelaretypavattack == "l")
            {
                int tempmisschans = misschans.Next(100);
                if (tempmisschans <= lightattackmisschans)
                {
                    Console.WriteLine("Du försökte göra en Light attack men missade fienden.");
                }
                else                        //spelaren light attack kod
                {
                    int spelaredamage = Skada.Next(maxskada);
                    nuvaraneaihp -= spelaredamage;
                    Console.WriteLine("Du attakerar ormen med en light attack och gör " + spelaredamage + " i skada");
                    Console.WriteLine("ormen har nu " + nuvaraneaihp + " i liv(hp).");
                }
            }
            // ------------------------------------------------------------------
            else if (spelaretypavattack == "h")
            {

                int tempmisschans = misschans.Next(100);
                if (tempmisschans <= hardattackmisschans)
                {
                    Console.WriteLine("Du försöker göra en hard attack men missade fienden");
                }
                else                //Spelaren hard attack kod
                {
                    int spelaredamage = Skada.Next(2 * maxskada);
                    nuvaraneaihp -= spelaredamage;
                    Console.WriteLine("Du attackerar ormen med en hard attack och gör " + spelaredamage + " i skada");
                    Console.WriteLine("Ormen har nu " + nuvaraneaihp + " i liv(hp).");
                }
            }
            //------------------------------------------------------------------------------------------------------
            else if (spelaretypavattack == "f")                       //Om man försöker fly
            {
                Console.WriteLine("Du försökte fly men ormen lyckades döda dig");
                Console.ReadLine();
                Death.snake();
            }
            // ------------------------------------------------------------------
            else                 //om man inte slår
            {
                Console.WriteLine("Du valde inget så du slår inte.");
            }
            // ------------------------------------------------------------------
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            if (tmpaitypavattack >= 0)
            {
                int tempmisschans = misschans.Next(100);
                if (tempmisschans <= lightattackmisschans)
                {
                    Console.WriteLine("Ormen försökta göra en light attack men missade dig.");
                }
                else                        //ai lightattack kod
                {
                    int aidamage = Skada.Next(maxskada);
                    nuvaranespelarhp -= aidamage;
                    Console.WriteLine("Ormen attackerar dig med en light attack och gör " + aidamage + " i skada");
                    Console.WriteLine("Du har nu " + nuvaranespelarhp + " i liv(hp).");
                }
            }
            // ------------------------------------------------------------------
            else if (tmpaitypavattack <= 1)
            {
                int tempmisschans = misschans.Next(100);
                if (tempmisschans <= hardattackmisschans)
                {
                    Console.WriteLine("Ormen försökte göra en hard attack men missade dig");
                }
                else                   //ai hardattack kod
                {
                    int aidamage = Skada.Next(2 * maxskada);
                    nuvaranespelarhp -= aidamage;
                    Console.WriteLine("Ormen attackerar dig med en hard attack och gör " + aidamage + " i skada");
                    Console.WriteLine("Du har nu " + nuvaranespelarhp + " i liv(hp).");
                }
            }

            if (nuvaraneaihp <= 0 && nuvaranespelarhp <= 0)
            {
                Death.snake();
            }
            else if (nuvaranespelarhp <= 0)
            {
                Death.snake();
            }
            else if (nuvaraneaihp <= 0)
            {
                ormlever = "Nej";
            }
        }


        if (VaritHärTidigare == false && ormlever == "Nej")
        {
            Console.Clear();
            Console.WriteLine("Du lyckades döda ormen");
            Console.WriteLine("Du går först och hämtar motorn som låg i mitten");
            Console.WriteLine("Kanske kan du använda den för att fly härifrån");
            Console.WriteLine("Sen kommer du på att du kanske kan äta ormen för mat");
            Console.WriteLine("Så du tar ut din kniv och hackar Ormen i mindre delar");


            Inventory.Add("1 Motor");
            Inventory.Add("1 Ormbit");
            Inventory.Add("1 Ormbit");
            Inventory.Add("1 Ormbit");
            Inventory.Add("1 Ormbit");
            Inventory.Add("1 Ormbit");
            Inventory.Add("1 Ormbit");
            Inventory.Add("1 Ormbit");
            VaritHärTidigare = true;
        }



        while (nuvaranderum == "Orm" && ormlever == "Nej" && VaritHärTidigare == true)
        {

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("");
            }
        (mat, vatten) = kanse_blir_törstig(mat, vatten);
            Console.WriteLine("Du är i rummet där du dödade ormen");  //lite text som berättar vad du kan göra
            Console.WriteLine("Skriva 'Back' för att gå tillbaka eller skriv 'Framåt' för att gå framåt");
            Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");

            Val = Console.ReadLine();
            Val.ToLower();


            if (Val == "inventory")
            {
                Console.Clear();      //Om man vill öppna inventoriet
                (nuvaranderum, mat, vatten, LastRoom) = inventory(Inventory, mat, vatten, nuvaranderum, LastRoom);
                Val = "";
            }
            else if (Val == "back")
            {
                nuvaranderum = "Corridor4";
            }                              //Dom olika hållen man kan gå
            else if (Val == "framåt")
            {
                nuvaranderum = "Corridor5";
            }
            else
            {
                Console.WriteLine("Du valde inget så du bara satt där i en timma och väntar");
            }
        }

        return (nuvaranderum, mat, vatten, LastRoom);

    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int, string) Storflodkant(List<string> Inventory, int mat, int vatten, string nuvaranderum, string LastRoom)
    {
        String Val = "";

        List<string> Storflodkant = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Storflodkant.Add("1 pinne");
        (mat, vatten) = kanse_blir_törstig(mat, vatten);
        Console.WriteLine("Du ser att du är vid en stor flod");  //lite text som berättar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i korridoren");
        Console.WriteLine("Skriva 'Back' för att gå tillbaka eller skriv 'Framåt' för att gå framåt");
        Console.WriteLine("Skriv 'Höger' för att gå till höger och skriv 'vänster' för att gå vänster");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
        while (nuvaranderum == "Storflodkant")
        {
            Val = Console.ReadLine();
            Val.ToLower();

            if (Val == "leta")
            {
                Console.WriteLine("Du hittade:");      //om man väljer att leta
                for (int i = 0; i < Storflodkant.Count; i++)
                {
                    Console.WriteLine(Storflodkant[i]);
                    Inventory.Add(Storflodkant[i]);
                }
                for (int i = 0; i < Storflodkant.Count; i++)
                {
                    Storflodkant.RemoveAt(i);
                }
                Val = "";
            }
            else if (Val == "inventory")
            {
                Console.Clear();      //Om man vill öppna inventoriet
                (nuvaranderum, mat, vatten, LastRoom) = inventory(Inventory, mat, vatten, nuvaranderum, LastRoom);
                Val = "";
            }
            else if (Val == "back")
            {
                nuvaranderum = "Corridor21";
            }
            else if (Val == "höger")       //Dom olika hållen man kan gå
            {
                nuvaranderum = "Evigvägner";
            }
            else if (Val == "vänster")
            {
                nuvaranderum = "Evigvägupp";
            }
            else if (Val == "framåt")
            {
                nuvaranderum = "Båt";
            }
            else
            {
                Console.WriteLine("Du valde inget så du bara satt där i en timma och väntar");
            }
        }

        return (nuvaranderum, mat, vatten, LastRoom);
    }
    // --------------------------------------------------------------------------------------------------------------
    public static (string, int, int, string) Evigvägupp(List<string> Inventory, int mat, int vatten, string nuvaranderum, string LastRoom)
    {
        String Val = "";
        (mat, vatten) = kanse_blir_törstig(mat, vatten);
        Console.WriteLine("Du väljer att fortsätta upp");
        Console.WriteLine("Skriv 'Fortsätt' för att fortsätta upp eller skriv gå 'Tillbaka' för att gå tillbaka till början");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");

        while (nuvaranderum == "Evigvägupp")
        {
            Val = Console.ReadLine();
            Val.ToLower();

            if (Val == "inventory")
            {
                Console.Clear();      //Om man vill öppna inventoriet
                (nuvaranderum, mat, vatten, LastRoom) = inventory(Inventory, mat, vatten, nuvaranderum, LastRoom);
                Val = "";
            }
            else if (Val == "tillbaka")
            {
                nuvaranderum = "Storflodkant";
            }                              //Dom olika hållen man kan gå
            else if (Val == "fortsätt")
            {
                nuvaranderum = "EvigVägUpp2";
            }
            else
            {
                Console.WriteLine("Du valde inget så du bara satt där i en timma och väntar");
            }
        }

        return (nuvaranderum, mat, vatten, LastRoom);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int, string) Evigvägner(List<string> Inventory, int mat, int vatten, string nuvaranderum, string LastRoom)
    {
        String Val = "";
        (mat, vatten) = kanse_blir_törstig(mat, vatten);
        Console.WriteLine("Du väljer att fortsätta ner");
        Console.WriteLine("Skriv 'Fortsätt' för att fortsätta upp eller skriv gå 'Tillbaka' för att gå tillbaka till början");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
        while (nuvaranderum == "Evigvägner")
        {
            Val = Console.ReadLine();
            Val.ToLower();

            if (Val == "inventory")
            {
                Console.Clear();      //Om man vill öppna inventoriet
                (nuvaranderum, mat, vatten, LastRoom) = inventory(Inventory, mat, vatten, nuvaranderum, LastRoom);
                Val = "";
            }
            else if (Val == "tillbaka")
            {
                nuvaranderum = "Storflodkant";
            }                              //Dom olika hållen man kan gå
            else if (Val == "fortsätt")
            {
                nuvaranderum = "EvigVägNer2";
            }
            else
            {
                Console.WriteLine("Du valde inget så du bara satt där i en timma och väntar");
            }

        }

        return (nuvaranderum, mat, vatten, LastRoom);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int, string) Båt(List<string> Inventory, int mat, int vatten, string nuvaranderum, string LastRoom)
    {
        String Val = "";
        (mat, vatten) = kanse_blir_törstig(mat, vatten);
        Console.WriteLine("Du hittar en liten båt vid vattnet");
        Console.WriteLine("Du kommer på att du kan försöka laga den"); //lite text som berättar vad du kan göra'
        Console.WriteLine("Skriv 'Fixa' För att laga båten");
        Console.WriteLine("Skriva 'Back' för att gå tillbaka");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
        while (nuvaranderum == "Båt")
        {
            Val = Console.ReadLine();
            Val.ToLower();

            if (Val == "inventory")
            {
                Console.Clear();      //Om man vill öppna inventoriet
                (nuvaranderum, mat, vatten, LastRoom) = inventory(Inventory, mat, vatten, nuvaranderum, LastRoom);
                Val = "";
            }
            else if (Val == "fixa")
            {
                Console.WriteLine("");
                Console.WriteLine("Du väljer att försöka fixa båten");

                if (Inventory.Contains("1 Motor") && Inventory.Contains("1 spak") && Inventory.Contains("1 knapp") && Inventory.Contains("1 pinne") && Inventory.Contains("1 pinne") && Inventory.Contains("1 pinne") && Inventory.Contains("1 pinne") && Inventory.Contains("1 pinne") && Inventory.Contains("1 pinne") && Inventory.Contains("1 Sten") && Inventory.Contains("1 Sten") && Inventory.Contains("1 Sten"))
                {
                    Console.Clear();
                    Console.WriteLine("Du vann");
                }
                else
                {
                    Console.WriteLine("Du försökte men kunde inte laga båten");
                }
            }
            else if (Val == "back")
            {
                nuvaranderum = "Flygner2";
            }                              //Dom olika hållen man kan gå
            else
            {
                Console.WriteLine("Du valde inget så du bara satt där i en timma och väntar");
            }

        }
        return (nuvaranderum, mat, vatten, LastRoom);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int, string) Corridor1(List<string> Inventory, int mat, int vatten, string nuvaranderum, string LastRoom)
    {
        String Val = "";
        List<string> Corridor = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor.Add("1 pinne");
        Corridor.Add("1 Sten");
        Corridor.Add("1 Sten");
        Corridor.Add("1 Tröja");
        Corridor.Add("1 Vatten");
        Corridor.Add("1 Vatten");
        Corridor.Add("1 Vatten");
        Corridor.Add("1 Snacks bar");
        Corridor.Add("1 Snacks bar");

        (mat, vatten) = kanse_blir_törstig(mat, vatten);
        Console.WriteLine("Du är nu i en korridor någonstans i djungeln");  //lite text som berättar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i korridoren");
        Console.WriteLine("Skriva 'Back' för att gå tillbaka eller skriv 'Framåt' för att gå framåt");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
        while (nuvaranderum == "Corridor1")
        {
            Val = Console.ReadLine();
            Val.ToLower();

            if (Val == "leta")
            {
                Console.WriteLine("Du hittade:");      //om man väljer att leta
                for (int i = 0; i < Corridor.Count; i++)
                {
                    Console.WriteLine(Corridor[i]);
                    Inventory.Add(Corridor[i]);
                }
                for (int i = 0; i < Corridor.Count; i++)
                {
                    Corridor.RemoveAt(i);
                }
                Val = "";
            }
            else if (Val == "inventory")
            {
                Console.Clear();      //Om man vill öppna inventoriet
                (nuvaranderum, mat, vatten, LastRoom) = inventory(Inventory, mat, vatten, nuvaranderum, LastRoom);
                Val = "";
            }
            else if (Val == "back")
            {
                nuvaranderum = "Flygner2";
            }                              //Dom olika hållen man kan gå
            else if (Val == "framåt")
            {
                nuvaranderum = "Storöppnign";
            }
            else
            {
                Console.WriteLine("Du valde inget så du bara satt där i en timma och väntar");
            }

        }
        return (nuvaranderum, mat, vatten, LastRoom);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int, string) Corridor2(List<string> Inventory, int mat, int vatten, string nuvaranderum, string LastRoom)
    {
        String Val = "";

        List<string> Corridor = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor.Add("1 pinne");
        Corridor.Add("1 Sten");

        (mat, vatten) = kanse_blir_törstig(mat, vatten);
        Console.WriteLine("Du är nu i en korridor någonstans i djungeln");  //lite text som berättar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i korridoren");
        Console.WriteLine("Skriva 'Back' för att gå tillbaka");
        Console.WriteLine("Skriv 'Höger' för att gå till höger och skriv 'vänster' för att gå vänster");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
        while (nuvaranderum == "Corridor2")
        {
            Val = Console.ReadLine();
            Val.ToLower();
            Console.ReadLine();

            if (Val == "leta")
            {
                Console.WriteLine("Du hittade:");      //om man väljer att leta
                for (int i = 0; i < Corridor.Count; i++)
                {
                    Console.WriteLine(Corridor[i]);
                    Inventory.Add(Corridor[i]);
                }
                for (int i = 0; i < Corridor.Count; i++)
                {
                    Corridor.RemoveAt(i);
                }
                Val = "";
            }
            else if (Val == "inventory")
            {
                Console.Clear();      //Om man vill öppna inventoriet
                (nuvaranderum, mat, vatten, LastRoom) = inventory(Inventory, mat, vatten, nuvaranderum, LastRoom);
                Val = "";
            }
            else if (Val == "back")
            {
                nuvaranderum = "Storöppnign";
            }
            else if (Val == "höger")       //Dom olika hållen man kan gå
            {
                nuvaranderum = "Corridor4";
            }
            else if (Val == "vänster")
            {
                nuvaranderum = "Corridor3";
            }
            else
            {
                Console.WriteLine("Du valde inget så du bara satt där i en timma och väntar");
            }

        }
        return (nuvaranderum, mat, vatten, LastRoom);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int, string) Corridor3(List<string> Inventory, int mat, int vatten, string nuvaranderum, string LastRoom)
    {
        String Val = "";

        List<string> Corridor = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor.Add("1 pinne");
        Corridor.Add("1 pinne");
        Corridor.Add("1 Sten");
        Corridor.Add("1 Sten");
        Corridor.Add("1 Medicin");
        Corridor.Add("1 Snacks bar");

        (mat, vatten) = kanse_blir_törstig(mat, vatten);
        Console.WriteLine("Du är nu i en korridor någonstans i djungeln");  //lite text som berättar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i korridoren");
        Console.WriteLine("Skriva 'Back' för att gå tillbaka eller skriv 'Framåt' för att gå framåt");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
        while (nuvaranderum == "Corridor3")
        {
            Val = Console.ReadLine();
            Val.ToLower();

            if (Val == "leta")
            {
                Console.WriteLine("Du hittade:");      //om man väljer att leta
                for (int i = 0; i < Corridor.Count; i++)
                {
                    Console.WriteLine(Corridor[i]);
                    Inventory.Add(Corridor[i]);
                }

                Val = "";
            }
            else if (Val == "inventory")
            {
                Console.Clear();      //Om man vill öppna inventoriet
                (nuvaranderum, mat, vatten, LastRoom) = inventory(Inventory, mat, vatten, nuvaranderum, LastRoom);
                Val = "";
            }
            else if (Val == "back")
            {
                nuvaranderum = "Corridor2";
            }                                      //Dom olika hållen man kan gå
            else if (Val == "framåt")
            {
                nuvaranderum = "Helikopter";
            }
            else
            {
                Console.WriteLine("Du valde inget så du bara satt där i en timma och väntar");
            }

        }
        return (nuvaranderum, mat, vatten, LastRoom);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int, string) Corridor4(List<string> Inventory, int mat, int vatten, string nuvaranderum, string LastRoom)
    {
        String Val = "";

        List<string> Corridor = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor.Add("1 pinne");
        Corridor.Add("1 Medicin");
        Corridor.Add("1 Medicin");
        Corridor.Add("1 Medicin");
        Corridor.Add("1 Par byxor");

        (mat, vatten) = kanse_blir_törstig(mat, vatten);
        Console.WriteLine("Du är nu i en korridor någonstans i djungeln");  //lite text som berättar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i korridoren");
        Console.WriteLine("Skriva 'Back' för att gå tillbaka eller skriv 'Framåt' för att gå framåt");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
        while (nuvaranderum == "Corridor4")
        {
            Val = Console.ReadLine();
            Val.ToLower();

            if (Val == "leta")
            {
                Console.WriteLine("Du hittade:");      //om man väljer att leta
                for (int i = 0; i < Corridor.Count; i++)
                {
                    Console.WriteLine(Corridor[i]);
                    Inventory.Add(Corridor[i]);
                }
                for (int i = 0; i < Corridor.Count; i++)
                {
                    Corridor.RemoveAt(i);
                }
                Val = "";
            }
            else if (Val == "inventory")
            {
                Console.Clear();      //Om man vill öppna inventoriet
                (nuvaranderum, mat, vatten, LastRoom) = inventory(Inventory, mat, vatten, nuvaranderum, LastRoom);
                Val = "";
            }
            else if (Val == "back")
            {
                nuvaranderum = "Corridor2";
            }                                 //Dom olika hållen man kan gå
            else if (Val == "framåt")
            {
                nuvaranderum = "Orm";
            }
            else
            {
                Console.WriteLine("Du valde inget så du bara satt där i en timma och väntar");
            }

        }
        return (nuvaranderum, mat, vatten, LastRoom);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int, string) Corridor5(List<string> Inventory, int mat, int vatten, string nuvaranderum, string LastRoom)
    {
        String Val = "";

        List<string> Corridor = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor.Add("1 pinne");
        Corridor.Add("1 Sten");
        Corridor.Add("1 Medicin");
        Corridor.Add("1 Medicin");
        Corridor.Add("1 Vatten");

        (mat, vatten) = kanse_blir_törstig(mat, vatten);
        Console.WriteLine("Du är nu i en korridor någonstans i djungeln");  //lite text som berättar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i korridoren");
        Console.WriteLine("Skriva 'Back' för att gå tillbaka eller skriv 'Framåt' för att gå framåt");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
        while (nuvaranderum == "Corridor5")
        {
            Val = Console.ReadLine();
            Val.ToLower();

            if (Val == "leta")
            {
                Console.WriteLine("Du hittade:");      //om man väljer att leta
                for (int i = 0; i < Corridor.Count; i++)
                {
                    Console.WriteLine(Corridor[i]);
                    Inventory.Add(Corridor[i]);
                }
                for (int i = 0; i < Corridor.Count; i++)
                {
                    Corridor.RemoveAt(i);
                }
                Val = "";
            }
            else if (Val == "inventory")
            {
                Console.Clear();      //Om man vill öppna inventoriet
                (nuvaranderum, mat, vatten, LastRoom) = inventory(Inventory, mat, vatten, nuvaranderum, LastRoom);
                Val = "";
            }
            else if (Val == "back")
            {
                nuvaranderum = "Orm";
            }                                            //Dom olika hållen man kan gå
            else if (Val == "framåt")
            {
                nuvaranderum = "Corridor6";
            }
            else
            {
                Console.WriteLine("Du valde inget så du bara satt där i en timma och väntar");
            }

        }
        return (nuvaranderum, mat, vatten, LastRoom);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int, string) Corridor6(List<string> Inventory, int mat, int vatten, string nuvaranderum, string LastRoom)
    {
        String Val = "";

        List<string> Corridor = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor.Add("1 pinne");
        Corridor.Add("1 pinne");
        Corridor.Add("1 Sten");
        Corridor.Add("1 Sten");
        Corridor.Add("1 Tröja");
        Corridor.Add("1 Vatten");

        (mat, vatten) = kanse_blir_törstig(mat, vatten);
        Console.WriteLine("Du är nu i en korridor någonstans i djungeln");  //lite text som berättar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i korridoren");
        Console.WriteLine("Skriva 'Back' för att gå tillbaka eller skriv 'Framåt' för att gå framåt");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
        while (nuvaranderum == "Corridor6")
        {
            Val = Console.ReadLine();
            Val.ToLower();

            if (Val == "leta")
            {
                Console.WriteLine("Du hittade:");      //om man väljer att leta
                for (int i = 0; i < Corridor.Count; i++)
                {
                    Console.WriteLine(Corridor[i]);
                    Inventory.Add(Corridor[i]);
                }
                for (int i = 0; i < Corridor.Count; i++)
                {
                    Corridor.RemoveAt(i);
                }
                Val = "";
            }
            else if (Val == "inventory")
            {
                Console.Clear();      //Om man vill öppna inventoriet
                (nuvaranderum, mat, vatten, LastRoom) = inventory(Inventory, mat, vatten, nuvaranderum, LastRoom);
                Val = "";
            }
            else if (Val == "back")
            {
                nuvaranderum = "Corridor5";
            }                           //Dom olika hållen man kan gå
            else if (Val == "framåt")
            {
                nuvaranderum = "Corridor7";
            }
            else
            {
                Console.WriteLine("Du valde inget så du bara satt där i en timma och väntar");
            }

        }
        return (nuvaranderum, mat, vatten, LastRoom);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int, string) Corridor7(List<string> Inventory, int mat, int vatten, string nuvaranderum, string LastRoom)
    {
        String Val = "";

        List<string> Corridor = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor.Add("1 pinne");
        Corridor.Add("1 pinne");
        Corridor.Add("1 Sten");
        Corridor.Add("1 Vatten");
        Corridor.Add("1 Medicin");

        (mat, vatten) = kanse_blir_törstig(mat, vatten);
        Console.WriteLine("Du är nu i en korridor någonstans i djungeln");  //lite text som berättar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i korridoren");
        Console.WriteLine("Skriva 'Back' för att gå tillbaka eller skriv 'Framåt' för att gå framåt");
        Console.WriteLine("Skriv 'Höger' för att gå till höger och skriv 'vänster' för att gå vänster");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
        while (nuvaranderum == "Corridor7")
        {
            Val = Console.ReadLine();
            Val.ToLower();

            if (Val == "leta")
            {
                Console.WriteLine("Du hittade:");      //om man väljer att leta
                for (int i = 0; i < Corridor.Count; i++)
                {
                    Console.WriteLine(Corridor[i]);
                    Inventory.Add(Corridor[i]);
                }
                for (int i = 0; i < Corridor.Count; i++)
                {
                    Corridor.RemoveAt(i);
                }
                Val = "";
            }
            else if (Val == "inventory")
            {
                Console.Clear();      //Om man vill öppna inventoriet
                (nuvaranderum, mat, vatten, LastRoom) = inventory(Inventory, mat, vatten, nuvaranderum, LastRoom);
                Val = "";
            }
            else if (Val == "back")
            {
                nuvaranderum = "Corridor6";
            }
            else if (Val == "höger")       //Dom olika hållen man kan gå
            {
                nuvaranderum = "Corridor8";
            }
            else if (Val == "vänster")
            {
                nuvaranderum = "Corridor17";
            }
            else if (Val == "framåt")
            {
                nuvaranderum = "Corridor15";
            }
            else
            {
                Console.WriteLine("Du valde inget så du bara satt där i en timma och väntar");
            }

        }
        return (nuvaranderum, mat, vatten, LastRoom);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int, string) Corridor8(List<string> Inventory, int mat, int vatten, string nuvaranderum, string LastRoom)
    {
        String Val = "";

        List<string> Corridor = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor.Add("1 pinne");
        Corridor.Add("1 pinne");
        Corridor.Add("1 Sten");
        Corridor.Add("1 Medecin");
        Corridor.Add("1 Snacks bar");
        Corridor.Add("1 Vatten");

        (mat, vatten) = kanse_blir_törstig(mat, vatten);
        Console.WriteLine("Du är nu i en korridor någonstans i djungeln");  //lite text som berättar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i korridoren");
        Console.WriteLine("Skriva 'Back' för att gå tillbaka eller skriv 'Framåt' för att gå framåt");
        Console.WriteLine("Skriv 'vänster' för att gå vänster");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
        while (nuvaranderum == "Corridor8")
        {
            Val = Console.ReadLine();
            Val.ToLower();

            if (Val == "leta")
            {
                Console.WriteLine("Du hittade:");      //om man väljer att leta
                for (int i = 0; i < Corridor.Count; i++)
                {
                    Console.WriteLine(Corridor[i]);
                    Inventory.Add(Corridor[i]);
                }
                for (int i = 0; i < Corridor.Count; i++)
                {
                    Corridor.RemoveAt(i);
                }
                Val = "";
            }
            else if (Val == "inventory")
            {
                Console.Clear();      //Om man vill öppna inventoriet
                (nuvaranderum, mat, vatten, LastRoom) = inventory(Inventory, mat, vatten, nuvaranderum, LastRoom);
                Val = "";
            }
            else if (Val == "back")
            {
                nuvaranderum = "Corridor7";
            }                              //Dom olika hållen man kan gå
            else if (Val == "vänster")
            {
                nuvaranderum = "Corridor10";
            }
            else if (Val == "framåt")
            {
                nuvaranderum = "Corridor9";
            }
            else
            {
                Console.WriteLine("Du valde inget så du bara satt där i en timma och väntar");
            }

        }
        return (nuvaranderum, mat, vatten, LastRoom);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int, string) Corridor9(List<string> Inventory, int mat, int vatten, string nuvaranderum, string LastRoom)
    {
        String Val = "";

        List<string> Corridor = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor.Add("1 pinne");
        Corridor.Add("1 pinne");
        Corridor.Add("1 Tröja");
        Corridor.Add("1 Vatten");
        Corridor.Add("1 Vatten");
        Corridor.Add("1 Snacks bar");

        (mat, vatten) = kanse_blir_törstig(mat, vatten);
        Console.WriteLine("Du är nu i en korridor någonstans i djungeln");  //lite text som berättar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i korridoren");
        Console.WriteLine("Du är i en återvändsgränd så ända du kan göra är att gå tillbaka");
        Console.WriteLine("Skriv 'Back' för att gå tillbaka");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
        while (nuvaranderum == "Corridor9")
        {
            Val = Console.ReadLine();
            Val.ToLower();

            if (Val == "leta")
            {
                Console.WriteLine("Du hittade:");      //om man väljer att leta
                for (int i = 0; i < Corridor.Count; i++)
                {
                    Console.WriteLine(Corridor[i]);
                    Inventory.Add(Corridor[i]);
                }
                for (int i = 0; i < Corridor.Count; i++)
                {
                    Corridor.RemoveAt(i);
                }
                Val = "";
            }
            else if (Val == "inventory")
            {
                Console.Clear();      //Om man vill öppna inventoriet
                (nuvaranderum, mat, vatten, LastRoom) = inventory(Inventory, mat, vatten, nuvaranderum, LastRoom);
                Val = "";
            }
            else if (Val == "back")
            {
                nuvaranderum = "Corridor8";
            }                            //Dom olika hållen man kan gå
            else
            {
                Console.WriteLine("Du valde inget så du bara satt där i en timma och väntar");
            }

        }
        return (nuvaranderum, mat, vatten, LastRoom);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int, string) Corridor10(List<string> Inventory, int mat, int vatten, string nuvaranderum, string LastRoom)
    {
        String Val = "";

        List<string> Corridor = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor.Add("1 Sten");
        Corridor.Add("1 Sten");
        Corridor.Add("1 Medicin");

        (mat, vatten) = kanse_blir_törstig(mat, vatten);
        Console.WriteLine("Du är nu i en korridor någonstans i djungeln");  //lite text som berättar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i korridoren");
        Console.WriteLine("Skriva 'Back' för att gå tillbaka eller skriv 'Framåt' för att gå framåt");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
        while (nuvaranderum == "Corridor10")
        {
            Val = Console.ReadLine();
            Val.ToLower();

            if (Val == "leta")
            {
                Console.WriteLine("Du hittade:");      //om man väljer att leta
                for (int i = 0; i < Corridor.Count; i++)
                {
                    Console.WriteLine(Corridor[i]);
                    Inventory.Add(Corridor[i]);
                }
                for (int i = 0; i < Corridor.Count; i++)
                {
                    Corridor.RemoveAt(i);
                }
                Val = "";
            }
            else if (Val == "inventory")
            {
                Console.Clear();      //Om man vill öppna inventoriet
                (nuvaranderum, mat, vatten, LastRoom) = inventory(Inventory, mat, vatten, nuvaranderum, LastRoom);
                Val = "";
            }
            else if (Val == "back")
            {
                nuvaranderum = "Corridor8";
            }                         //Dom olika hållen man kan gå
            else if (Val == "framåt")
            {
                nuvaranderum = "Corridor11";
            }
            else
            {
                Console.WriteLine("Du valde inget så du bara satt där i en timma och väntar");
            }

        }
        return (nuvaranderum, mat, vatten, LastRoom);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int, string) Corridor11(List<string> Inventory, int mat, int vatten, string nuvaranderum, string LastRoom)
    {
        String Val = "";

        List<string> Corridor = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor.Add("1 pinne");
        Corridor.Add("1 pinne");
        Corridor.Add("1 pinne");
        Corridor.Add("1 Sten");
        Corridor.Add("1 Sten");

        (mat, vatten) = kanse_blir_törstig(mat, vatten);
        Console.WriteLine("Du är nu i en korridor någonstans i djungeln");  //lite text som berättar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i korridoren");
        Console.WriteLine("Skriva 'Back' för att gå tillbaka eller skriv 'Framåt' för att gå framåt");
        Console.WriteLine("Skriv 'Höger' för att gå till höger");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
        while (nuvaranderum == "Corridor11")
        {
            Val = Console.ReadLine();
            Val.ToLower();

            if (Val == "leta")
            {
                Console.WriteLine("Du hittade:");      //om man väljer att leta
                for (int i = 0; i < Corridor.Count; i++)
                {
                    Console.WriteLine(Corridor[i]);
                    Inventory.Add(Corridor[i]);
                }
                for (int i = 0; i < Corridor.Count; i++)
                {
                    Corridor.RemoveAt(i);
                }
                Val = "";
            }
            else if (Val == "inventory")
            {
                Console.Clear();      //Om man vill öppna inventoriet
                (nuvaranderum, mat, vatten, LastRoom) = inventory(Inventory, mat, vatten, nuvaranderum, LastRoom);
                Val = "";
            }
            else if (Val == "back")
            {
                nuvaranderum = "Corridor10";
            }
            else if (Val == "höger")       //Dom olika hållen man kan gå
            {
                nuvaranderum = "Corridor19";
            }
            else if (Val == "framåt")
            {
                nuvaranderum = "Corridor11";
            }
            else
            {
                Console.WriteLine("Du valde inget så du bara satt där i en timma och väntar");
            }

        }
        return (nuvaranderum, mat, vatten, LastRoom);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int, string) Corridor12(List<string> Inventory, int mat, int vatten, string nuvaranderum, string LastRoom)
    {
        String Val = "";

        List<string> Corridor = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor.Add("1 Sten");

        (mat, vatten) = kanse_blir_törstig(mat, vatten);
        Console.WriteLine("Du är nu i en korridor någonstans i djungeln");  //lite text som berättar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i korridoren");
        Console.WriteLine("Skriva 'Back' för att gå tillbaka eller skriv 'Framåt' för att gå framåt");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
        while (nuvaranderum == "Corridor12")
        {
            Val = Console.ReadLine();
            Val.ToLower();

            if (Val == "leta")
            {
                Console.WriteLine("Du hittade:");      //om man väljer att leta
                for (int i = 0; i < Corridor.Count; i++)
                {
                    Console.WriteLine(Corridor[i]);
                    Inventory.Add(Corridor[i]);
                }
                for (int i = 0; i < Corridor.Count; i++)
                {
                    Corridor.RemoveAt(i);
                }
                Val = "";
            }
            else if (Val == "inventory")
            {
                Console.Clear();      //Om man vill öppna inventoriet
                (nuvaranderum, mat, vatten, LastRoom) = inventory(Inventory, mat, vatten, nuvaranderum, LastRoom);
                Val = "";
            }
            else if (Val == "back")
            {
                nuvaranderum = "Corridor11";
            }                           //Dom olika hållen man kan gå
            else if (Val == "framåt")
            {
                nuvaranderum = "Corridor13";
            }
            else
            {
                Console.WriteLine("Du valde inget så du bara satt där i en timma och väntar");
            }

        }
        return (nuvaranderum, mat, vatten, LastRoom);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int, string) Corridor13(List<string> Inventory, int mat, int vatten, string nuvaranderum, string LastRoom)
    {
        String Val = "";

        List<string> Corridor = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor.Add("1 pinne");
        Corridor.Add("1 pinne");

        (mat, vatten) = kanse_blir_törstig(mat, vatten);
        Console.WriteLine("Du är nu i en korridor någonstans i djungeln");  //lite text som berättar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i korridoren");
        Console.WriteLine("Skriva 'Back' för att gå tillbaka eller skriv 'Framåt' för att gå framåt");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
        while (nuvaranderum == "Corridor13")
        {
            Val = Console.ReadLine();
            Val.ToLower();

            if (Val == "leta")
            {
                Console.WriteLine("Du hittade:");      //om man väljer att leta
                for (int i = 0; i < Corridor.Count; i++)
                {
                    Console.WriteLine(Corridor[i]);
                    Inventory.Add(Corridor[i]);
                }
                for (int i = 0; i < Corridor.Count; i++)
                {
                    Corridor.RemoveAt(i);
                }
                Val = "";
            }
            else if (Val == "inventory")
            {
                Console.Clear();      //Om man vill öppna inventoriet
                (nuvaranderum, mat, vatten, LastRoom) = inventory(Inventory, mat, vatten, nuvaranderum, LastRoom);
                Val = "";
            }
            else if (Val == "back")
            {
                nuvaranderum = "Corridor12";
            }                            //Dom olika hållen man kan gå
            else if (Val == "framåt")
            {
                nuvaranderum = "Corridor14";
            }
            else
            {
                Console.WriteLine("Du valde inget så du bara satt där i en timma och väntar");
            }

        }
        return (nuvaranderum, mat, vatten, LastRoom);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int, string) Corridor14(List<string> Inventory, int mat, int vatten, string nuvaranderum, string LastRoom)
    {
        String Val = "";

        List<string> Corridor = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor.Add("1 pinne");
        Corridor.Add("1 Sten");
        Corridor.Add("1 Vatten");
        Corridor.Add("1 Tröja");

        (mat, vatten) = kanse_blir_törstig(mat, vatten);
        Console.WriteLine("Du är nu i en korridor någonstans i djungeln");  //lite text som berättar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i korridoren");
        Console.WriteLine("Skriva 'Back' för att gå tillbaka eller skriv 'Framåt' för att gå framåt");
        Console.WriteLine("Skriv 'vänster' för att gå vänster");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
        while (nuvaranderum == "Corridor14")
        {
            Val = Console.ReadLine();
            Val.ToLower();

            if (Val == "leta")
            {
                Console.WriteLine("Du hittade:");      //om man väljer att leta
                for (int i = 0; i < Corridor.Count; i++)
                {
                    Console.WriteLine(Corridor[i]);
                    Inventory.Add(Corridor[i]);
                }
                for (int i = 0; i < Corridor.Count; i++)
                {
                    Corridor.RemoveAt(i);
                }
                Val = "";
            }
            else if (Val == "inventory")
            {
                Console.Clear();      //Om man vill öppna inventoriet
                (nuvaranderum, mat, vatten, LastRoom) = inventory(Inventory, mat, vatten, nuvaranderum, LastRoom);
                Val = "";
            }
            else if (Val == "back")
            {
                nuvaranderum = "Corridor13";
            }                        //Dom olika hållen man kan gå
            else if (Val == "vänster")
            {
                nuvaranderum = "Corridor15";
            }
            else if (Val == "framåt")
            {
                nuvaranderum = "Corridor16";
            }
            else
            {
                Console.WriteLine("Du valde inget så du bara satt där i en timma och väntar");
            }

        }
        return (nuvaranderum, mat, vatten, LastRoom);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int, string) Corridor15(List<string> Inventory, int mat, int vatten, string nuvaranderum, string LastRoom)
    {
        String Val = "";

        List<string> Corridor = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor.Add("1 pinne");
        Corridor.Add("1 pinne");

        (mat, vatten) = kanse_blir_törstig(mat, vatten);
        Console.WriteLine("Du är nu i en korridor någonstans i djungeln");  //lite text som berättar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i korridoren");
        Console.WriteLine("Skriva 'Back' för att gå tillbaka eller skriv 'Framåt' för att gå framåt");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
        while (nuvaranderum == "Corridor15")
        {
            Val = Console.ReadLine();
            Val.ToLower();

            if (Val == "leta")
            {
                Console.WriteLine("Du hittade:");      //om man väljer att leta
                for (int i = 0; i < Corridor.Count; i++)
                {
                    Console.WriteLine(Corridor[i]);
                    Inventory.Add(Corridor[i]);
                }
                for (int i = 0; i < Corridor.Count; i++)
                {
                    Corridor.RemoveAt(i);
                }
                Val = "";
            }
            else if (Val == "inventory")
            {
                Console.Clear();      //Om man vill öppna inventoriet
                (nuvaranderum, mat, vatten, LastRoom) = inventory(Inventory, mat, vatten, nuvaranderum, LastRoom);
                Val = "";
            }
            else if (Val == "back")
            {
                nuvaranderum = "Corridor14";
            }                        //Dom olika hållen man kan gå
            else if (Val == "framåt")
            {
                nuvaranderum = "Corridor7";
            }
            else
            {
                Console.WriteLine("Du valde inget så du bara satt där i en timma och väntar");
            }

        }
        return (nuvaranderum, mat, vatten, LastRoom);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int, string) Corridor16(List<string> Inventory, int mat, int vatten, string nuvaranderum, string LastRoom)
    {
        String Val = "";

        List<string> Corridor = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor.Add("1 pinne");
        Corridor.Add("1 Sten");
        Corridor.Add("1 Sten");
        Corridor.Add("1 Sten");

        (mat, vatten) = kanse_blir_törstig(mat, vatten);
        Console.WriteLine("Du är nu i en korridor någonstans i djungeln");  //lite text som berättar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i korridoren");
        Console.WriteLine("Skriva 'Back' för att gå tillbaka eller skriv 'Framåt' för att gå framåt");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
        while (nuvaranderum == "Corridor16")
        {
            Val = Console.ReadLine();
            Val.ToLower();

            if (Val == "leta")
            {
                Console.WriteLine("Du hittade:");      //om man väljer att leta
                for (int i = 0; i < Corridor.Count; i++)
                {
                    Console.WriteLine(Corridor[i]);
                    Inventory.Add(Corridor[i]);
                }
                for (int i = 0; i < Corridor.Count; i++)
                {
                    Corridor.RemoveAt(i);
                }
                Val = "";
            }
            else if (Val == "inventory")
            {
                Console.Clear();      //Om man vill öppna inventoriet
                (nuvaranderum, mat, vatten, LastRoom) = inventory(Inventory, mat, vatten, nuvaranderum, LastRoom);
                Val = "";
            }
            else if (Val == "back")
            {
                nuvaranderum = "Corridor14";
            }                           //Dom olika hållen man kan gå
            else if (Val == "framåt")
            {
                nuvaranderum = "Corridor18";
            }
            else
            {
                Console.WriteLine("Du valde inget så du bara satt där i en timma och väntar");
            }

        }
        return (nuvaranderum, mat, vatten, LastRoom);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int, string) Corridor17(List<string> Inventory, int mat, int vatten, string nuvaranderum, string LastRoom)
    {
        String Val = "";

        List<string> Corridor = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor.Add("1 pinne");
        Corridor.Add("1 pinne");
        Corridor.Add("1 Sten");
        Corridor.Add("1 Sten");
        Corridor.Add("1 Snacks bar");
        Corridor.Add("1 Sten");

        (mat, vatten) = kanse_blir_törstig(mat, vatten);
        Console.WriteLine("Du är nu i en korridor någonstans i djungeln");  //lite text som berättar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i korridoren");
        Console.WriteLine("Skriva 'Back' för att gå tillbaka eller skriv 'Framåt' för att gå framåt");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
        while (nuvaranderum == "Corridor17")
        {
            Val = Console.ReadLine();
            Val.ToLower();

            if (Val == "leta")
            {
                Console.WriteLine("Du hittade:");      //om man väljer att leta
                for (int i = 0; i < Corridor.Count; i++)
                {
                    Console.WriteLine(Corridor[i]);
                    Inventory.Add(Corridor[i]);
                }
                for (int i = 0; i < Corridor.Count; i++)
                {
                    Corridor.RemoveAt(i);
                }
                Val = "";
            }
            else if (Val == "inventory")
            {
                Console.Clear();      //Om man vill öppna inventoriet
                (nuvaranderum, mat, vatten, LastRoom) = inventory(Inventory, mat, vatten, nuvaranderum, LastRoom);
                Val = "";
            }
            else if (Val == "back")
            {
                nuvaranderum = "Corridor18";
            }                            //Dom olika hållen man kan gå
            else if (Val == "framåt")
            {
                nuvaranderum = "Corridor7";
            }
            else
            {
                Console.WriteLine("Du valde inget så du bara satt där i en timma och väntar");
            }

        }
        return (nuvaranderum, mat, vatten, LastRoom);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int, string) Corridor18(List<string> Inventory, int mat, int vatten, string nuvaranderum, string LastRoom)
    {
        String Val = "";

        (mat, vatten) = kanse_blir_törstig(mat, vatten);
        List<string> Corridor = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor.Add("1 pinne");
        Corridor.Add("1 pinne");
        Corridor.Add("1 pinne");
        Corridor.Add("1 pinne");
        Corridor.Add("1 pinne");
        Corridor.Add("1 Sten");
        Corridor.Add("1 Sten");
        Corridor.Add("1 Medicin");
        Corridor.Add("1 Snacks bar");

        Console.WriteLine("Du är nu i en korridor någonstans i djungeln");  //lite text som berättar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i korridoren");
        Console.WriteLine("Skriva 'Back' för att gå tillbaka");
        Console.WriteLine("Skriv 'Höger' för att gå till höger och skriv 'vänster' för att gå vänster");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
        while (nuvaranderum == "Corridor18")
        {
            Val = Console.ReadLine();
            Val.ToLower();

            if (Val == "leta")
            {
                Console.WriteLine("Du hittade:");      //om man väljer att leta
                for (int i = 0; i < Corridor.Count; i++)
                {
                    Console.WriteLine(Corridor[i]);
                    Inventory.Add(Corridor[i]);
                }
                for (int i = 0; i < Corridor.Count; i++)
                {
                    Corridor.RemoveAt(i);
                }
                Val = "";
            }
            else if (Val == "inventory")
            {
                Console.Clear();      //Om man vill öppna inventoriet
                (nuvaranderum, mat, vatten, LastRoom) = inventory(Inventory, mat, vatten, nuvaranderum, LastRoom);
                Val = "";
            }
            else if (Val == "back")
            {
                nuvaranderum = "Storöppnign";
            }
            else if (Val == "höger")       //Dom olika hållen man kan gå
            {
                nuvaranderum = "Corridor17";
            }
            else if (Val == "vänster")
            {
                nuvaranderum = "Corridor16";
            }
            else
            {
                Console.WriteLine("Du valde inget så du bara satt där i en timma och väntar");
            }

        }
        Console.ReadKey();
        return (nuvaranderum, mat, vatten, LastRoom);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int, string) Corridor19(List<string> Inventory, int mat, int vatten, string nuvaranderum, string LastRoom)
    {
        String Val = "";

        List<string> Corridor = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor.Add("1 pinne");
        Corridor.Add("1 pinne");
        Corridor.Add("1 Sten");

        (mat, vatten) = kanse_blir_törstig(mat, vatten);
        Console.WriteLine("Du är nu i en korridor någonstans i djungeln");  //lite text som berättar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i korridoren");
        Console.WriteLine("Skriva 'Back' för att gå tillbaka eller skriv 'Framåt' för att gå framåt");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
        while (nuvaranderum == "Corridor19")
        {
            Val = Console.ReadLine();
            Val.ToLower();

            if (Val == "leta")
            {
                Console.WriteLine("Du hittade:");      //om man väljer att leta
                for (int i = 0; i < Corridor.Count; i++)
                {
                    Console.WriteLine(Corridor[i]);
                    Inventory.Add(Corridor[i]);
                }
                for (int i = 0; i < Corridor.Count; i++)
                {
                    Corridor.RemoveAt(i);
                }
                Val = "";
            }
            else if (Val == "inventory")
            {
                Console.Clear();      //Om man vill öppna inventoriet
                (nuvaranderum, mat, vatten, LastRoom) = inventory(Inventory, mat, vatten, nuvaranderum, LastRoom);
                Val = "";
            }
            else if (Val == "back")
            {
                nuvaranderum = "Corridor11";
            }                          //Dom olika hållen man kan gå
            else if (Val == "framåt")
            {
                nuvaranderum = "Corridor20";
            }
            else
            {
                Console.WriteLine("Du valde inget så du bara satt där i en timma och väntar");
            }

        }
        return (nuvaranderum, mat, vatten, LastRoom);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int, string) Corridor20(List<string> Inventory, int mat, int vatten, string nuvaranderum, string LastRoom)
    {
        String Val = "";

        List<string> Corridor = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor.Add("1 pinne");
        Corridor.Add("1 Sten");
        Corridor.Add("1 Sten");

        (mat, vatten) = kanse_blir_törstig(mat, vatten);
        Console.WriteLine("Du är nu i en korridor någonstans i djungeln");  //lite text som berättar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i korridoren");
        Console.WriteLine("Skriva 'Back' för att gå tillbaka eller skriv 'Framåt' för att gå framåt");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
        while (nuvaranderum == "Corridor20")
        {
            Val = Console.ReadLine();
            Val.ToLower();

            if (Val == "leta")
            {
                Console.WriteLine("Du hittade:");      //om man väljer att leta
                for (int i = 0; i < Corridor.Count; i++)
                {
                    Console.WriteLine(Corridor[i]);
                    Inventory.Add(Corridor[i]);
                }
                for (int i = 0; i < Corridor.Count; i++)
                {
                    Corridor.RemoveAt(i);
                }
                Val = "";
            }
            else if (Val == "inventory")
            {
                Console.Clear();      //Om man vill öppna inventoriet
                (nuvaranderum, mat, vatten, LastRoom) = inventory(Inventory, mat, vatten, nuvaranderum, LastRoom);
                Val = "";
            }
            else if (Val == "back")
            {
                nuvaranderum = "Corridor19";
            }                                //Dom olika hållen man kan gå
            else if (Val == "framåt")
            {
                nuvaranderum = "Corridor21";
            }
            else
            {
                Console.WriteLine("Du valde inget så du bara satt där i en timma och väntar");
            }

        }
        return (nuvaranderum, mat, vatten, LastRoom);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int, string) Corridor21(List<string> Inventory, int mat, int vatten, string nuvaranderum, string LastRoom)
    {
        String Val = "";

        List<string> Corridor = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor.Add("1 pinne");

        (mat, vatten) = kanse_blir_törstig(mat, vatten);
        Console.WriteLine("Du är nu i en korridor någonstans i djungeln");  //lite text som berättar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i korridoren");
        Console.WriteLine("Skriva 'Back' för att gå tillbaka eller skriv 'Framåt' för att gå framåt");
        Console.WriteLine("Skriv 'Höger' för att gå till höger och skriv 'vänster' för att gå vänster");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
        Console.WriteLine("Corridor21");
        while (nuvaranderum == "Corridor21")
        {
            Val = Console.ReadLine();
            Val.ToLower();

            if (Val == "leta")
            {
                Console.WriteLine("Du hittade:");      //om man väljer att leta
                for (int i = 0; i < Corridor.Count; i++)
                {
                    Console.WriteLine(Corridor[i]);
                    Inventory.Add(Corridor[i]);
                }
                for (int i = 0; i < Corridor.Count; i++)
                {
                    Corridor.RemoveAt(i);
                }
                Val = "";
            }
            else if (Val == "inventory")
            {
                Console.Clear();      //Om man vill öppna inventoriet
                (nuvaranderum, mat, vatten, LastRoom) = inventory(Inventory, mat, vatten, nuvaranderum, LastRoom);
                Val = "";
            }
            else if (Val == "back")
            {
                nuvaranderum = "Corridor20";
            }                                //Dom olika hållen man kan gå
            else if (Val == "framåt")
            {
                nuvaranderum = "Storflodkant";
            }
            else
            {
                Console.WriteLine("Du valde inget så du bara satt där i en timma och väntar");
            }

        }
        return (nuvaranderum, mat, vatten, LastRoom);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int, string) inventory(List<string> inventory, int vatten, int mat, string nuvaranderum, string LastRoom)
    {
        bool wannaLeave = false;

        Console.WriteLine("välkommern till inventoriet");
        Console.WriteLine("Mat:" + mat);
        Console.WriteLine("Vatten:" + vatten);
        Console.WriteLine("Föremål du har:");
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
        Console.WriteLine("Föremål du kan tilverka:");

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
        Console.WriteLine("Skriv 'Heal' för att ta lite medicin");
        while (wannaLeave == false)
        {
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
                val = "";
            }
            else if (val == "eat" && inventory.Contains("1 Snacks bar"))
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
                val = "";
            }
            else if (val == "heal" && inventory.Contains("1 Medicin"))
            {
                val = "";
            }
            else if (val == "crafta")
            {
                Console.WriteLine("Vad vill du crafta?");
                val = Console.ReadLine();
                val.ToLower();

                if (val == "3 Cloth")
                {
                    inventory.Add("3 Cloth");
                    inventory.Remove("1 Tröja");
                }
                val = "";
            }
            else if (val == "back")
            {
                LastRoom = nuvaranderum;
                nuvaranderum = "LastRoom";
                wannaLeave = true;
                val = "";
            }
            else
            {
                Console.WriteLine("Du valde inget");
                val = "";
            }
        }
        Console.Clear();
        return (nuvaranderum, mat, vatten, LastRoom);
    }

    public static (string, int) EvigVägUpp2(int mat, string nuvaranderum)
    {
        nuvaranderum = "Evigvägupp";
        return (nuvaranderum, mat);
    }

    public static (string, int) EvigVägNer2(int mat, string nuvaranderum)
    {
        nuvaranderum = "Evigvägner";
        return (nuvaranderum, mat);
    }

    public static (string, string) LastRoom(string LastRoom, string nuvaranderum)
    {
        nuvaranderum = LastRoom;
        return (nuvaranderum, LastRoom);
    }
    public static (int, int) kanse_blir_törstig(int mat, int vatten)
    {
        if (mat < 50 && mat >= 25)
        {
            Console.WriteLine("Du börjar känna dig hunrig");
        }
        else if (mat < 25 && mat >= 10)
        {
            Console.WriteLine("Du är nu hunrig");
        }
        else if (mat < 10)
        {
            Console.WriteLine("Du svältar snart");
        }

        if (vatten < 60 && vatten >= 40)
        {
            Console.WriteLine("Du börjar känna dig törstig");
        }
        else if (vatten < 40 && vatten >= 20)
        {
            Console.WriteLine("Du är nu törstig");
        }
        else if (vatten < 20)
        {
            Console.WriteLine("Du dör snart av törst");
        }
        return (mat, vatten);
    }

}