Random zufall = new Random();
int x = 0;

//Generiert eine zufällige Zahl von 1-100
int zufallsZahl = zufall.Next(1, 100);

Console.Clear();

while(x <= 15)
{
    Console.WriteLine("Eine zufällige Nummer zwischen 1 und 100 wurde generiert, versuche diese zu erraten!");
    int errateneZahl = Convert.ToInt32(Console.ReadLine());

    if(errateneZahl <1)
    {
        Console.WriteLine("Die gesuchte Zahl kann nicht unter 1 liegen.");
    }

    if(errateneZahl > 100)
    {
        Console.WriteLine("Die gesuchte Zahl kann nicht über 100 liegen.");
    }

    if(errateneZahl == zufallsZahl)
    {
        Console.WriteLine("Das ist richtig!");
        break;
    }
    else if (errateneZahl > zufallsZahl)
    {
        Console.WriteLine("Zu hoch!");
        x++;

    }
    else if (errateneZahl < zufallsZahl)
    {
        Console.WriteLine("Zu Niedrig!");
        x++;
    }
    Console.WriteLine("Du hast zu viele Versuche gebraucht!");
}
