﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18331
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientApp.ProductServiceRef {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://dotnetmentors.com/productservice", ConfigurationName="ProductServiceRef.ProductService")]
    public interface ProductService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dotnetmentors.com/productservice/ProductService/SetProductQty", ReplyAction="http://dotnetmentors.com/productservice/ProductService/SetProductQtyResponse")]
        void SetProductQty(int qty);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dotnetmentors.com/productservice/ProductService/GetProductQty", ReplyAction="http://dotnetmentors.com/productservice/ProductService/GetProductQtyResponse")]
        int GetProductQty();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ProductServiceChannel : ClientApp.ProductServiceRef.ProductService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductServiceClient : System.ServiceModel.ClientBase<ClientApp.ProductServiceRef.ProductService>, ClientApp.ProductServiceRef.ProductService {
        
        public ProductServiceClient() {
        }
        
        public ProductServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void SetProductQty(int qty) {
            base.Channel.SetProductQty(qty);
        }
        
        public int GetProductQty() {
            return base.Channel.GetProductQty();
        }
    }
}