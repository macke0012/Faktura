namespace Faktura;

class Program
{
    public List<Product> Stock = [new Product("Dewalt DWST1-75676 Sågbock 2-pack", 1336), new Product("Dewalt DCW210N Excenterslip utan batteri och laddare", 1293)];

    static void Main(string args)
    {

        Customer Marko = new(new Adress(
            "Marko Jovic",
            "Slottskogsgatan 28",
            "414 53",
            "Göteborg"),
            new Adress("Marko Jovic",
            "Slottskogsgatan 28",
            "414 53",
            "Göteborg"));

        Order order = new Order(Marko);


    }
}
