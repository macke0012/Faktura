namespace Faktura;

public record struct Product(string name, double price)
{
    public double Price = price;
    public double PriceWithVAT
    {
        get
        {
            return Price * 1.25;
        }
    }
    public string Name = name;


}
