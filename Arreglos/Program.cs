static void ejemplo()
{

    int[] calificaiones;
    float p = 0;

    calificaiones = new int[] { 85, 92, 77, 68, 94, 72, 89, 61, 85, 59};

    Console.WriteLine(calificaiones[2]);

    foreach (int i in calificaiones)
    {
        Console.WriteLine(i);
        p = i + p;
    }
   
p = p / calificaiones.Length;
    Console.WriteLine("\npromedio\n");
Console.WriteLine(p);

    float y = 0, q = 0;
    for ( int f = 0; f < calificaiones.Length; f++)
    {
        q = calificaiones[f];
        y = y + q;
        Console.WriteLine(calificaiones[f]);
    }
    y = y / calificaiones.Length;
    Console.WriteLine("promedio");
    Console.WriteLine(y);
}  

ejemplo();

static void ejemplo2()
{
    int[] elementos = new int[] { 50, 20, 80, 90, 60 };
    Console.WriteLine("original");
}