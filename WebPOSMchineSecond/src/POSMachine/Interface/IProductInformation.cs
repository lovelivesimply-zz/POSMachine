namespace POSMachine.Interface
{
    public interface IProductInformation
    {
        string Name { get; }
        string Barcode { get; }
        long Price { get; }
    }
}