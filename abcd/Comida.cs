public class Comida
{
    public double Valor { get; set; }
    public double Preco { get; set; }
    public double Peso { get; set; }

    public Comida()
    {

    }

    public Comida(double valor, double preco, double peso)
    {
        Valor = valor;
        Preco = preco;
        Peso = peso;
    }

      public virtual void Preparo()
      {

        Console.WriteLine("Preparando alimento!");

    }

}