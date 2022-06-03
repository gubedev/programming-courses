namespace FactoryMethod
{
    public class MoneyBackFactory : AbstractCreditCardFactory
    {
        protected override ICreditCard MakeProduct()
        {
            ICreditCard product = new MoneyBack();
            return product;
        }
    }
}
