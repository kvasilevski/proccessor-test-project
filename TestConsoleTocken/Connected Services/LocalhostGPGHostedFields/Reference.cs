﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestConsoleTocken.LocalhostGPGHostedFields {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LocalhostGPGHostedFields.hostedFieldsSoap")]
    public interface hostedFieldsSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string HelloWorld(string myUserName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<string> HelloWorldAsync(string myUserName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/JavascriptFiletoSave", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool JavascriptFiletoSave(string fileName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/JavascriptFiletoSave", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> JavascriptFiletoSaveAsync(string fileName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SubmitFieldData", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string SubmitFieldData(string ipAddress, string firstName, string lastName, string postalCode, string countryAbb, string address, string city, string cardNumber, string month, string year, string cardCode, string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SubmitFieldData", ReplyAction="*")]
        System.Threading.Tasks.Task<string> SubmitFieldDataAsync(string ipAddress, string firstName, string lastName, string postalCode, string countryAbb, string address, string city, string cardNumber, string month, string year, string cardCode, string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/createJson", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void createJson(string strr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/createJson", ReplyAction="*")]
        System.Threading.Tasks.Task createJsonAsync(string strr);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsTokenValid", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        TestConsoleTocken.LocalhostGPGHostedFields.TokenCheckResponse IsTokenValid(string tokenValue, bool IsCheckExpire);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsTokenValid", ReplyAction="*")]
        System.Threading.Tasks.Task<TestConsoleTocken.LocalhostGPGHostedFields.TokenCheckResponse> IsTokenValidAsync(string tokenValue, bool IsCheckExpire);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetTempToken", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        TestConsoleTocken.LocalhostGPGHostedFields.TokenResponse GetTempToken(string clientId, string apiUserName, string apiPassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetTempToken", ReplyAction="*")]
        System.Threading.Tasks.Task<TestConsoleTocken.LocalhostGPGHostedFields.TokenResponse> GetTempTokenAsync(string clientId, string apiUserName, string apiPassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCCToken", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GetCCToken(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCCToken", ReplyAction="*")]
        System.Threading.Tasks.Task<string> GetCCTokenAsync(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetFinalCCToken", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GetFinalCCToken(string clientID, string apiUserName, string apiPassword, string ipAddress, string firstName, string lastName, string postalCode, string countryAbb, string address, string city, string payload, string cardExpiry, string CVV);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetFinalCCToken", ReplyAction="*")]
        System.Threading.Tasks.Task<string> GetFinalCCTokenAsync(string clientID, string apiUserName, string apiPassword, string ipAddress, string firstName, string lastName, string postalCode, string countryAbb, string address, string city, string payload, string cardExpiry, string CVV);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetJWT", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void GetJWT();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetJWT", ReplyAction="*")]
        System.Threading.Tasks.Task GetJWTAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetConfig", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void GetConfig();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetConfig", ReplyAction="*")]
        System.Threading.Tasks.Task GetConfigAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GenerateKeyPairAndGuid", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void GenerateKeyPairAndGuid(bool IsTest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GenerateKeyPairAndGuid", ReplyAction="*")]
        System.Threading.Tasks.Task GenerateKeyPairAndGuidAsync(bool IsTest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetTokenizewithCustomerProfile", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void GetTokenizewithCustomerProfile(string RequestObject);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetTokenizewithCustomerProfile", ReplyAction="*")]
        System.Threading.Tasks.Task GetTokenizewithCustomerProfileAsync(string RequestObject);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateCustomerProfileUsingJSSDK", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void UpdateCustomerProfileUsingJSSDK(string RequestObject);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateCustomerProfileUsingJSSDK", ReplyAction="*")]
        System.Threading.Tasks.Task UpdateCustomerProfileUsingJSSDKAsync(string RequestObject);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateCustomerProfile", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void UpdateCustomerProfile(string RequestObject);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateCustomerProfile", ReplyAction="*")]
        System.Threading.Tasks.Task UpdateCustomerProfileAsync(string RequestObject);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCustomerProfileUsingJSSDK", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void GetCustomerProfileUsingJSSDK(string RequestObject);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCustomerProfileUsingJSSDK", ReplyAction="*")]
        System.Threading.Tasks.Task GetCustomerProfileUsingJSSDKAsync(string RequestObject);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCustomerProfile", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void GetCustomerProfile(string APIUserName, string APIPW, string ClientID, string CCToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCustomerProfile", ReplyAction="*")]
        System.Threading.Tasks.Task GetCustomerProfileAsync(string APIUserName, string APIPW, string ClientID, string CCToken);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetTokenize", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void GetTokenize(string Payload, string KountSessionID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetTokenize", ReplyAction="*")]
        System.Threading.Tasks.Task GetTokenizeAsync(string Payload, string KountSessionID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetTokenListUsingJSSDK", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void GetTokenListUsingJSSDK(string RequestObject);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetTokenListUsingJSSDK", ReplyAction="*")]
        System.Threading.Tasks.Task GetTokenListUsingJSSDKAsync(string RequestObject);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetTokenList", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void GetTokenList(string APIUserName, string APIPW, string ClientID, string EmployeeID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetTokenList", ReplyAction="*")]
        System.Threading.Tasks.Task GetTokenListAsync(string APIUserName, string APIPW, string ClientID, string EmployeeID);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class TokenCheckResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int statusCodeField;
        
        private string statusTextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int statusCode {
            get {
                return this.statusCodeField;
            }
            set {
                this.statusCodeField = value;
                this.RaisePropertyChanged("statusCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string statusText {
            get {
                return this.statusTextField;
            }
            set {
                this.statusTextField = value;
                this.RaisePropertyChanged("statusText");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class TokenResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string tokenField;
        
        private string statusField;
        
        private string messageField;
        
        private string createdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Token {
            get {
                return this.tokenField;
            }
            set {
                this.tokenField = value;
                this.RaisePropertyChanged("Token");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
                this.RaisePropertyChanged("Status");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
                this.RaisePropertyChanged("Message");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Created {
            get {
                return this.createdField;
            }
            set {
                this.createdField = value;
                this.RaisePropertyChanged("Created");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface hostedFieldsSoapChannel : TestConsoleTocken.LocalhostGPGHostedFields.hostedFieldsSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class hostedFieldsSoapClient : System.ServiceModel.ClientBase<TestConsoleTocken.LocalhostGPGHostedFields.hostedFieldsSoap>, TestConsoleTocken.LocalhostGPGHostedFields.hostedFieldsSoap {
        
        public hostedFieldsSoapClient() {
        }
        
        public hostedFieldsSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public hostedFieldsSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public hostedFieldsSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public hostedFieldsSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string HelloWorld(string myUserName) {
            return base.Channel.HelloWorld(myUserName);
        }
        
        public System.Threading.Tasks.Task<string> HelloWorldAsync(string myUserName) {
            return base.Channel.HelloWorldAsync(myUserName);
        }
        
        public bool JavascriptFiletoSave(string fileName) {
            return base.Channel.JavascriptFiletoSave(fileName);
        }
        
        public System.Threading.Tasks.Task<bool> JavascriptFiletoSaveAsync(string fileName) {
            return base.Channel.JavascriptFiletoSaveAsync(fileName);
        }
        
        public string SubmitFieldData(string ipAddress, string firstName, string lastName, string postalCode, string countryAbb, string address, string city, string cardNumber, string month, string year, string cardCode, string token) {
            return base.Channel.SubmitFieldData(ipAddress, firstName, lastName, postalCode, countryAbb, address, city, cardNumber, month, year, cardCode, token);
        }
        
        public System.Threading.Tasks.Task<string> SubmitFieldDataAsync(string ipAddress, string firstName, string lastName, string postalCode, string countryAbb, string address, string city, string cardNumber, string month, string year, string cardCode, string token) {
            return base.Channel.SubmitFieldDataAsync(ipAddress, firstName, lastName, postalCode, countryAbb, address, city, cardNumber, month, year, cardCode, token);
        }
        
        public void createJson(string strr) {
            base.Channel.createJson(strr);
        }
        
        public System.Threading.Tasks.Task createJsonAsync(string strr) {
            return base.Channel.createJsonAsync(strr);
        }
        
        public TestConsoleTocken.LocalhostGPGHostedFields.TokenCheckResponse IsTokenValid(string tokenValue, bool IsCheckExpire) {
            return base.Channel.IsTokenValid(tokenValue, IsCheckExpire);
        }
        
        public System.Threading.Tasks.Task<TestConsoleTocken.LocalhostGPGHostedFields.TokenCheckResponse> IsTokenValidAsync(string tokenValue, bool IsCheckExpire) {
            return base.Channel.IsTokenValidAsync(tokenValue, IsCheckExpire);
        }
        
        public TestConsoleTocken.LocalhostGPGHostedFields.TokenResponse GetTempToken(string clientId, string apiUserName, string apiPassword) {
            return base.Channel.GetTempToken(clientId, apiUserName, apiPassword);
        }
        
        public System.Threading.Tasks.Task<TestConsoleTocken.LocalhostGPGHostedFields.TokenResponse> GetTempTokenAsync(string clientId, string apiUserName, string apiPassword) {
            return base.Channel.GetTempTokenAsync(clientId, apiUserName, apiPassword);
        }
        
        public string GetCCToken(string token) {
            return base.Channel.GetCCToken(token);
        }
        
        public System.Threading.Tasks.Task<string> GetCCTokenAsync(string token) {
            return base.Channel.GetCCTokenAsync(token);
        }
        
        public string GetFinalCCToken(string clientID, string apiUserName, string apiPassword, string ipAddress, string firstName, string lastName, string postalCode, string countryAbb, string address, string city, string payload, string cardExpiry, string CVV) {
            return base.Channel.GetFinalCCToken(clientID, apiUserName, apiPassword, ipAddress, firstName, lastName, postalCode, countryAbb, address, city, payload, cardExpiry, CVV);
        }
        
        public System.Threading.Tasks.Task<string> GetFinalCCTokenAsync(string clientID, string apiUserName, string apiPassword, string ipAddress, string firstName, string lastName, string postalCode, string countryAbb, string address, string city, string payload, string cardExpiry, string CVV) {
            return base.Channel.GetFinalCCTokenAsync(clientID, apiUserName, apiPassword, ipAddress, firstName, lastName, postalCode, countryAbb, address, city, payload, cardExpiry, CVV);
        }
        
        public void GetJWT() {
            base.Channel.GetJWT();
        }
        
        public System.Threading.Tasks.Task GetJWTAsync() {
            return base.Channel.GetJWTAsync();
        }
        
        public void GetConfig() {
            base.Channel.GetConfig();
        }
        
        public System.Threading.Tasks.Task GetConfigAsync() {
            return base.Channel.GetConfigAsync();
        }
        
        public void GenerateKeyPairAndGuid(bool IsTest) {
            base.Channel.GenerateKeyPairAndGuid(IsTest);
        }
        
        public System.Threading.Tasks.Task GenerateKeyPairAndGuidAsync(bool IsTest) {
            return base.Channel.GenerateKeyPairAndGuidAsync(IsTest);
        }
        
        public void GetTokenizewithCustomerProfile(string RequestObject) {
            base.Channel.GetTokenizewithCustomerProfile(RequestObject);
        }
        
        public System.Threading.Tasks.Task GetTokenizewithCustomerProfileAsync(string RequestObject) {
            return base.Channel.GetTokenizewithCustomerProfileAsync(RequestObject);
        }
        
        public void UpdateCustomerProfileUsingJSSDK(string RequestObject) {
            base.Channel.UpdateCustomerProfileUsingJSSDK(RequestObject);
        }
        
        public System.Threading.Tasks.Task UpdateCustomerProfileUsingJSSDKAsync(string RequestObject) {
            return base.Channel.UpdateCustomerProfileUsingJSSDKAsync(RequestObject);
        }
        
        public void UpdateCustomerProfile(string RequestObject) {
            base.Channel.UpdateCustomerProfile(RequestObject);
        }
        
        public System.Threading.Tasks.Task UpdateCustomerProfileAsync(string RequestObject) {
            return base.Channel.UpdateCustomerProfileAsync(RequestObject);
        }
        
        public void GetCustomerProfileUsingJSSDK(string RequestObject) {
            base.Channel.GetCustomerProfileUsingJSSDK(RequestObject);
        }
        
        public System.Threading.Tasks.Task GetCustomerProfileUsingJSSDKAsync(string RequestObject) {
            return base.Channel.GetCustomerProfileUsingJSSDKAsync(RequestObject);
        }
        
        public void GetCustomerProfile(string APIUserName, string APIPW, string ClientID, string CCToken) {
            base.Channel.GetCustomerProfile(APIUserName, APIPW, ClientID, CCToken);
        }
        
        public System.Threading.Tasks.Task GetCustomerProfileAsync(string APIUserName, string APIPW, string ClientID, string CCToken) {
            return base.Channel.GetCustomerProfileAsync(APIUserName, APIPW, ClientID, CCToken);
        }
        
        public void GetTokenize(string Payload, string KountSessionID) {
            base.Channel.GetTokenize(Payload, KountSessionID);
        }
        
        public System.Threading.Tasks.Task GetTokenizeAsync(string Payload, string KountSessionID) {
            return base.Channel.GetTokenizeAsync(Payload, KountSessionID);
        }
        
        public void GetTokenListUsingJSSDK(string RequestObject) {
            base.Channel.GetTokenListUsingJSSDK(RequestObject);
        }
        
        public System.Threading.Tasks.Task GetTokenListUsingJSSDKAsync(string RequestObject) {
            return base.Channel.GetTokenListUsingJSSDKAsync(RequestObject);
        }
        
        public void GetTokenList(string APIUserName, string APIPW, string ClientID, string EmployeeID) {
            base.Channel.GetTokenList(APIUserName, APIPW, ClientID, EmployeeID);
        }
        
        public System.Threading.Tasks.Task GetTokenListAsync(string APIUserName, string APIPW, string ClientID, string EmployeeID) {
            return base.Channel.GetTokenListAsync(APIUserName, APIPW, ClientID, EmployeeID);
        }
    }
}
