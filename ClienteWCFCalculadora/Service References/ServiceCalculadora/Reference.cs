﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteWCFCalculadora.ServiceCalculadora {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ExcepcionPersonalizada", Namespace="http://schemas.datacontract.org/2004/07/LogicaCalculadora")]
    [System.SerializableAttribute()]
    public partial class ExcepcionPersonalizada : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DetailErrorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int InternalCodeErrorField;
        
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
        public string DetailError {
            get {
                return this.DetailErrorField;
            }
            set {
                if ((object.ReferenceEquals(this.DetailErrorField, value) != true)) {
                    this.DetailErrorField = value;
                    this.RaisePropertyChanged("DetailError");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int InternalCodeError {
            get {
                return this.InternalCodeErrorField;
            }
            set {
                if ((this.InternalCodeErrorField.Equals(value) != true)) {
                    this.InternalCodeErrorField = value;
                    this.RaisePropertyChanged("InternalCodeError");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceCalculadora.IServicioCalculadora")]
    public interface IServicioCalculadora {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCalculadora/Division", ReplyAction="http://tempuri.org/IServicioCalculadora/DivisionResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ClienteWCFCalculadora.ServiceCalculadora.ExcepcionPersonalizada), Action="http://tempuri.org/IServicioCalculadora/DivisionExcepcionPersonalizadaFault", Name="ExcepcionPersonalizada", Namespace="http://schemas.datacontract.org/2004/07/LogicaCalculadora")]
        float Division(float num1, float num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCalculadora/Division", ReplyAction="http://tempuri.org/IServicioCalculadora/DivisionResponse")]
        System.Threading.Tasks.Task<float> DivisionAsync(float num1, float num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCalculadora/Multiplicacion", ReplyAction="http://tempuri.org/IServicioCalculadora/MultiplicacionResponse")]
        float Multiplicacion(float num1, float num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCalculadora/Multiplicacion", ReplyAction="http://tempuri.org/IServicioCalculadora/MultiplicacionResponse")]
        System.Threading.Tasks.Task<float> MultiplicacionAsync(float num1, float num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCalculadora/Resta", ReplyAction="http://tempuri.org/IServicioCalculadora/RestaResponse")]
        float Resta(float num1, float num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCalculadora/Resta", ReplyAction="http://tempuri.org/IServicioCalculadora/RestaResponse")]
        System.Threading.Tasks.Task<float> RestaAsync(float num1, float num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCalculadora/Suma", ReplyAction="http://tempuri.org/IServicioCalculadora/SumaResponse")]
        float Suma(float num1, float num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioCalculadora/Suma", ReplyAction="http://tempuri.org/IServicioCalculadora/SumaResponse")]
        System.Threading.Tasks.Task<float> SumaAsync(float num1, float num2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioCalculadoraChannel : ClienteWCFCalculadora.ServiceCalculadora.IServicioCalculadora, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioCalculadoraClient : System.ServiceModel.ClientBase<ClienteWCFCalculadora.ServiceCalculadora.IServicioCalculadora>, ClienteWCFCalculadora.ServiceCalculadora.IServicioCalculadora {
        
        public ServicioCalculadoraClient() {
        }
        
        public ServicioCalculadoraClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioCalculadoraClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioCalculadoraClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioCalculadoraClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public float Division(float num1, float num2) {
            return base.Channel.Division(num1, num2);
        }
        
        public System.Threading.Tasks.Task<float> DivisionAsync(float num1, float num2) {
            return base.Channel.DivisionAsync(num1, num2);
        }
        
        public float Multiplicacion(float num1, float num2) {
            return base.Channel.Multiplicacion(num1, num2);
        }
        
        public System.Threading.Tasks.Task<float> MultiplicacionAsync(float num1, float num2) {
            return base.Channel.MultiplicacionAsync(num1, num2);
        }
        
        public float Resta(float num1, float num2) {
            return base.Channel.Resta(num1, num2);
        }
        
        public System.Threading.Tasks.Task<float> RestaAsync(float num1, float num2) {
            return base.Channel.RestaAsync(num1, num2);
        }
        
        public float Suma(float num1, float num2) {
            return base.Channel.Suma(num1, num2);
        }
        
        public System.Threading.Tasks.Task<float> SumaAsync(float num1, float num2) {
            return base.Channel.SumaAsync(num1, num2);
        }
    }
}