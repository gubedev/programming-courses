namespace FactoryMethod
{
    public class TitaniumFactory : AbstractCreditCardFactory
    {
        protected override ICreditCard MakeProduct()
        {
            ICreditCard product = new Titanium();
            return product;
        }
    }
}
