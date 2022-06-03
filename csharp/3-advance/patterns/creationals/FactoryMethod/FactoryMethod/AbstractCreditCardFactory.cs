namespace FactoryMethod
{
    public abstract class AbstractCreditCardFactory
    {
        protected abstract ICreditCard MakeProduct();
        public ICreditCard CreateProduct()
        {
            return MakeProduct();
        }
    }
}
