using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace PerSessionWCFService
{
    [ServiceContract(Name = "ProductService", Namespace = "http://dotnetmentors.com/productservice")]
    public interface IProductService
    {
        [OperationContract]
        void SetProductQty(int qty);

        [OperationContract]
        int GetProductQty();
    }
}
