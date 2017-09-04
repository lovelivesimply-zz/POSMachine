using System;
using POSMachine.Interface;

namespace POSMachine.POSMachine
{
    public class ProductInformation : IProductInformation
    {
        public ProductInformation(string name, string barcode, long price)
        {
            Name = name;
            Barcode = barcode;
            Price = price;
        }
        public string Name { get; set; }

        public string Barcode { get; set; }

        public long Price { get; set; }
    }
}