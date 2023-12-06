class Rooms
{
    public static (string, int, int) Flygner2(List<string> Inventory, int mat, int vatten, string nuvaranderum)
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

        List<string> Corridor1 = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor1.Add("1 pinne");
        Corridor1.Add("1 Sten");
        Corridor1.Add("1 Sten");
        Corridor1.Add("1 Tröja");

        Console.WriteLine("Du är nu i en corridor någonstans i junglen");  //lite text som bärätar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i corridoren");
        Console.WriteLine("Skriva 'Back' för att gå tillbaka eller skriv 'Framåt' för att gå framåt");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
        while (nuvaranderum == "Corridor2")
        {
            Val = Console.ReadLine();
            Val.ToLower();

            if (Val == "leta")
            {
                Console.WriteLine("Du hittade:");      //om man väljer att leta
                for (int i = 0; i < Corridor1.Count; i++)
                {
                    Console.WriteLine(Corridor1[i]);
                    Inventory.Add(Corridor1[i]);
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
                nuvaranderum = "";
            }                              //Dom olika hållen man kan gå
            else if (Val == "framåt")
            {
                nuvaranderum = "";
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

        List<string> Corridor2 = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor2.Add("1 pinne");
        Corridor2.Add("1 pinne");
        Corridor2.Add("1 pinne");
        Corridor2.Add("1 Sten");
        Corridor2.Add("1 Sten");

        Console.WriteLine("Du är nu i en corridor någonstans i junglen");  //lite text som bärätar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i corridoren");
        Console.WriteLine("Skriva 'Back' för att gå tillbaka");
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
                (nuvaranderum, mat, vatten) = inventory(Inventory, mat, vatten, nuvaranderum);
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

        List<string> Corridor3 = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor3.Add("1 pinne");
        Corridor3.Add("1 pinne");
        Corridor3.Add("1 pinne");
        Corridor3.Add("1 Sten");
        Corridor3.Add("1 Sten");

        Console.WriteLine("Du är nu i en corridor någonstans i junglen");  //lite text som bärätar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i corridoren");
        Console.WriteLine("Skriva 'Back' för att gå tillbaka eller skriv 'Framåt' för att gå framåt");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
        while (nuvaranderum == "Corridor2")
        {
            Val = Console.ReadLine();
            Val.ToLower();

            if (Val == "leta")
            {
                Console.WriteLine("Du hittade:");      //om man väljer att leta
                for (int i = 0; i < Corridor3.Count; i++)
                {
                    Console.WriteLine(Corridor3[i]);
                    Inventory.Add(Corridor3[i]);
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
                nuvaranderum = "";
            }                                      //Dom olika hållen man kan gå
            else if (Val == "framåt")
            {
                nuvaranderum = "";
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

        List<string> Corridor4 = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor4.Add("1 pinne");
        Corridor4.Add("1 pinne");
        Corridor4.Add("1 pinne");
        Corridor4.Add("1 Sten");
        Corridor4.Add("1 Sten");

        Console.WriteLine("Du är nu i en corridor någonstans i junglen");  //lite text som bärätar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i corridoren");
        Console.WriteLine("Skriva 'Back' för att gå tillbaka eller skriv 'Framåt' för att gå framåt");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
        while (nuvaranderum == "Corridor2")
        {
            Val = Console.ReadLine();
            Val.ToLower();

            if (Val == "leta")
            {
                Console.WriteLine("Du hittade:");      //om man väljer att leta
                for (int i = 0; i < Corridor4.Count; i++)
                {
                    Console.WriteLine(Corridor4[i]);
                    Inventory.Add(Corridor4[i]);
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
                nuvaranderum = "";
            }                                 //Dom olika hållen man kan gå
            else if (Val == "framåt")
            {
                nuvaranderum = "";
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

        List<string> Corridor5 = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor5.Add("1 pinne");
        Corridor5.Add("1 pinne");
        Corridor5.Add("1 pinne");
        Corridor5.Add("1 Sten");
        Corridor5.Add("1 Sten");

        Console.WriteLine("Du är nu i en corridor någonstans i junglen");  //lite text som bärätar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i corridoren");
        Console.WriteLine("Skriva 'Back' för att gå tillbaka eller skriv 'Framåt' för att gå framåt");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
        while (nuvaranderum == "Corridor2")
        {
            Val = Console.ReadLine();
            Val.ToLower();

            if (Val == "leta")
            {
                Console.WriteLine("Du hittade:");      //om man väljer att leta
                for (int i = 0; i < Corridor5.Count; i++)
                {
                    Console.WriteLine(Corridor5[i]);
                    Inventory.Add(Corridor5[i]);
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
                nuvaranderum = "";
            }                                            //Dom olika hållen man kan gå
            else if (Val == "framåt")
            {
                nuvaranderum = "";
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

        List<string> Corridor6 = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor6.Add("1 pinne");
        Corridor6.Add("1 pinne");
        Corridor6.Add("1 pinne");
        Corridor6.Add("1 Sten");
        Corridor6.Add("1 Sten");

        Console.WriteLine("Du är nu i en corridor någonstans i junglen");  //lite text som bärätar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i corridoren");
        Console.WriteLine("Skriva 'Back' för att gå tillbaka eller skriv 'Framåt' för att gå framåt");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
        while (nuvaranderum == "Corridor2")
        {
            Val = Console.ReadLine();
            Val.ToLower();

            if (Val == "leta")
            {
                Console.WriteLine("Du hittade:");      //om man väljer att leta
                for (int i = 0; i < Corridor6.Count; i++)
                {
                    Console.WriteLine(Corridor6[i]);
                    Inventory.Add(Corridor6[i]);
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
                nuvaranderum = "";
            }                           //Dom olika hållen man kan gå
            else if (Val == "framåt")
            {
                nuvaranderum = "";
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

        List<string> Corridor7 = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor7.Add("1 pinne");
        Corridor7.Add("1 pinne");
        Corridor7.Add("1 pinne");
        Corridor7.Add("1 Sten");
        Corridor7.Add("1 Sten");

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
                for (int i = 0; i < Corridor7.Count; i++)
                {
                    Console.WriteLine(Corridor7[i]);
                    Inventory.Add(Corridor7[i]);
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

        List<string> Corridor2 = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor2.Add("1 pinne");
        Corridor2.Add("1 pinne");
        Corridor2.Add("1 pinne");
        Corridor2.Add("1 Sten");
        Corridor2.Add("1 Sten");

        Console.WriteLine("Du är nu i en corridor någonstans i junglen");  //lite text som bärätar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i corridoren");
        Console.WriteLine("Skriva 'Back' för att gå tillbaka eller skriv 'Framåt' för att gå framåt");
        Console.WriteLine("Skriv 'vänster' för att gå vänster");
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
                (nuvaranderum, mat, vatten) = inventory(Inventory, mat, vatten, nuvaranderum);
                Val = "";
            }
            else if (Val == "back")
            {
                nuvaranderum = "";
            }                              //Dom olika hållen man kan gå
            else if (Val == "vänster")
            {
                nuvaranderum = "";
            }
            else if (Val == "framåt")
            {
                nuvaranderum = "";
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

        List<string> Corridor9 = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor9.Add("1 pinne");
        Corridor9.Add("1 pinne");
        Corridor9.Add("1 pinne");
        Corridor9.Add("1 Sten");
        Corridor9.Add("1 Sten");

        Console.WriteLine("Du är nu i en corridor någonstans i junglen");  //lite text som bärätar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i corridoren");
        Console.WriteLine("Du är i en återvändsgränd så ända du kan göra är att gå tillbacka");
        Console.WriteLine("Skrive 'Back' för att gå tillbaka");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
        while (nuvaranderum == "Corridor2")
        {
            Val = Console.ReadLine();
            Val.ToLower();

            if (Val == "leta")
            {
                Console.WriteLine("Du hittade:");      //om man väljer att leta
                for (int i = 0; i < Corridor9.Count; i++)
                {
                    Console.WriteLine(Corridor9[i]);
                    Inventory.Add(Corridor9[i]);
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
                nuvaranderum = "";
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

        List<string> Corridor10 = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor10.Add("1 pinne");
        Corridor10.Add("1 pinne");
        Corridor10.Add("1 pinne");
        Corridor10.Add("1 Sten");
        Corridor10.Add("1 Sten");

        Console.WriteLine("Du är nu i en corridor någonstans i junglen");  //lite text som bärätar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i corridoren");
        Console.WriteLine("Skriva 'Back' för att gå tillbaka eller skriv 'Framåt' för att gå framåt");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
        while (nuvaranderum == "Corridor2")
        {
            Val = Console.ReadLine();
            Val.ToLower();

            if (Val == "leta")
            {
                Console.WriteLine("Du hittade:");      //om man väljer att leta
                for (int i = 0; i < Corridor10.Count; i++)
                {
                    Console.WriteLine(Corridor10[i]);
                    Inventory.Add(Corridor10[i]);
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
                nuvaranderum = "";
            }                         //Dom olika hållen man kan gå
            else if (Val == "framåt")
            {
                nuvaranderum = "";
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

        List<string> Corridor11 = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor11.Add("1 pinne");
        Corridor11.Add("1 pinne");
        Corridor11.Add("1 pinne");
        Corridor11.Add("1 Sten");
        Corridor11.Add("1 Sten");

        Console.WriteLine("Du är nu i en corridor någonstans i junglen");  //lite text som bärätar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i corridoren");
        Console.WriteLine("Skriva 'Back' för att gå tillbaka eller skriv 'Framåt' för att gå framåt");
        Console.WriteLine("Skriv 'Höger' för att gå till höger");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
        while (nuvaranderum == "Corridor2")
        {
            Val = Console.ReadLine();
            Val.ToLower();

            if (Val == "leta")
            {
                Console.WriteLine("Du hittade:");      //om man väljer att leta
                for (int i = 0; i < Corridor11.Count; i++)
                {
                    Console.WriteLine(Corridor11[i]);
                    Inventory.Add(Corridor11[i]);
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
                nuvaranderum = "";
            }
            else if (Val == "höger")       //Dom olika hållen man kan gå
            {
                nuvaranderum = "";
            }
            else if (Val == "framåt")
            {
                nuvaranderum = "";
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

        List<string> Corridor12 = new List<string>();       //skapar en lista för rummet och lägger in vad som ska va i rummet
        Corridor12.Add("1 pinne");
        Corridor12.Add("1 pinne");
        Corridor12.Add("1 pinne");
        Corridor12.Add("1 Sten");
        Corridor12.Add("1 Sten");

        Console.WriteLine("Du är nu i en corridor någonstans i junglen");  //lite text som bärätar vad du kan göra
        Console.WriteLine("Skriva 'Leta' för att kolla om du kan hitta något i corridoren");
        Console.WriteLine("Skriva 'Back' för att gå tillbaka eller skriv 'Framåt' för att gå framåt");
        Console.WriteLine("Om du vill öppna inventoriet skriv 'Inventory'");
        while (nuvaranderum == "Corridor2")
        {
            Val = Console.ReadLine();
            Val.ToLower();

            if (Val == "leta")
            {
                Console.WriteLine("Du hittade:");      //om man väljer att leta
                for (int i = 0; i < Corridor12.Count; i++)
                {
                    Console.WriteLine(Corridor12[i]);
                    Inventory.Add(Corridor12[i]);
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
                nuvaranderum = "";
            }                           //Dom olika hållen man kan gå
            else if (Val == "framåt")
            {
                nuvaranderum = "";
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
                (nuvaranderum, mat, vatten) = inventory(Inventory, mat, vatten, nuvaranderum);
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
                (nuvaranderum, mat, vatten) = inventory(Inventory, mat, vatten, nuvaranderum);
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
                (nuvaranderum, mat, vatten) = inventory(Inventory, mat, vatten, nuvaranderum);
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
                (nuvaranderum, mat, vatten) = inventory(Inventory, mat, vatten, nuvaranderum);
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
                (nuvaranderum, mat, vatten) = inventory(Inventory, mat, vatten, nuvaranderum);
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
                (nuvaranderum, mat, vatten) = inventory(Inventory, mat, vatten, nuvaranderum);
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
            else
            {
                Console.WriteLine("Du valde inget så du bara satt där i en timma och väntar");
            }

        }
        Console.ReadLine();
        return (nuvaranderum, mat, vatten);
    }
    // -------------------------------------------------------------------------------------------------------------------------
    public static (string, int, int) Corridor19(List<string> Inventory, int mat, int vatten, string nuvaranderum)
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
                (nuvaranderum, mat, vatten) = inventory(Inventory, mat, vatten, nuvaranderum);
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
                (nuvaranderum, mat, vatten) = inventory(Inventory, mat, vatten, nuvaranderum);
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
                (nuvaranderum, mat, vatten) = inventory(Inventory, mat, vatten, nuvaranderum);
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