namespace FactoryMethod
{
    public class PlatinumFactory : AbstractCreditCardFactory
    {
        protected override ICreditCard MakeProduct()
        {
            ICreditCard product = new Platinum();
            return product;
        }
    }
}
