﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18063
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CalcFictures.CalcService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CalcService.ICalcService")]
    public interface ICalcService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalcService/CreateComplexNumber", ReplyAction="http://tempuri.org/ICalcService/CreateComplexNumberResponse")]
        WCFIntro.ComplexNumber CreateComplexNumber(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalcService/CreateComplexNumber", ReplyAction="http://tempuri.org/ICalcService/CreateComplexNumberResponse")]
        System.Threading.Tasks.Task<WCFIntro.ComplexNumber> CreateComplexNumberAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalcService/GetData", ReplyAction="http://tempuri.org/ICalcService/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalcService/GetData", ReplyAction="http://tempuri.org/ICalcService/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalcService/GetRealPart", ReplyAction="http://tempuri.org/ICalcService/GetRealPartResponse")]
        int GetRealPart(WCFIntro.ComplexNumber complex);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalcService/GetRealPart", ReplyAction="http://tempuri.org/ICalcService/GetRealPartResponse")]
        System.Threading.Tasks.Task<int> GetRealPartAsync(WCFIntro.ComplexNumber complex);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalcService/GetImagPart", ReplyAction="http://tempuri.org/ICalcService/GetImagPartResponse")]
        int GetImagPart(WCFIntro.ComplexNumber complex);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalcService/GetImagPart", ReplyAction="http://tempuri.org/ICalcService/GetImagPartResponse")]
        System.Threading.Tasks.Task<int> GetImagPartAsync(WCFIntro.ComplexNumber complex);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalcServiceChannel : CalcFictures.CalcService.ICalcService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalcServiceClient : System.ServiceModel.ClientBase<CalcFictures.CalcService.ICalcService>, CalcFictures.CalcService.ICalcService {
        
        public CalcServiceClient() {
        }
        
        public CalcServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalcServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalcServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalcServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WCFIntro.ComplexNumber CreateComplexNumber(int a, int b) {
            return base.Channel.CreateComplexNumber(a, b);
        }
        
        public System.Threading.Tasks.Task<WCFIntro.ComplexNumber> CreateComplexNumberAsync(int a, int b) {
            return base.Channel.CreateComplexNumberAsync(a, b);
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public int GetRealPart(WCFIntro.ComplexNumber complex) {
            return base.Channel.GetRealPart(complex);
        }
        
        public System.Threading.Tasks.Task<int> GetRealPartAsync(WCFIntro.ComplexNumber complex) {
            return base.Channel.GetRealPartAsync(complex);
        }
        
        public int GetImagPart(WCFIntro.ComplexNumber complex) {
            return base.Channel.GetImagPart(complex);
        }
        
        public System.Threading.Tasks.Task<int> GetImagPartAsync(WCFIntro.ComplexNumber complex) {
            return base.Channel.GetImagPartAsync(complex);
        }
    }
}
