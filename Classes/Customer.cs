namespace Faktura;

class Customer(Adress delivery, Adress billing)
{
    public readonly Guid Id;
    public Adress DeliveryAdress = delivery;
    public Adress BillingAdress = billing;

}
