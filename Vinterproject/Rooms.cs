class Rooms
{
    public static (string, int, int) Flygner2(List<string> Inventory, int mat, int vatten, string nuvaranderum)
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

        Console.WriteLine("Du är nu tillbaka vid flygplanet");  //lite text som bärätar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i corridoren");
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

                Val = "";
            }
            else if (Val == "inventory")
            {
                Console.Clear();      //Om man vill öppna inventoriet
                (nuvaranderum, mat, vatten) = inventory(Inventory, mat, vatten, nuvaranderum);
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
        Console.ReadLine();
        return (nuvaranderum, mat, vatten);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int) Litenflod(List<string> Inventory, int mat, int vatten, string nuvaranderum)
    {
        Console.ReadLine();
        return (nuvaranderum, mat, vatten);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int) Hem(List<string> Inventory, int mat, int vatten, string nuvaranderum)
    {
        Console.ReadLine();
        return (nuvaranderum, mat, vatten);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int) Storöppnign(List<string> Inventory, int mat, int vatten, string nuvaranderum)
    {
        Console.WriteLine("Storöppnign");
        Console.ReadLine();
        return (nuvaranderum, mat, vatten);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int) Helikopterner(List<string> Inventory, int mat, int vatten, string nuvaranderum)
    {
        Console.ReadLine();
        return (nuvaranderum, mat, vatten);

    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int) Orm(List<string> Inventory, int mat, int vatten, string nuvaranderum)
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


        Console.WriteLine("Du gick in i ett stort runt rum i jungen");
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
                    Console.WriteLine("Du försökte göra en lätt attack men missade fienden.");
                }
                else                        //spelaren lightattack kod
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
                    Console.WriteLine("Du försöker göra en svår attack men missade fienden");
                }
                else                //Spelaren hardattack kod
                {
                    int spelaredamage = Skada.Next(2 * maxskada);
                    nuvaraneaihp -= spelaredamage;
                    Console.WriteLine("Du attackerar ormen med en svår attack och gör " + spelaredamage + " i skada");
                    Console.WriteLine("Ormen har nu " + nuvaraneaihp + " i liv(hp).");
                }
            }
            //------------------------------------------------------------------------------------------------------
            else if (spelaretypavattack == "f")                       //Om man försöker fly
            {
                Console.WriteLine("Du försöte fly men ormen lyckades döda dig");
                Console.ReadLine();
                Death.snake();
            }
            // ------------------------------------------------------------------
            else                 //om man inte slår
            {
                Console.WriteLine("Du valde inget så du slår ingen.");
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
                    Console.WriteLine("Ormen försökta göra en lätt attack men missade dig.");
                }
                else                        //ai lightattack kod
                {
                    int aidamage = Skada.Next(maxskada);
                    nuvaranespelarhp -= aidamage;
                    Console.WriteLine("Ormen attackerar dig med en lättattack och gör " + aidamage + " i skada");
                    Console.WriteLine("Du har nu " + nuvaranespelarhp + " i liv(hp).");
                }
            }
            // ------------------------------------------------------------------
            else if (tmpaitypavattack <= 1)
            {
                int tempmisschans = misschans.Next(100);
                if (tempmisschans <= hardattackmisschans)
                {
                    Console.WriteLine("Ormen försökte göra en svår attack men missade dig");
                }
                else                   //ai hardattack kod
                {
                    int aidamage = Skada.Next(2 * maxskada);
                    nuvaranespelarhp -= aidamage;
                    Console.WriteLine("Ormen attackerar dig med en svår attack och gör " + aidamage + " i skada");
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
            Console.WriteLine("Kanse kan du andvända den för att fly härifrån");
            Console.WriteLine("Sen kommer du på att du kanse kan äta ormen för mat");
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

            Console.WriteLine("Du är i rummet där du dödade ormen");  //lite text som berätar vad du kan göra
            Console.WriteLine("Skriva 'Back' för att gå tillbaka eller skriv 'Framåt' för att gå framåt");
            Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");

            Val = Console.ReadLine();
            Val.ToLower();


            if (Val == "inventory")
            {
                Console.Clear();      //Om man vill öppna inventoriet
                (nuvaranderum, mat, vatten) = inventory(Inventory, mat, vatten, nuvaranderum);
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

        Console.ReadLine();
        return (nuvaranderum, mat, vatten);

    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int) Storflodkant(List<string> Inventory, int mat, int vatten, string nuvaranderum)
    {
        Console.ReadLine();
        return (nuvaranderum, mat, vatten);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int) Evigvägupp(List<string> Inventory, int mat, int vatten, string nuvaranderum)
    {
        Console.ReadLine();
        return (nuvaranderum, mat, vatten);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int) Evigvägner(List<string> Inventory, int mat, int vatten, string nuvaranderum)
    {
        Console.ReadLine();
        return (nuvaranderum, mat, vatten);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int) Båt(List<string> Inventory, int mat, int vatten, string nuvaranderum)
    {
        Console.ReadLine();
        return (nuvaranderum, mat, vatten);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int) Corridor1(List<string> Inventory, int mat, int vatten, string nuvaranderum)
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

        Console.WriteLine("Du är nu i en corridor någonstans i junglen");  //lite text som bärätar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i corridoren");
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
                (nuvaranderum, mat, vatten) = inventory(Inventory, mat, vatten, nuvaranderum);
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
        Console.ReadLine();
        return (nuvaranderum, mat, vatten);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int) Corridor2(List<string> Inventory, int mat, int vatten, string nuvaranderum)
    {
        String Val = "";

        List<string> Corridor = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor.Add("1 pinne");
        Corridor.Add("1 Sten");

        Console.WriteLine("Du är nu i en corridor någonstans i junglen");  //lite text som bärätar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i corridoren");
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
                (nuvaranderum, mat, vatten) = inventory(Inventory, mat, vatten, nuvaranderum);
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
        Console.ReadLine();
        return (nuvaranderum, mat, vatten);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int) Corridor3(List<string> Inventory, int mat, int vatten, string nuvaranderum)
    {
        String Val = "";

        List<string> Corridor = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor.Add("1 pinne");
        Corridor.Add("1 pinne");
        Corridor.Add("1 Sten");
        Corridor.Add("1 Sten");
        Corridor.Add("1 Medecin");
        Corridor.Add("1 Snacks bar");

        Console.WriteLine("Du är nu i en corridor någonstans i junglen");  //lite text som bärätar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i corridoren");
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
                (nuvaranderum, mat, vatten) = inventory(Inventory, mat, vatten, nuvaranderum);
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
        Console.ReadLine();
        return (nuvaranderum, mat, vatten);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int) Corridor4(List<string> Inventory, int mat, int vatten, string nuvaranderum)
    {
        String Val = "";

        List<string> Corridor = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor.Add("1 pinne");
        Corridor.Add("1 Medecin");
        Corridor.Add("1 Medecin");
        Corridor.Add("1 Medecin");
        Corridor.Add("1 Par byxor");

        Console.WriteLine("Du är nu i en corridor någonstans i junglen");  //lite text som bärätar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i corridoren");
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
                (nuvaranderum, mat, vatten) = inventory(Inventory, mat, vatten, nuvaranderum);
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
        Console.ReadLine();
        return (nuvaranderum, mat, vatten);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int) Corridor5(List<string> Inventory, int mat, int vatten, string nuvaranderum)
    {
        String Val = "";

        List<string> Corridor = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor.Add("1 pinne");
        Corridor.Add("1 Sten");
        Corridor.Add("1 Medecin");
        Corridor.Add("1 Medecin");
        Corridor.Add("1 Vatten");

        Console.WriteLine("Du är nu i en corridor någonstans i junglen");  //lite text som bärätar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i corridoren");
        Console.WriteLine("Skriva 'Back' för att gå tillbaka eller skriv 'Framåt' för att gå framåt");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
        Console.WriteLine("Corridor5");
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
                (nuvaranderum, mat, vatten) = inventory(Inventory, mat, vatten, nuvaranderum);
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
        Console.ReadLine();
        return (nuvaranderum, mat, vatten);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int) Corridor6(List<string> Inventory, int mat, int vatten, string nuvaranderum)
    {
        String Val = "";

        List<string> Corridor = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor.Add("1 pinne");
        Corridor.Add("1 pinne");
        Corridor.Add("1 Sten");
        Corridor.Add("1 Sten");
        Corridor.Add("1 Tröja");
        Corridor.Add("1 Vatten");

        Console.WriteLine("Du är nu i en corridor någonstans i junglen");  //lite text som bärätar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i corridoren");
        Console.WriteLine("Skriva 'Back' för att gå tillbaka eller skriv 'Framåt' för att gå framåt");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
        Console.WriteLine("Corridor6");
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
                (nuvaranderum, mat, vatten) = inventory(Inventory, mat, vatten, nuvaranderum);
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
        Console.ReadLine();
        return (nuvaranderum, mat, vatten);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int) Corridor7(List<string> Inventory, int mat, int vatten, string nuvaranderum)
    {
        String Val = "";

        List<string> Corridor = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor.Add("1 pinne");
        Corridor.Add("1 pinne");
        Corridor.Add("1 Sten");
        Corridor.Add("1 Vatten");
        Corridor.Add("1 Medecin");

        Console.WriteLine("Du är nu i en corridor någonstans i junglen");  //lite text som bärätar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i corridoren");
        Console.WriteLine("Skriva 'Back' för att gå tillbaka eller skriv 'Framåt' för att gå framåt");
        Console.WriteLine("Skriv 'Höger' för att gå till höger och skriv 'vänster' för att gå vänster");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
        Console.WriteLine("Corridor7");
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
                (nuvaranderum, mat, vatten) = inventory(Inventory, mat, vatten, nuvaranderum);
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
        Console.ReadLine();
        return (nuvaranderum, mat, vatten);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int) Corridor8(List<string> Inventory, int mat, int vatten, string nuvaranderum)
    {
        String Val = "";

        List<string> Corridor = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor.Add("1 pinne");
        Corridor.Add("1 pinne");
        Corridor.Add("1 Sten");
        Corridor.Add("1 Medecin");
        Corridor.Add("1 Snacks bar");
        Corridor.Add("1 Vatten");

        Console.WriteLine("Du är nu i en corridor någonstans i junglen");  //lite text som bärätar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i corridoren");
        Console.WriteLine("Skriva 'Back' för att gå tillbaka eller skriv 'Framåt' för att gå framåt");
        Console.WriteLine("Skriv 'vänster' för att gå vänster");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
        Console.WriteLine("Corridor8");
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
                (nuvaranderum, mat, vatten) = inventory(Inventory, mat, vatten, nuvaranderum);
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
        Console.ReadLine();
        return (nuvaranderum, mat, vatten);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int) Corridor9(List<string> Inventory, int mat, int vatten, string nuvaranderum)
    {
        String Val = "";

        List<string> Corridor = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor.Add("1 pinne");
        Corridor.Add("1 pinne");
        Corridor.Add("1 Tröja");
        Corridor.Add("1 Vatten");
        Corridor.Add("1 Vatten");
        Corridor.Add("1 Snacks bar");

        Console.WriteLine("Du är nu i en corridor någonstans i junglen");  //lite text som bärätar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i corridoren");
        Console.WriteLine("Du är i en återvändsgränd så ända du kan göra är att gå tillbacka");
        Console.WriteLine("Skrive 'Back' för att gå tillbaka");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
        Console.WriteLine("Corridor9");
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
                (nuvaranderum, mat, vatten) = inventory(Inventory, mat, vatten, nuvaranderum);
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
        Console.ReadLine();
        return (nuvaranderum, mat, vatten);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int) Corridor10(List<string> Inventory, int mat, int vatten, string nuvaranderum)
    {
        String Val = "";

        List<string> Corridor = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor.Add("1 Sten");
        Corridor.Add("1 Sten");
        Corridor.Add("1 Medecin");

        Console.WriteLine("Du är nu i en corridor någonstans i junglen");  //lite text som bärätar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i corridoren");
        Console.WriteLine("Skriva 'Back' för att gå tillbaka eller skriv 'Framåt' för att gå framåt");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
        Console.WriteLine("Corridor10");
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
                (nuvaranderum, mat, vatten) = inventory(Inventory, mat, vatten, nuvaranderum);
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
        Console.ReadLine();
        return (nuvaranderum, mat, vatten);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int) Corridor11(List<string> Inventory, int mat, int vatten, string nuvaranderum)
    {
        String Val = "";

        List<string> Corridor = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor.Add("1 pinne");
        Corridor.Add("1 pinne");
        Corridor.Add("1 pinne");
        Corridor.Add("1 Sten");
        Corridor.Add("1 Sten");

        Console.WriteLine("Du är nu i en corridor någonstans i junglen");  //lite text som bärätar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i corridoren");
        Console.WriteLine("Skriva 'Back' för att gå tillbaka eller skriv 'Framåt' för att gå framåt");
        Console.WriteLine("Skriv 'Höger' för att gå till höger");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
        Console.WriteLine("Corridor11");
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
                (nuvaranderum, mat, vatten) = inventory(Inventory, mat, vatten, nuvaranderum);
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
        Console.ReadLine();
        return (nuvaranderum, mat, vatten);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int) Corridor12(List<string> Inventory, int mat, int vatten, string nuvaranderum)
    {
        String Val = "";

        List<string> Corridor = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor.Add("1 Sten");

        Console.WriteLine("Du är nu i en corridor någonstans i junglen");  //lite text som bärätar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i corridoren");
        Console.WriteLine("Skriva 'Back' för att gå tillbaka eller skriv 'Framåt' för att gå framåt");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
        Console.WriteLine("Corridor12");
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
                (nuvaranderum, mat, vatten) = inventory(Inventory, mat, vatten, nuvaranderum);
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
        Console.ReadLine();
        return (nuvaranderum, mat, vatten);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int) Corridor13(List<string> Inventory, int mat, int vatten, string nuvaranderum)
    {
        String Val = "";

        List<string> Corridor = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor.Add("1 pinne");
        Corridor.Add("1 pinne");

        Console.WriteLine("Du är nu i en corridor någonstans i junglen");  //lite text som bärätar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i corridoren");
        Console.WriteLine("Skriva 'Back' för att gå tillbaka eller skriv 'Framåt' för att gå framåt");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
        Console.WriteLine("Corridor13");
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
                (nuvaranderum, mat, vatten) = inventory(Inventory, mat, vatten, nuvaranderum);
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
        Console.ReadLine();
        return (nuvaranderum, mat, vatten);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int) Corridor14(List<string> Inventory, int mat, int vatten, string nuvaranderum)
    {
        String Val = "";

        List<string> Corridor = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor.Add("1 pinne");
        Corridor.Add("1 Sten");
        Corridor.Add("1 Vatten");
        Corridor.Add("1 Tröja");

        Console.WriteLine("Du är nu i en corridor någonstans i junglen");  //lite text som bärätar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i corridoren");
        Console.WriteLine("Skriva 'Back' för att gå tillbaka eller skriv 'Framåt' för att gå framåt");
        Console.WriteLine("Skriv 'vänster' för att gå vänster");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
        Console.WriteLine("Corridor14");
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
                (nuvaranderum, mat, vatten) = inventory(Inventory, mat, vatten, nuvaranderum);
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
        Console.ReadLine();
        return (nuvaranderum, mat, vatten);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int) Corridor15(List<string> Inventory, int mat, int vatten, string nuvaranderum)
    {
        String Val = "";

        List<string> Corridor = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor.Add("1 pinne");
        Corridor.Add("1 pinne");

        Console.WriteLine("Du är nu i en corridor någonstans i junglen");  //lite text som bärätar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i corridoren");
        Console.WriteLine("Skriva 'Back' för att gå tillbaka eller skriv 'Framåt' för att gå framåt");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
        Console.WriteLine("Corridor15");
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
                (nuvaranderum, mat, vatten) = inventory(Inventory, mat, vatten, nuvaranderum);
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
        Console.ReadLine();
        return (nuvaranderum, mat, vatten);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int) Corridor16(List<string> Inventory, int mat, int vatten, string nuvaranderum)
    {
        String Val = "";

        List<string> Corridor = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor.Add("1 pinne");
        Corridor.Add("1 Sten");
        Corridor.Add("1 Sten");
        Corridor.Add("1 Sten");

        Console.WriteLine("Du är nu i en corridor någonstans i junglen");  //lite text som bärätar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i corridoren");
        Console.WriteLine("Skriva 'Back' för att gå tillbaka eller skriv 'Framåt' för att gå framåt");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
        Console.WriteLine("Corridor16");
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
                (nuvaranderum, mat, vatten) = inventory(Inventory, mat, vatten, nuvaranderum);
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
        Console.ReadLine();
        return (nuvaranderum, mat, vatten);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int) Corridor17(List<string> Inventory, int mat, int vatten, string nuvaranderum)
    {
        String Val = "";

        List<string> Corridor = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor.Add("1 pinne");
        Corridor.Add("1 pinne");
        Corridor.Add("1 Sten");
        Corridor.Add("1 Sten");
        Corridor.Add("1 Snacks bar");
        Corridor.Add("1 Sten");

        Console.WriteLine("Du är nu i en corridor någonstans i junglen");  //lite text som bärätar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i corridoren");
        Console.WriteLine("Skriva 'Back' för att gå tillbaka eller skriv 'Framåt' för att gå framåt");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
        Console.WriteLine("Corridor17");
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
                (nuvaranderum, mat, vatten) = inventory(Inventory, mat, vatten, nuvaranderum);
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
        Console.ReadLine();
        return (nuvaranderum, mat, vatten);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int) Corridor18(List<string> Inventory, int mat, int vatten, string nuvaranderum)
    {
        String Val = "";

        List<string> Corridor = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor.Add("1 pinne");
        Corridor.Add("1 pinne");
        Corridor.Add("1 pinne");
        Corridor.Add("1 pinne");
        Corridor.Add("1 pinne");
        Corridor.Add("1 Sten");
        Corridor.Add("1 Sten");
        Corridor.Add("1 Medecin");
        Corridor.Add("1 Snacks bar");

        Console.WriteLine("Du är nu i en corridor någonstans i junglen");  //lite text som bärätar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i corridoren");
        Console.WriteLine("Skriva 'Back' för att gå tillbaka");
        Console.WriteLine("Skriv 'Höger' för att gå till höger och skriv 'vänster' för att gå vänster");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
        Console.WriteLine("Corridor18");
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
                (nuvaranderum, mat, vatten) = inventory(Inventory, mat, vatten, nuvaranderum);
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
        return (nuvaranderum, mat, vatten);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int) Corridor19(List<string> Inventory, int mat, int vatten, string nuvaranderum)
    {
        String Val = "";

        List<string> Corridor = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor.Add("1 pinne");
        Corridor.Add("1 pinne");
        Corridor.Add("1 Sten");

        Console.WriteLine("Du är nu i en corridor någonstans i junglen");  //lite text som bärätar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i corridoren");
        Console.WriteLine("Skriva 'Back' för att gå tillbaka eller skriv 'Framåt' för att gå framåt");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
        Console.WriteLine("Corridor19");
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
                (nuvaranderum, mat, vatten) = inventory(Inventory, mat, vatten, nuvaranderum);
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
        Console.ReadLine();
        return (nuvaranderum, mat, vatten);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int) Corridor20(List<string> Inventory, int mat, int vatten, string nuvaranderum)
    {
        String Val = "";

        List<string> Corridor = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor.Add("1 pinne");
        Corridor.Add("1 Sten");
        Corridor.Add("1 Sten");

        Console.WriteLine("Du är nu i en corridor någonstans i junglen");  //lite text som bärätar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i corridoren");
        Console.WriteLine("Skriva 'Back' för att gå tillbaka eller skriv 'Framåt' för att gå framåt");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
        Console.WriteLine("Corridor20");
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
                (nuvaranderum, mat, vatten) = inventory(Inventory, mat, vatten, nuvaranderum);
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
        Console.ReadLine();
        return (nuvaranderum, mat, vatten);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int) Corridor21(List<string> Inventory, int mat, int vatten, string nuvaranderum)
    {
        String Val = "";

        List<string> Corridor = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor.Add("1 pinne");

        Console.WriteLine("Du är nu i en corridor någonstans i junglen");  //lite text som bärätar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i corridoren");
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
                (nuvaranderum, mat, vatten) = inventory(Inventory, mat, vatten, nuvaranderum);
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
        Console.ReadLine();
        return (nuvaranderum, mat, vatten);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int) inventory(List<string> inventory, int vatten, int mat, string nuvaranderum)
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

        return (nuvaranderum, mat, vatten);
    }

}
