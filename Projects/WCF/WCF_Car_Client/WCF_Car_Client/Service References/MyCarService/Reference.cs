﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_Car_Client.MyCarService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Car", Namespace="http://schemas.datacontract.org/2004/07/WCF_Cars")]
    [System.SerializableAttribute()]
    public partial class Car : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AgeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BrandField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PlateNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TpyeField;
        
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
        public int Age {
            get {
                return this.AgeField;
            }
            set {
                if ((this.AgeField.Equals(value) != true)) {
                    this.AgeField = value;
                    this.RaisePropertyChanged("Age");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Brand {
            get {
                return this.BrandField;
            }
            set {
                if ((object.ReferenceEquals(this.BrandField, value) != true)) {
                    this.BrandField = value;
                    this.RaisePropertyChanged("Brand");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PlateNumber {
            get {
                return this.PlateNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.PlateNumberField, value) != true)) {
                    this.PlateNumberField = value;
                    this.RaisePropertyChanged("PlateNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Tpye {
            get {
                return this.TpyeField;
            }
            set {
                if ((object.ReferenceEquals(this.TpyeField, value) != true)) {
                    this.TpyeField = value;
                    this.RaisePropertyChanged("Tpye");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DataBaseConnectionFault", Namespace="http://schemas.datacontract.org/2004/07/WCF_Cars.Fault")]
    [System.SerializableAttribute()]
    public partial class DataBaseConnectionFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
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
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="IdNotFoundFault", Namespace="http://schemas.datacontract.org/2004/07/WCF_Cars.Fault")]
    [System.SerializableAttribute()]
    public partial class IdNotFoundFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
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
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="NotLoggedInFault", Namespace="http://schemas.datacontract.org/2004/07/WCF_Cars.Fault")]
    [System.SerializableAttribute()]
    public partial class NotLoggedInFault : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
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
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MyCarService.ICarService")]
    public interface ICarService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/DoWork", ReplyAction="http://tempuri.org/ICarService/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/DoWork", ReplyAction="http://tempuri.org/ICarService/DoWorkResponse")]
        System.Threading.Tasks.Task DoWorkAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/GetAllCar", ReplyAction="http://tempuri.org/ICarService/GetAllCarResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WCF_Car_Client.MyCarService.DataBaseConnectionFault), Action="http://tempuri.org/ICarService/GetAllCarDataBaseConnectionFaultFault", Name="DataBaseConnectionFault", Namespace="http://schemas.datacontract.org/2004/07/WCF_Cars.Fault")]
        WCF_Car_Client.MyCarService.Car[] GetAllCar(string guid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/GetAllCar", ReplyAction="http://tempuri.org/ICarService/GetAllCarResponse")]
        System.Threading.Tasks.Task<WCF_Car_Client.MyCarService.Car[]> GetAllCarAsync(string guid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/AddCar", ReplyAction="http://tempuri.org/ICarService/AddCarResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WCF_Car_Client.MyCarService.DataBaseConnectionFault), Action="http://tempuri.org/ICarService/AddCarDataBaseConnectionFaultFault", Name="DataBaseConnectionFault", Namespace="http://schemas.datacontract.org/2004/07/WCF_Cars.Fault")]
        void AddCar(WCF_Car_Client.MyCarService.Car car, string guid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/AddCar", ReplyAction="http://tempuri.org/ICarService/AddCarResponse")]
        System.Threading.Tasks.Task AddCarAsync(WCF_Car_Client.MyCarService.Car car, string guid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/DeleteCar", ReplyAction="http://tempuri.org/ICarService/DeleteCarResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WCF_Car_Client.MyCarService.IdNotFoundFault), Action="http://tempuri.org/ICarService/DeleteCarIdNotFoundFaultFault", Name="IdNotFoundFault", Namespace="http://schemas.datacontract.org/2004/07/WCF_Cars.Fault")]
        [System.ServiceModel.FaultContractAttribute(typeof(WCF_Car_Client.MyCarService.DataBaseConnectionFault), Action="http://tempuri.org/ICarService/DeleteCarDataBaseConnectionFaultFault", Name="DataBaseConnectionFault", Namespace="http://schemas.datacontract.org/2004/07/WCF_Cars.Fault")]
        void DeleteCar(int Id, string guid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/DeleteCar", ReplyAction="http://tempuri.org/ICarService/DeleteCarResponse")]
        System.Threading.Tasks.Task DeleteCarAsync(int Id, string guid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/SearchCarById", ReplyAction="http://tempuri.org/ICarService/SearchCarByIdResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WCF_Car_Client.MyCarService.DataBaseConnectionFault), Action="http://tempuri.org/ICarService/SearchCarByIdDataBaseConnectionFaultFault", Name="DataBaseConnectionFault", Namespace="http://schemas.datacontract.org/2004/07/WCF_Cars.Fault")]
        [System.ServiceModel.FaultContractAttribute(typeof(WCF_Car_Client.MyCarService.IdNotFoundFault), Action="http://tempuri.org/ICarService/SearchCarByIdIdNotFoundFaultFault", Name="IdNotFoundFault", Namespace="http://schemas.datacontract.org/2004/07/WCF_Cars.Fault")]
        WCF_Car_Client.MyCarService.Car SearchCarById(int id, string guid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/SearchCarById", ReplyAction="http://tempuri.org/ICarService/SearchCarByIdResponse")]
        System.Threading.Tasks.Task<WCF_Car_Client.MyCarService.Car> SearchCarByIdAsync(int id, string guid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/YoungestCar", ReplyAction="http://tempuri.org/ICarService/YoungestCarResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WCF_Car_Client.MyCarService.DataBaseConnectionFault), Action="http://tempuri.org/ICarService/YoungestCarDataBaseConnectionFaultFault", Name="DataBaseConnectionFault", Namespace="http://schemas.datacontract.org/2004/07/WCF_Cars.Fault")]
        WCF_Car_Client.MyCarService.Car YoungestCar(string guid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/YoungestCar", ReplyAction="http://tempuri.org/ICarService/YoungestCarResponse")]
        System.Threading.Tasks.Task<WCF_Car_Client.MyCarService.Car> YoungestCarAsync(string guid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/OldestCar", ReplyAction="http://tempuri.org/ICarService/OldestCarResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WCF_Car_Client.MyCarService.DataBaseConnectionFault), Action="http://tempuri.org/ICarService/OldestCarDataBaseConnectionFaultFault", Name="DataBaseConnectionFault", Namespace="http://schemas.datacontract.org/2004/07/WCF_Cars.Fault")]
        WCF_Car_Client.MyCarService.Car OldestCar(string guid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/OldestCar", ReplyAction="http://tempuri.org/ICarService/OldestCarResponse")]
        System.Threading.Tasks.Task<WCF_Car_Client.MyCarService.Car> OldestCarAsync(string guid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/Login", ReplyAction="http://tempuri.org/ICarService/LoginResponse")]
        string Login(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/Login", ReplyAction="http://tempuri.org/ICarService/LoginResponse")]
        System.Threading.Tasks.Task<string> LoginAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/Logout", ReplyAction="http://tempuri.org/ICarService/LogoutResponse")]
        bool Logout(string client);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/Logout", ReplyAction="http://tempuri.org/ICarService/LogoutResponse")]
        System.Threading.Tasks.Task<bool> LogoutAsync(string client);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/GuidHas", ReplyAction="http://tempuri.org/ICarService/GuidHasResponse")]
        bool GuidHas(string client);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/GuidHas", ReplyAction="http://tempuri.org/ICarService/GuidHasResponse")]
        System.Threading.Tasks.Task<bool> GuidHasAsync(string client);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/GuidReturn", ReplyAction="http://tempuri.org/ICarService/GuidReturnResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(WCF_Car_Client.MyCarService.NotLoggedInFault), Action="http://tempuri.org/ICarService/GuidReturnNotLoggedInFaultFault", Name="NotLoggedInFault", Namespace="http://schemas.datacontract.org/2004/07/WCF_Cars.Fault")]
        string GuidReturn();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/GuidReturn", ReplyAction="http://tempuri.org/ICarService/GuidReturnResponse")]
        System.Threading.Tasks.Task<string> GuidReturnAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICarServiceChannel : WCF_Car_Client.MyCarService.ICarService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CarServiceClient : System.ServiceModel.ClientBase<WCF_Car_Client.MyCarService.ICarService>, WCF_Car_Client.MyCarService.ICarService {
        
        public CarServiceClient() {
        }
        
        public CarServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CarServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CarServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CarServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
        
        public WCF_Car_Client.MyCarService.Car[] GetAllCar(string guid) {
            return base.Channel.GetAllCar(guid);
        }
        
        public System.Threading.Tasks.Task<WCF_Car_Client.MyCarService.Car[]> GetAllCarAsync(string guid) {
            return base.Channel.GetAllCarAsync(guid);
        }
        
        public void AddCar(WCF_Car_Client.MyCarService.Car car, string guid) {
            base.Channel.AddCar(car, guid);
        }
        
        public System.Threading.Tasks.Task AddCarAsync(WCF_Car_Client.MyCarService.Car car, string guid) {
            return base.Channel.AddCarAsync(car, guid);
        }
        
        public void DeleteCar(int Id, string guid) {
            base.Channel.DeleteCar(Id, guid);
        }
        
        public System.Threading.Tasks.Task DeleteCarAsync(int Id, string guid) {
            return base.Channel.DeleteCarAsync(Id, guid);
        }
        
        public WCF_Car_Client.MyCarService.Car SearchCarById(int id, string guid) {
            return base.Channel.SearchCarById(id, guid);
        }
        
        public System.Threading.Tasks.Task<WCF_Car_Client.MyCarService.Car> SearchCarByIdAsync(int id, string guid) {
            return base.Channel.SearchCarByIdAsync(id, guid);
        }
        
        public WCF_Car_Client.MyCarService.Car YoungestCar(string guid) {
            return base.Channel.YoungestCar(guid);
        }
        
        public System.Threading.Tasks.Task<WCF_Car_Client.MyCarService.Car> YoungestCarAsync(string guid) {
            return base.Channel.YoungestCarAsync(guid);
        }
        
        public WCF_Car_Client.MyCarService.Car OldestCar(string guid) {
            return base.Channel.OldestCar(guid);
        }
        
        public System.Threading.Tasks.Task<WCF_Car_Client.MyCarService.Car> OldestCarAsync(string guid) {
            return base.Channel.OldestCarAsync(guid);
        }
        
        public string Login(string username, string password) {
            return base.Channel.Login(username, password);
        }
        
        public System.Threading.Tasks.Task<string> LoginAsync(string username, string password) {
            return base.Channel.LoginAsync(username, password);
        }
        
        public bool Logout(string client) {
            return base.Channel.Logout(client);
        }
        
        public System.Threading.Tasks.Task<bool> LogoutAsync(string client) {
            return base.Channel.LogoutAsync(client);
        }
        
        public bool GuidHas(string client) {
            return base.Channel.GuidHas(client);
        }
        
        public System.Threading.Tasks.Task<bool> GuidHasAsync(string client) {
            return base.Channel.GuidHasAsync(client);
        }
        
        public string GuidReturn() {
            return base.Channel.GuidReturn();
        }
        
        public System.Threading.Tasks.Task<string> GuidReturnAsync() {
            return base.Channel.GuidReturnAsync();
        }
    }
}
