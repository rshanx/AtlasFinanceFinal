﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Atlas.Online.Web.Service.BankVerificationServer {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AVSReply", Namespace="http://schemas.datacontract.org/2004/07/Atlas.WCF.Interface")]
    [System.SerializableAttribute()]
    public partial class AVSReply : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool AccountAcceptsCreditsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool AccountAcceptsDebitsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool AccountExistsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool AccountOpenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool AccountOpen90daysField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Atlas.Enumerators.General.BankName BankField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BankAccountNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BranchCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<Atlas.Enumerators.AVS.Result> FinalResultField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IdNumberMatchField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string InitialsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool InitialsMatchField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool LastNameMatchField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long TransactionIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool WaitingReplyField;
        
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
        public bool AccountAcceptsCredits {
            get {
                return this.AccountAcceptsCreditsField;
            }
            set {
                if ((this.AccountAcceptsCreditsField.Equals(value) != true)) {
                    this.AccountAcceptsCreditsField = value;
                    this.RaisePropertyChanged("AccountAcceptsCredits");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool AccountAcceptsDebits {
            get {
                return this.AccountAcceptsDebitsField;
            }
            set {
                if ((this.AccountAcceptsDebitsField.Equals(value) != true)) {
                    this.AccountAcceptsDebitsField = value;
                    this.RaisePropertyChanged("AccountAcceptsDebits");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool AccountExists {
            get {
                return this.AccountExistsField;
            }
            set {
                if ((this.AccountExistsField.Equals(value) != true)) {
                    this.AccountExistsField = value;
                    this.RaisePropertyChanged("AccountExists");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool AccountOpen {
            get {
                return this.AccountOpenField;
            }
            set {
                if ((this.AccountOpenField.Equals(value) != true)) {
                    this.AccountOpenField = value;
                    this.RaisePropertyChanged("AccountOpen");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool AccountOpen90days {
            get {
                return this.AccountOpen90daysField;
            }
            set {
                if ((this.AccountOpen90daysField.Equals(value) != true)) {
                    this.AccountOpen90daysField = value;
                    this.RaisePropertyChanged("AccountOpen90days");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Atlas.Enumerators.General.BankName Bank {
            get {
                return this.BankField;
            }
            set {
                if ((this.BankField.Equals(value) != true)) {
                    this.BankField = value;
                    this.RaisePropertyChanged("Bank");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BankAccountNo {
            get {
                return this.BankAccountNoField;
            }
            set {
                if ((object.ReferenceEquals(this.BankAccountNoField, value) != true)) {
                    this.BankAccountNoField = value;
                    this.RaisePropertyChanged("BankAccountNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BranchCode {
            get {
                return this.BranchCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.BranchCodeField, value) != true)) {
                    this.BranchCodeField = value;
                    this.RaisePropertyChanged("BranchCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<Atlas.Enumerators.AVS.Result> FinalResult {
            get {
                return this.FinalResultField;
            }
            set {
                if ((this.FinalResultField.Equals(value) != true)) {
                    this.FinalResultField = value;
                    this.RaisePropertyChanged("FinalResult");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdNumber {
            get {
                return this.IdNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.IdNumberField, value) != true)) {
                    this.IdNumberField = value;
                    this.RaisePropertyChanged("IdNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IdNumberMatch {
            get {
                return this.IdNumberMatchField;
            }
            set {
                if ((this.IdNumberMatchField.Equals(value) != true)) {
                    this.IdNumberMatchField = value;
                    this.RaisePropertyChanged("IdNumberMatch");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Initials {
            get {
                return this.InitialsField;
            }
            set {
                if ((object.ReferenceEquals(this.InitialsField, value) != true)) {
                    this.InitialsField = value;
                    this.RaisePropertyChanged("Initials");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool InitialsMatch {
            get {
                return this.InitialsMatchField;
            }
            set {
                if ((this.InitialsMatchField.Equals(value) != true)) {
                    this.InitialsMatchField = value;
                    this.RaisePropertyChanged("InitialsMatch");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool LastNameMatch {
            get {
                return this.LastNameMatchField;
            }
            set {
                if ((this.LastNameMatchField.Equals(value) != true)) {
                    this.LastNameMatchField = value;
                    this.RaisePropertyChanged("LastNameMatch");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Lastname {
            get {
                return this.LastnameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastnameField, value) != true)) {
                    this.LastnameField = value;
                    this.RaisePropertyChanged("Lastname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long TransactionId {
            get {
                return this.TransactionIdField;
            }
            set {
                if ((this.TransactionIdField.Equals(value) != true)) {
                    this.TransactionIdField = value;
                    this.RaisePropertyChanged("TransactionId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool WaitingReply {
            get {
                return this.WaitingReplyField;
            }
            set {
                if ((this.WaitingReplyField.Equals(value) != true)) {
                    this.WaitingReplyField = value;
                    this.RaisePropertyChanged("WaitingReply");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="AVSResponse", Namespace="http://schemas.datacontract.org/2004/07/Atlas.WCF.Interface")]
    [System.SerializableAttribute()]
    public partial class AVSResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool AccountAcceptsCreditsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool AccountAcceptsDebitsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool AccountExistsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool AccountOpenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool AccountOpen90daysField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<Atlas.Enumerators.AVS.Result> FinalResultField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IdNumberMatchField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool InitialsMatchField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool LastNameMatchField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long TransactionIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool WaitingReplyField;
        
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
        public bool AccountAcceptsCredits {
            get {
                return this.AccountAcceptsCreditsField;
            }
            set {
                if ((this.AccountAcceptsCreditsField.Equals(value) != true)) {
                    this.AccountAcceptsCreditsField = value;
                    this.RaisePropertyChanged("AccountAcceptsCredits");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool AccountAcceptsDebits {
            get {
                return this.AccountAcceptsDebitsField;
            }
            set {
                if ((this.AccountAcceptsDebitsField.Equals(value) != true)) {
                    this.AccountAcceptsDebitsField = value;
                    this.RaisePropertyChanged("AccountAcceptsDebits");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool AccountExists {
            get {
                return this.AccountExistsField;
            }
            set {
                if ((this.AccountExistsField.Equals(value) != true)) {
                    this.AccountExistsField = value;
                    this.RaisePropertyChanged("AccountExists");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool AccountOpen {
            get {
                return this.AccountOpenField;
            }
            set {
                if ((this.AccountOpenField.Equals(value) != true)) {
                    this.AccountOpenField = value;
                    this.RaisePropertyChanged("AccountOpen");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool AccountOpen90days {
            get {
                return this.AccountOpen90daysField;
            }
            set {
                if ((this.AccountOpen90daysField.Equals(value) != true)) {
                    this.AccountOpen90daysField = value;
                    this.RaisePropertyChanged("AccountOpen90days");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<Atlas.Enumerators.AVS.Result> FinalResult {
            get {
                return this.FinalResultField;
            }
            set {
                if ((this.FinalResultField.Equals(value) != true)) {
                    this.FinalResultField = value;
                    this.RaisePropertyChanged("FinalResult");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IdNumberMatch {
            get {
                return this.IdNumberMatchField;
            }
            set {
                if ((this.IdNumberMatchField.Equals(value) != true)) {
                    this.IdNumberMatchField = value;
                    this.RaisePropertyChanged("IdNumberMatch");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool InitialsMatch {
            get {
                return this.InitialsMatchField;
            }
            set {
                if ((this.InitialsMatchField.Equals(value) != true)) {
                    this.InitialsMatchField = value;
                    this.RaisePropertyChanged("InitialsMatch");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool LastNameMatch {
            get {
                return this.LastNameMatchField;
            }
            set {
                if ((this.LastNameMatchField.Equals(value) != true)) {
                    this.LastNameMatchField = value;
                    this.RaisePropertyChanged("LastNameMatch");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long TransactionId {
            get {
                return this.TransactionIdField;
            }
            set {
                if ((this.TransactionIdField.Equals(value) != true)) {
                    this.TransactionIdField = value;
                    this.RaisePropertyChanged("TransactionId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool WaitingReply {
            get {
                return this.WaitingReplyField;
            }
            set {
                if ((this.WaitingReplyField.Equals(value) != true)) {
                    this.WaitingReplyField = value;
                    this.RaisePropertyChanged("WaitingReply");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="Atlas.Bank.Verification.Server", ConfigurationName="BankVerificationServer.IVerificationServer")]
    public interface IVerificationServer {
        
        [System.ServiceModel.OperationContractAttribute(Action="Atlas.Bank.Verification.Server/IVerificationServer/IsCDV", ReplyAction="Atlas.Bank.Verification.Server/IVerificationServer/IsCDVResponse")]
        bool IsCDV(long bankId, long bankAccountTypeId, string bankAccountNo);
        
        [System.ServiceModel.OperationContractAttribute(Action="Atlas.Bank.Verification.Server/IVerificationServer/IsCDV", ReplyAction="Atlas.Bank.Verification.Server/IVerificationServer/IsCDVResponse")]
        System.Threading.Tasks.Task<bool> IsCDVAsync(long bankId, long bankAccountTypeId, string bankAccountNo);
        
        [System.ServiceModel.OperationContractAttribute(Action="Atlas.Bank.Verification.Server/IVerificationServer/IsCDVWithBranch", ReplyAction="Atlas.Bank.Verification.Server/IVerificationServer/IsCDVWithBranchResponse")]
        bool IsCDVWithBranch(long bankId, long bankAccountTypeId, string bankAccountNo, string branchCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="Atlas.Bank.Verification.Server/IVerificationServer/IsCDVWithBranch", ReplyAction="Atlas.Bank.Verification.Server/IVerificationServer/IsCDVWithBranchResponse")]
        System.Threading.Tasks.Task<bool> IsCDVWithBranchAsync(long bankId, long bankAccountTypeId, string bankAccountNo, string branchCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="Atlas.Bank.Verification.Server/IVerificationServer/DoAVSEnquiry", ReplyAction="Atlas.Bank.Verification.Server/IVerificationServer/DoAVSEnquiryResponse")]
        Atlas.Online.Web.Service.BankVerificationServer.AVSReply DoAVSEnquiry(string initials, string lastName, string idNo, string accountNo, Atlas.Enumerators.General.BankName bankName, string branchCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="Atlas.Bank.Verification.Server/IVerificationServer/DoAVSEnquiry", ReplyAction="Atlas.Bank.Verification.Server/IVerificationServer/DoAVSEnquiryResponse")]
        System.Threading.Tasks.Task<Atlas.Online.Web.Service.BankVerificationServer.AVSReply> DoAVSEnquiryAsync(string initials, string lastName, string idNo, string accountNo, Atlas.Enumerators.General.BankName bankName, string branchCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="Atlas.Bank.Verification.Server/IVerificationServer/DoAVSEnquiryWithHost", ReplyAction="Atlas.Bank.Verification.Server/IVerificationServer/DoAVSEnquiryWithHostResponse")]
        Atlas.Online.Web.Service.BankVerificationServer.AVSReply DoAVSEnquiryWithHost(System.Nullable<long> personId, string initials, string lastName, string idNo, string accountNo, Atlas.Enumerators.General.BankName bankName, string branchCode, Atlas.Enumerators.General.Host host, Atlas.Enumerators.General.BankPeriod bankPeriod);
        
        [System.ServiceModel.OperationContractAttribute(Action="Atlas.Bank.Verification.Server/IVerificationServer/DoAVSEnquiryWithHost", ReplyAction="Atlas.Bank.Verification.Server/IVerificationServer/DoAVSEnquiryWithHostResponse")]
        System.Threading.Tasks.Task<Atlas.Online.Web.Service.BankVerificationServer.AVSReply> DoAVSEnquiryWithHostAsync(System.Nullable<long> personId, string initials, string lastName, string idNo, string accountNo, Atlas.Enumerators.General.BankName bankName, string branchCode, Atlas.Enumerators.General.Host host, Atlas.Enumerators.General.BankPeriod bankPeriod);
        
        [System.ServiceModel.OperationContractAttribute(Action="Atlas.Bank.Verification.Server/IVerificationServer/DoEnquiry", ReplyAction="Atlas.Bank.Verification.Server/IVerificationServer/DoEnquiryResponse")]
        Atlas.Online.Web.Service.BankVerificationServer.AVSReply DoEnquiry(string initials, string lastName, string idNo, string accountNo, Atlas.Enumerators.General.BankName bankName, string branchCode, bool forceCheck);
        
        [System.ServiceModel.OperationContractAttribute(Action="Atlas.Bank.Verification.Server/IVerificationServer/DoEnquiry", ReplyAction="Atlas.Bank.Verification.Server/IVerificationServer/DoEnquiryResponse")]
        System.Threading.Tasks.Task<Atlas.Online.Web.Service.BankVerificationServer.AVSReply> DoEnquiryAsync(string initials, string lastName, string idNo, string accountNo, Atlas.Enumerators.General.BankName bankName, string branchCode, bool forceCheck);
        
        [System.ServiceModel.OperationContractAttribute(Action="Atlas.Bank.Verification.Server/IVerificationServer/DoLegacyEnquiry", ReplyAction="Atlas.Bank.Verification.Server/IVerificationServer/DoLegacyEnquiryResponse")]
        Atlas.Online.Web.Service.BankVerificationServer.AVSReply DoLegacyEnquiry(string initials, string lastName, string idNo, string accountNo, Atlas.Enumerators.General.BankName bankName, string branchCode, string legacyBranchCode, bool forceCheck);
        
        [System.ServiceModel.OperationContractAttribute(Action="Atlas.Bank.Verification.Server/IVerificationServer/DoLegacyEnquiry", ReplyAction="Atlas.Bank.Verification.Server/IVerificationServer/DoLegacyEnquiryResponse")]
        System.Threading.Tasks.Task<Atlas.Online.Web.Service.BankVerificationServer.AVSReply> DoLegacyEnquiryAsync(string initials, string lastName, string idNo, string accountNo, Atlas.Enumerators.General.BankName bankName, string branchCode, string legacyBranchCode, bool forceCheck);
        
        [System.ServiceModel.OperationContractAttribute(Action="Atlas.Bank.Verification.Server/IVerificationServer/GetAVSResponse", ReplyAction="Atlas.Bank.Verification.Server/IVerificationServer/GetAVSResponseResponse")]
        Atlas.Online.Web.Service.BankVerificationServer.AVSResponse GetAVSResponse(long transactionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="Atlas.Bank.Verification.Server/IVerificationServer/GetAVSResponse", ReplyAction="Atlas.Bank.Verification.Server/IVerificationServer/GetAVSResponseResponse")]
        System.Threading.Tasks.Task<Atlas.Online.Web.Service.BankVerificationServer.AVSResponse> GetAVSResponseAsync(long transactionId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IVerificationServerChannel : Atlas.Online.Web.Service.BankVerificationServer.IVerificationServer, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class VerificationServerClient : System.ServiceModel.ClientBase<Atlas.Online.Web.Service.BankVerificationServer.IVerificationServer>, Atlas.Online.Web.Service.BankVerificationServer.IVerificationServer {
        
        public VerificationServerClient() {
        }
        
        public VerificationServerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public VerificationServerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VerificationServerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VerificationServerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool IsCDV(long bankId, long bankAccountTypeId, string bankAccountNo) {
            return base.Channel.IsCDV(bankId, bankAccountTypeId, bankAccountNo);
        }
        
        public System.Threading.Tasks.Task<bool> IsCDVAsync(long bankId, long bankAccountTypeId, string bankAccountNo) {
            return base.Channel.IsCDVAsync(bankId, bankAccountTypeId, bankAccountNo);
        }
        
        public bool IsCDVWithBranch(long bankId, long bankAccountTypeId, string bankAccountNo, string branchCode) {
            return base.Channel.IsCDVWithBranch(bankId, bankAccountTypeId, bankAccountNo, branchCode);
        }
        
        public System.Threading.Tasks.Task<bool> IsCDVWithBranchAsync(long bankId, long bankAccountTypeId, string bankAccountNo, string branchCode) {
            return base.Channel.IsCDVWithBranchAsync(bankId, bankAccountTypeId, bankAccountNo, branchCode);
        }
        
        public Atlas.Online.Web.Service.BankVerificationServer.AVSReply DoAVSEnquiry(string initials, string lastName, string idNo, string accountNo, Atlas.Enumerators.General.BankName bankName, string branchCode) {
            return base.Channel.DoAVSEnquiry(initials, lastName, idNo, accountNo, bankName, branchCode);
        }
        
        public System.Threading.Tasks.Task<Atlas.Online.Web.Service.BankVerificationServer.AVSReply> DoAVSEnquiryAsync(string initials, string lastName, string idNo, string accountNo, Atlas.Enumerators.General.BankName bankName, string branchCode) {
            return base.Channel.DoAVSEnquiryAsync(initials, lastName, idNo, accountNo, bankName, branchCode);
        }
        
        public Atlas.Online.Web.Service.BankVerificationServer.AVSReply DoAVSEnquiryWithHost(System.Nullable<long> personId, string initials, string lastName, string idNo, string accountNo, Atlas.Enumerators.General.BankName bankName, string branchCode, Atlas.Enumerators.General.Host host, Atlas.Enumerators.General.BankPeriod bankPeriod) {
            return base.Channel.DoAVSEnquiryWithHost(personId, initials, lastName, idNo, accountNo, bankName, branchCode, host, bankPeriod);
        }
        
        public System.Threading.Tasks.Task<Atlas.Online.Web.Service.BankVerificationServer.AVSReply> DoAVSEnquiryWithHostAsync(System.Nullable<long> personId, string initials, string lastName, string idNo, string accountNo, Atlas.Enumerators.General.BankName bankName, string branchCode, Atlas.Enumerators.General.Host host, Atlas.Enumerators.General.BankPeriod bankPeriod) {
            return base.Channel.DoAVSEnquiryWithHostAsync(personId, initials, lastName, idNo, accountNo, bankName, branchCode, host, bankPeriod);
        }
        
        public Atlas.Online.Web.Service.BankVerificationServer.AVSReply DoEnquiry(string initials, string lastName, string idNo, string accountNo, Atlas.Enumerators.General.BankName bankName, string branchCode, bool forceCheck) {
            return base.Channel.DoEnquiry(initials, lastName, idNo, accountNo, bankName, branchCode, forceCheck);
        }
        
        public System.Threading.Tasks.Task<Atlas.Online.Web.Service.BankVerificationServer.AVSReply> DoEnquiryAsync(string initials, string lastName, string idNo, string accountNo, Atlas.Enumerators.General.BankName bankName, string branchCode, bool forceCheck) {
            return base.Channel.DoEnquiryAsync(initials, lastName, idNo, accountNo, bankName, branchCode, forceCheck);
        }
        
        public Atlas.Online.Web.Service.BankVerificationServer.AVSReply DoLegacyEnquiry(string initials, string lastName, string idNo, string accountNo, Atlas.Enumerators.General.BankName bankName, string branchCode, string legacyBranchCode, bool forceCheck) {
            return base.Channel.DoLegacyEnquiry(initials, lastName, idNo, accountNo, bankName, branchCode, legacyBranchCode, forceCheck);
        }
        
        public System.Threading.Tasks.Task<Atlas.Online.Web.Service.BankVerificationServer.AVSReply> DoLegacyEnquiryAsync(string initials, string lastName, string idNo, string accountNo, Atlas.Enumerators.General.BankName bankName, string branchCode, string legacyBranchCode, bool forceCheck) {
            return base.Channel.DoLegacyEnquiryAsync(initials, lastName, idNo, accountNo, bankName, branchCode, legacyBranchCode, forceCheck);
        }
        
        public Atlas.Online.Web.Service.BankVerificationServer.AVSResponse GetAVSResponse(long transactionId) {
            return base.Channel.GetAVSResponse(transactionId);
        }
        
        public System.Threading.Tasks.Task<Atlas.Online.Web.Service.BankVerificationServer.AVSResponse> GetAVSResponseAsync(long transactionId) {
            return base.Channel.GetAVSResponseAsync(transactionId);
        }
    }
}
