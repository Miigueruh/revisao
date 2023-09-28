public class Pastel : Comida
{
    public string Tipo { get; set; }

    public override void Preparo()
    {
        Console.WriteLine("Fritando pastel!");
    }
}