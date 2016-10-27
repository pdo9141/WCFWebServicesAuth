﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoapHeaderAuthClient.HelloWorldBridge {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="HelloWorldBridge.HelloWorldSoap")]
    public interface HelloWorldSoap {
        
        // CODEGEN: Generating message contract since message AuthTestRequest has headers
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AuthTest", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SoapHeaderAuthClient.HelloWorldBridge.AuthTestResponse AuthTest(SoapHeaderAuthClient.HelloWorldBridge.AuthTestRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AuthTest", ReplyAction="*")]
        System.Threading.Tasks.Task<SoapHeaderAuthClient.HelloWorldBridge.AuthTestResponse> AuthTestAsync(SoapHeaderAuthClient.HelloWorldBridge.AuthTestRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class AuthSoapHd : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string userNameField;
        
        private string passwordField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string UserName {
            get {
                return this.userNameField;
            }
            set {
                this.userNameField = value;
                this.RaisePropertyChanged("UserName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
                this.RaisePropertyChanged("Password");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
                this.RaisePropertyChanged("AnyAttr");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AuthTest", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class AuthTestRequest {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public SoapHeaderAuthClient.HelloWorldBridge.AuthSoapHd AuthSoapHd;
        
        public AuthTestRequest() {
        }
        
        public AuthTestRequest(SoapHeaderAuthClient.HelloWorldBridge.AuthSoapHd AuthSoapHd) {
            this.AuthSoapHd = AuthSoapHd;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AuthTestResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class AuthTestResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string AuthTestResult;
        
        public AuthTestResponse() {
        }
        
        public AuthTestResponse(string AuthTestResult) {
            this.AuthTestResult = AuthTestResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface HelloWorldSoapChannel : SoapHeaderAuthClient.HelloWorldBridge.HelloWorldSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HelloWorldSoapClient : System.ServiceModel.ClientBase<SoapHeaderAuthClient.HelloWorldBridge.HelloWorldSoap>, SoapHeaderAuthClient.HelloWorldBridge.HelloWorldSoap {
        
        public HelloWorldSoapClient() {
        }
        
        public HelloWorldSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HelloWorldSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HelloWorldSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HelloWorldSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SoapHeaderAuthClient.HelloWorldBridge.AuthTestResponse SoapHeaderAuthClient.HelloWorldBridge.HelloWorldSoap.AuthTest(SoapHeaderAuthClient.HelloWorldBridge.AuthTestRequest request) {
            return base.Channel.AuthTest(request);
        }
        
        public string AuthTest(SoapHeaderAuthClient.HelloWorldBridge.AuthSoapHd AuthSoapHd) {
            SoapHeaderAuthClient.HelloWorldBridge.AuthTestRequest inValue = new SoapHeaderAuthClient.HelloWorldBridge.AuthTestRequest();
            inValue.AuthSoapHd = AuthSoapHd;
            SoapHeaderAuthClient.HelloWorldBridge.AuthTestResponse retVal = ((SoapHeaderAuthClient.HelloWorldBridge.HelloWorldSoap)(this)).AuthTest(inValue);
            return retVal.AuthTestResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SoapHeaderAuthClient.HelloWorldBridge.AuthTestResponse> SoapHeaderAuthClient.HelloWorldBridge.HelloWorldSoap.AuthTestAsync(SoapHeaderAuthClient.HelloWorldBridge.AuthTestRequest request) {
            return base.Channel.AuthTestAsync(request);
        }
        
        public System.Threading.Tasks.Task<SoapHeaderAuthClient.HelloWorldBridge.AuthTestResponse> AuthTestAsync(SoapHeaderAuthClient.HelloWorldBridge.AuthSoapHd AuthSoapHd) {
            SoapHeaderAuthClient.HelloWorldBridge.AuthTestRequest inValue = new SoapHeaderAuthClient.HelloWorldBridge.AuthTestRequest();
            inValue.AuthSoapHd = AuthSoapHd;
            return ((SoapHeaderAuthClient.HelloWorldBridge.HelloWorldSoap)(this)).AuthTestAsync(inValue);
        }
    }
}