using System;
class revisao
{
    static void Main(string[] args)
    {
        Pastel p = new Pastel();
        p.Valor = 10;
        p.Preparo();
        Console.WriteLine(p.Valor);

        Pastel p2 = new Pastel();
        p2.Valor = 20;

        //Console.WriteLine(p.Preparo);

        List<Pastel> listaPastel = new List<Pastel>();
        listaPastel.Add(p);
        listaPastel.Add(p2);

        foreach(Pastel pf in listaPastel)
        {
            Console.WriteLine($"O valor do pastel é: {pf.Valor} lulas");
        }



        Console.ReadKey();
    }
}