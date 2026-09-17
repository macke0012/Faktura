namespace Faktura;

class Order(Customer customer)
{
    public enum PayMethodEnum
    {
        KORT,
        KLARNA,
        SWISH,
        KUSTOM
    }
    public PayMethodEnum PaymentMethod;
    Guid OrderNumber = new();
    public readonly Customer Customer = customer;

    List<CartEntry> Cart = [];
    public double Total
    {
        get
        {
            double total = 0;
            foreach (var product in Cart)
            {
                total += product.Product.Price * product.Quantity;
            }

            return total;
        }



    }

    public void AddProduct(Product product)
    {
        //Check if product is already in cart
        if (Cart.Any(p => p.Product == product))
        {
            var existingProduct = Cart.FirstOrDefault(p => p.Product == product);
            int index = Cart.IndexOf(existingProduct);
            existingProduct.Quantity += 1;
            Cart[index] = existingProduct;
        }
        else
        {
            Cart.Add(new CartEntry(product));
        }
    }


}
