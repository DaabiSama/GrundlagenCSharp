Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine("Wie viel beträgt der Umsatz?");
double Umsatz = Convert.ToDouble(Console.ReadLine());

if (Umsatz <= 100 & Umsatz > 0 )
{
    Console.WriteLine("dem Kunden wird kein Rabatt gewährt");
}
else if(Umsatz > 500 )
{
    Console.WriteLine("Dem kunden wurde 10% Rabatt gewährt. Der Neue betrag ist {0:F2} ", (Umsatz * 0.90));
}
else if (Umsatz > 100 & Umsatz <= 500)
{
    Console.WriteLine("Dem Kunden wurde 5% Rabatt gewährt. Der Neue betrag ist {0:F2}", (Umsatz*0.95));
}
else
{
    Console.WriteLine("Etwas ist schief gelaufen");
}