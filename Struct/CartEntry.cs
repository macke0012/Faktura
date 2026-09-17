namespace Faktura;

record struct CartEntry(Product product)
{
    public Product Product = product;
    public int Quantity = 1;
}