// Smyčka pro opakování
while (true)
{
    // První číslo
    Console.Write("Zadejte první číslo: ");
    int c1 = Convert.ToInt32(Console.ReadLine());

    // Druhé číslo
    Console.Write("Zadejte druhé číslo: ");
    int c2 = Convert.ToInt32(Console.ReadLine());

    // Vyvolání metody Comparator
    Comparator(c1, c2);

    // Pokračování
    Console.WriteLine("Pro pokračování stiskněte y");
    string y = Console.ReadLine();
    if (y == "y")
    {
        Console.Clear();
        continue;
    }
    else
    {
        break;
    }
}

// Metoda pro porovnávání čísel
void Comparator(int a, int b)
{
    if (a > b)
    {
        Console.WriteLine($"Číslo {a} je větší než {b}");
        Console.ReadKey();
        Console.Clear();
    }
    else if (a < b)
    {
        Console.WriteLine($"Číslo {a} je menší než {b}");
        Console.ReadKey();
        Console.Clear();
    }
    else if (a == b)
    {
        Console.WriteLine($"Číslo {a} je stejné jako {b}");
        Console.ReadKey();
        Console.Clear();
    }
}