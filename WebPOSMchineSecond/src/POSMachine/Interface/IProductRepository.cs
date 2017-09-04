namespace POSMachine.Interface
{
    public interface IProductRepository
    {
        IProductInformation Get(string barcode);
    }
}