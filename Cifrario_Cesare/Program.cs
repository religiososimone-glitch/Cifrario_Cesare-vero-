int key;
string frase, messaggio = "";

Console.WriteLine("frase");
frase = Console.ReadLine();

do
{
    Console.WriteLine("chiave");
    key = int.Parse(Console.ReadLine());
    if (key < 1 || key > 25)
    {
        Console.WriteLine("non puoi inserire una chiave minore di uno o maggiore di 25");
    }
} while (key < 1 || key > 25);


for (int i = 0; i < frase.Length; i++)
{
    char lettera = frase[i];
    int codAscii = (int)lettera;
    if (codAscii >= 65 && codAscii <= 90)
    {
        if (codAscii + key <=90)
        {
            codAscii += key;
        }
        else
        {
            codAscii += key- 25;
        }
    }
    else
    {
        if (codAscii >= 97 && codAscii <=122)
        {
            if (codAscii + key <= 12)
            {
                codAscii += key;
            }
            else
            {
                codAscii += key - 25;
            }
        }
        else
        {
            messaggio += lettera;
        }
    }
    messaggio = messaggio + (char)codAscii;
}
Console.WriteLine(messaggio);
key = 26 - key;
frase = messaggio;
for (int i = 0; i < frase.Length; i++)
{
    char lettera = frase[i];
    int codAscii = (int)lettera;
    if (codAscii >= 65 && codAscii <= 90)
    {
        if (codAscii + key <= 90)
        {
            codAscii += key;
        }
        else
        {
            codAscii += key - 25;
        }
    }
    else
    {
        if (codAscii >= 97 && codAscii <= 122)
        {
            if (codAscii + key <= 12)
            {
                codAscii += key;
            }
            else
            {
                codAscii += key - 25;
            }
        }
        else
        {
            messaggio += lettera;
        }
    }
    messaggio = messaggio + (char)codAscii;
}
Console.WriteLine(messaggio);