﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_Cars_HOST.CarServiceReference {
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CarServiceReference.ICarService")]
    public interface ICarService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/DoWork", ReplyAction="http://tempuri.org/ICarService/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/DoWork", ReplyAction="http://tempuri.org/ICarService/DoWorkResponse")]
        System.Threading.Tasks.Task DoWorkAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/GetAllCar", ReplyAction="http://tempuri.org/ICarService/GetAllCarResponse")]
        WCF_Cars_HOST.CarServiceReference.Car[] GetAllCar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/GetAllCar", ReplyAction="http://tempuri.org/ICarService/GetAllCarResponse")]
        System.Threading.Tasks.Task<WCF_Cars_HOST.CarServiceReference.Car[]> GetAllCarAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/UpdateCar", ReplyAction="http://tempuri.org/ICarService/UpdateCarResponse")]
        void UpdateCar(WCF_Cars_HOST.CarServiceReference.Car car);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/UpdateCar", ReplyAction="http://tempuri.org/ICarService/UpdateCarResponse")]
        System.Threading.Tasks.Task UpdateCarAsync(WCF_Cars_HOST.CarServiceReference.Car car);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/AddCar", ReplyAction="http://tempuri.org/ICarService/AddCarResponse")]
        void AddCar(WCF_Cars_HOST.CarServiceReference.Car car);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/AddCar", ReplyAction="http://tempuri.org/ICarService/AddCarResponse")]
        System.Threading.Tasks.Task AddCarAsync(WCF_Cars_HOST.CarServiceReference.Car car);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/DeleteCar", ReplyAction="http://tempuri.org/ICarService/DeleteCarResponse")]
        void DeleteCar(WCF_Cars_HOST.CarServiceReference.Car car);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/DeleteCar", ReplyAction="http://tempuri.org/ICarService/DeleteCarResponse")]
        System.Threading.Tasks.Task DeleteCarAsync(WCF_Cars_HOST.CarServiceReference.Car car);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/SearchCarById", ReplyAction="http://tempuri.org/ICarService/SearchCarByIdResponse")]
        WCF_Cars_HOST.CarServiceReference.Car SearchCarById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarService/SearchCarById", ReplyAction="http://tempuri.org/ICarService/SearchCarByIdResponse")]
        System.Threading.Tasks.Task<WCF_Cars_HOST.CarServiceReference.Car> SearchCarByIdAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICarServiceChannel : WCF_Cars_HOST.CarServiceReference.ICarService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CarServiceClient : System.ServiceModel.ClientBase<WCF_Cars_HOST.CarServiceReference.ICarService>, WCF_Cars_HOST.CarServiceReference.ICarService {
        
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
        
        public WCF_Cars_HOST.CarServiceReference.Car[] GetAllCar() {
            return base.Channel.GetAllCar();
        }
        
        public System.Threading.Tasks.Task<WCF_Cars_HOST.CarServiceReference.Car[]> GetAllCarAsync() {
            return base.Channel.GetAllCarAsync();
        }
        
        public void UpdateCar(WCF_Cars_HOST.CarServiceReference.Car car) {
            base.Channel.UpdateCar(car);
        }
        
        public System.Threading.Tasks.Task UpdateCarAsync(WCF_Cars_HOST.CarServiceReference.Car car) {
            return base.Channel.UpdateCarAsync(car);
        }
        
        public void AddCar(WCF_Cars_HOST.CarServiceReference.Car car) {
            base.Channel.AddCar(car);
        }
        
        public System.Threading.Tasks.Task AddCarAsync(WCF_Cars_HOST.CarServiceReference.Car car) {
            return base.Channel.AddCarAsync(car);
        }
        
        public void DeleteCar(WCF_Cars_HOST.CarServiceReference.Car car) {
            base.Channel.DeleteCar(car);
        }
        
        public System.Threading.Tasks.Task DeleteCarAsync(WCF_Cars_HOST.CarServiceReference.Car car) {
            return base.Channel.DeleteCarAsync(car);
        }
        
        public WCF_Cars_HOST.CarServiceReference.Car SearchCarById(int id) {
            return base.Channel.SearchCarById(id);
        }
        
        public System.Threading.Tasks.Task<WCF_Cars_HOST.CarServiceReference.Car> SearchCarByIdAsync(int id) {
            return base.Channel.SearchCarByIdAsync(id);
        }
    }
}
