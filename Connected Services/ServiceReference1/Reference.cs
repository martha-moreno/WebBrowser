﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MarthasBrowser.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetRandomString0", ReplyAction="http://tempuri.org/IService/GetRandomString0Response")]
        string GetRandomString0();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetRandomString0", ReplyAction="http://tempuri.org/IService/GetRandomString0Response")]
        System.Threading.Tasks.Task<string> GetRandomString0Async();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetRandomString", ReplyAction="http://tempuri.org/IService/GetRandomStringResponse")]
        string GetRandomString(string Length);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetRandomString", ReplyAction="http://tempuri.org/IService/GetRandomStringResponse")]
        System.Threading.Tasks.Task<string> GetRandomStringAsync(string Length);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetRandomString3", ReplyAction="http://tempuri.org/IService/GetRandomString3Response")]
        string GetRandomString3(string Length);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetRandomString3", ReplyAction="http://tempuri.org/IService/GetRandomString3Response")]
        System.Threading.Tasks.Task<string> GetRandomString3Async(string Length);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : MarthasBrowser.ServiceReference1.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<MarthasBrowser.ServiceReference1.IService>, MarthasBrowser.ServiceReference1.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetRandomString0() {
            return base.Channel.GetRandomString0();
        }
        
        public System.Threading.Tasks.Task<string> GetRandomString0Async() {
            return base.Channel.GetRandomString0Async();
        }
        
        public string GetRandomString(string Length) {
            return base.Channel.GetRandomString(Length);
        }
        
        public System.Threading.Tasks.Task<string> GetRandomStringAsync(string Length) {
            return base.Channel.GetRandomStringAsync(Length);
        }
        
        public string GetRandomString3(string Length) {
            return base.Channel.GetRandomString3(Length);
        }
        
        public System.Threading.Tasks.Task<string> GetRandomString3Async(string Length) {
            return base.Channel.GetRandomString3Async(Length);
        }
    }
}
