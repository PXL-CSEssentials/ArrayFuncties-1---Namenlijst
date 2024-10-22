string[] names = { "Achraf", "Annelies", "Jurgen",
                "Kevin", "Silvio", "Nathan", "Emma", "Nora", "Frank", "Louise",
                "Matty", "Arend", "Simon", "Lise", "Pascal", "Liesbet", "Laura",
                "Charlotte", "Johan", "Vincent", "Wim", "Tuba", "Kristof",
                "Kenneth"};

Console.WriteLine("==== Namen afdrukken. ====\r\n");
int number = 1;
foreach (string name in names)
{
    Console.WriteLine($"Naam {number,2} : {name.ToUpper()}");
    number++;
}

Console.WriteLine("\r\n==== Namen gesorteerd afdrukken. ====\r\n");
Array.Sort(names);
for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine($"Naam {i + 1,2} : {names[i].ToUpper()}");
}
Console.ReadLine();