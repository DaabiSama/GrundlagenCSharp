/*
Console.WriteLine("Gebe deinen Namen ein");
string Name = Console.ReadLine();

Console.WriteLine("Gebe deinen Nachnamen ein");
string Nachname = Console.ReadLine();

Console.WriteLine("Gebe dein Alter und dein hobby nacheinander ein");
string Alter = Console.ReadLine();
string Hobby = Console.ReadLine();

Console.WriteLine("Dein Name ist {0} \nDein Nachname ist {1} \n" +
                  "Du bist {2} Jahre alt \nund dein Hobby ist {3}", Name, Nachname, Alter, Hobby);
/


/
double y = 3; double x = 6;

Console.WriteLine(y/x);
Console.WriteLine(y == x);
Console.WriteLine(y + x);
Console.WriteLine(y - x);
Console.WriteLine(y % x);

/

/
double x = 3; double y = 6;
bool flag = true;

Console.WriteLine(x++ == y | true);

Console.WriteLine("{0} {1}",x , y);

Console.WriteLine(--y == ++x & flag & true);
/


/
using System; 

namespace Klassenarbeit4
{ class Aufgabe
    { 
        static void Main() 
        { 
            bool d = false || SecondOperand(); 
            Console.WriteLine(d); 
        } 
        static bool SecondOperand()
        { 
            Console.WriteLine("Geben Sie den zweiten Operanden ein:(t/f)"); 
            string Op2 = Console.ReadLine();
            if (Op2 == "t") return true; else return false; 
        }
    } 
}
/

/
Console.WriteLine("Gebe dein Gewicht ein");
double gewicht = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Gebe deine Größe ein");
double körpergröße = Convert.ToDouble(Console.ReadLine());

double BMI = gewicht / (körpergröße * körpergröße);

Console.WriteLine("{0:F2}",BMI);

*/