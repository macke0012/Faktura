namespace Faktura;

class Adress(string name, string street, string zipcode, string city)
{
    public string Name { get; private set; } = name;
    public string Street { get; private set; } = street;
    public string ZipCode { get; private set; } = zipcode;
    public string City { get; private set; } = city;
}
