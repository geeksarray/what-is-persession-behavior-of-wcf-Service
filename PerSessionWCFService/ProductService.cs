using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace PerSessionWCFService
{
    [ServiceBehavior(Name = "ProductService", Namespace = "http://dotnetmentors.com.com/productservice",
        InstanceContextMode = InstanceContextMode.PerSession)]
    public class ProductService : IProductService
    {
        public void SetProductQty(int qty)
        {
            this.ProductQty = qty;
        }

        public int GetProductQty()
        {
            return this.ProductQty;
        }

        private int ProductQty
        {
            get;
            set;
        }
    }
}
