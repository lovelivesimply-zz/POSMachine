using System;
using System.Collections.Generic;
using POSMachine.Interface;

namespace POSMachine.POSMachine
{
    public class ProductRepository : IProductRepository
    {
        public IProductInformation Get(string barcode)
        {
            throw new NotImplementedException();
        }

        readonly Dictionary<string, IProductInformation> dictionary=new Dictionary<string, IProductInformation>();

        public ProductRepository()
        {
            InitProductRepository();
        }

        public void InitProductRepository()
        {
            dictionary.Add("001",new ProductInformation("apple","001",1));
            dictionary.Add("002",new ProductInformation("pear","002",2));
        }
    }
}