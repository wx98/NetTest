﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.17929
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace NetTestClient.WCF {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserClass", Namespace="http://schemas.datacontract.org/2004/07/NetTestModel")]
    [System.SerializableAttribute()]
    public partial class UserClass : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string uNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string uPassField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string uName {
            get {
                return this.uNameField;
            }
            set {
                if ((object.ReferenceEquals(this.uNameField, value) != true)) {
                    this.uNameField = value;
                    this.RaisePropertyChanged("uName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string uPass {
            get {
                return this.uPassField;
            }
            set {
                if ((object.ReferenceEquals(this.uPassField, value) != true)) {
                    this.uPassField = value;
                    this.RaisePropertyChanged("uPass");
                }
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TestClass", Namespace="http://schemas.datacontract.org/2004/07/NetTestModel")]
    [System.SerializableAttribute()]
    public partial class TestClass : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tAnswerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tTextField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tTitleField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tAnswer {
            get {
                return this.tAnswerField;
            }
            set {
                if ((object.ReferenceEquals(this.tAnswerField, value) != true)) {
                    this.tAnswerField = value;
                    this.RaisePropertyChanged("tAnswer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tDate {
            get {
                return this.tDateField;
            }
            set {
                if ((object.ReferenceEquals(this.tDateField, value) != true)) {
                    this.tDateField = value;
                    this.RaisePropertyChanged("tDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tText {
            get {
                return this.tTextField;
            }
            set {
                if ((object.ReferenceEquals(this.tTextField, value) != true)) {
                    this.tTextField = value;
                    this.RaisePropertyChanged("tText");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tTitle {
            get {
                return this.tTitleField;
            }
            set {
                if ((object.ReferenceEquals(this.tTitleField, value) != true)) {
                    this.tTitleField = value;
                    this.RaisePropertyChanged("tTitle");
                }
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCF.INetTestService")]
    public interface INetTestService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INetTestService/DoWork", ReplyAction="http://tempuri.org/INetTestService/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/INetTestService/DoWork", ReplyAction="http://tempuri.org/INetTestService/DoWorkResponse")]
        System.IAsyncResult BeginDoWork(System.AsyncCallback callback, object asyncState);
        
        void EndDoWork(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INetTestService/login", ReplyAction="http://tempuri.org/INetTestService/loginResponse")]
        string login(NetTestClient.WCF.UserClass user);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/INetTestService/login", ReplyAction="http://tempuri.org/INetTestService/loginResponse")]
        System.IAsyncResult Beginlogin(NetTestClient.WCF.UserClass user, System.AsyncCallback callback, object asyncState);
        
        string Endlogin(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INetTestService/addTest", ReplyAction="http://tempuri.org/INetTestService/addTestResponse")]
        NetTestClient.WCF.TestClass addTest(NetTestClient.WCF.TestClass tset);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/INetTestService/addTest", ReplyAction="http://tempuri.org/INetTestService/addTestResponse")]
        System.IAsyncResult BeginaddTest(NetTestClient.WCF.TestClass tset, System.AsyncCallback callback, object asyncState);
        
        NetTestClient.WCF.TestClass EndaddTest(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface INetTestServiceChannel : NetTestClient.WCF.INetTestService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class loginCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public loginCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class addTestCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public addTestCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public NetTestClient.WCF.TestClass Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((NetTestClient.WCF.TestClass)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NetTestServiceClient : System.ServiceModel.ClientBase<NetTestClient.WCF.INetTestService>, NetTestClient.WCF.INetTestService {
        
        private BeginOperationDelegate onBeginDoWorkDelegate;
        
        private EndOperationDelegate onEndDoWorkDelegate;
        
        private System.Threading.SendOrPostCallback onDoWorkCompletedDelegate;
        
        private BeginOperationDelegate onBeginloginDelegate;
        
        private EndOperationDelegate onEndloginDelegate;
        
        private System.Threading.SendOrPostCallback onloginCompletedDelegate;
        
        private BeginOperationDelegate onBeginaddTestDelegate;
        
        private EndOperationDelegate onEndaddTestDelegate;
        
        private System.Threading.SendOrPostCallback onaddTestCompletedDelegate;
        
        public NetTestServiceClient() {
        }
        
        public NetTestServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public NetTestServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NetTestServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NetTestServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> DoWorkCompleted;
        
        public event System.EventHandler<loginCompletedEventArgs> loginCompleted;
        
        public event System.EventHandler<addTestCompletedEventArgs> addTestCompleted;
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginDoWork(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginDoWork(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public void EndDoWork(System.IAsyncResult result) {
            base.Channel.EndDoWork(result);
        }
        
        private System.IAsyncResult OnBeginDoWork(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginDoWork(callback, asyncState);
        }
        
        private object[] OnEndDoWork(System.IAsyncResult result) {
            this.EndDoWork(result);
            return null;
        }
        
        private void OnDoWorkCompleted(object state) {
            if ((this.DoWorkCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.DoWorkCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void DoWorkAsync() {
            this.DoWorkAsync(null);
        }
        
        public void DoWorkAsync(object userState) {
            if ((this.onBeginDoWorkDelegate == null)) {
                this.onBeginDoWorkDelegate = new BeginOperationDelegate(this.OnBeginDoWork);
            }
            if ((this.onEndDoWorkDelegate == null)) {
                this.onEndDoWorkDelegate = new EndOperationDelegate(this.OnEndDoWork);
            }
            if ((this.onDoWorkCompletedDelegate == null)) {
                this.onDoWorkCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnDoWorkCompleted);
            }
            base.InvokeAsync(this.onBeginDoWorkDelegate, null, this.onEndDoWorkDelegate, this.onDoWorkCompletedDelegate, userState);
        }
        
        public string login(NetTestClient.WCF.UserClass user) {
            return base.Channel.login(user);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult Beginlogin(NetTestClient.WCF.UserClass user, System.AsyncCallback callback, object asyncState) {
            return base.Channel.Beginlogin(user, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public string Endlogin(System.IAsyncResult result) {
            return base.Channel.Endlogin(result);
        }
        
        private System.IAsyncResult OnBeginlogin(object[] inValues, System.AsyncCallback callback, object asyncState) {
            NetTestClient.WCF.UserClass user = ((NetTestClient.WCF.UserClass)(inValues[0]));
            return this.Beginlogin(user, callback, asyncState);
        }
        
        private object[] OnEndlogin(System.IAsyncResult result) {
            string retVal = this.Endlogin(result);
            return new object[] {
                    retVal};
        }
        
        private void OnloginCompleted(object state) {
            if ((this.loginCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.loginCompleted(this, new loginCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void loginAsync(NetTestClient.WCF.UserClass user) {
            this.loginAsync(user, null);
        }
        
        public void loginAsync(NetTestClient.WCF.UserClass user, object userState) {
            if ((this.onBeginloginDelegate == null)) {
                this.onBeginloginDelegate = new BeginOperationDelegate(this.OnBeginlogin);
            }
            if ((this.onEndloginDelegate == null)) {
                this.onEndloginDelegate = new EndOperationDelegate(this.OnEndlogin);
            }
            if ((this.onloginCompletedDelegate == null)) {
                this.onloginCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnloginCompleted);
            }
            base.InvokeAsync(this.onBeginloginDelegate, new object[] {
                        user}, this.onEndloginDelegate, this.onloginCompletedDelegate, userState);
        }
        
        public NetTestClient.WCF.TestClass addTest(NetTestClient.WCF.TestClass tset) {
            return base.Channel.addTest(tset);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginaddTest(NetTestClient.WCF.TestClass tset, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginaddTest(tset, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public NetTestClient.WCF.TestClass EndaddTest(System.IAsyncResult result) {
            return base.Channel.EndaddTest(result);
        }
        
        private System.IAsyncResult OnBeginaddTest(object[] inValues, System.AsyncCallback callback, object asyncState) {
            NetTestClient.WCF.TestClass tset = ((NetTestClient.WCF.TestClass)(inValues[0]));
            return this.BeginaddTest(tset, callback, asyncState);
        }
        
        private object[] OnEndaddTest(System.IAsyncResult result) {
            NetTestClient.WCF.TestClass retVal = this.EndaddTest(result);
            return new object[] {
                    retVal};
        }
        
        private void OnaddTestCompleted(object state) {
            if ((this.addTestCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.addTestCompleted(this, new addTestCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void addTestAsync(NetTestClient.WCF.TestClass tset) {
            this.addTestAsync(tset, null);
        }
        
        public void addTestAsync(NetTestClient.WCF.TestClass tset, object userState) {
            if ((this.onBeginaddTestDelegate == null)) {
                this.onBeginaddTestDelegate = new BeginOperationDelegate(this.OnBeginaddTest);
            }
            if ((this.onEndaddTestDelegate == null)) {
                this.onEndaddTestDelegate = new EndOperationDelegate(this.OnEndaddTest);
            }
            if ((this.onaddTestCompletedDelegate == null)) {
                this.onaddTestCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnaddTestCompleted);
            }
            base.InvokeAsync(this.onBeginaddTestDelegate, new object[] {
                        tset}, this.onEndaddTestDelegate, this.onaddTestCompletedDelegate, userState);
        }
    }
}
