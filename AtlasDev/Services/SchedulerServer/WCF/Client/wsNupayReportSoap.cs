﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://www.nupay.co.za/", ConfigurationName="wsNupayReportSoap")]
public interface wsNupayReportSoap
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.nupay.co.za/getReport", ReplyAction="*")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.Xml.XmlNode getReport(string merchant_number, string password, string usertype, string report_type, System.DateTime date_from, System.DateTime date_to, string token_id, string block_id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.nupay.co.za/getReport", ReplyAction="*")]
    System.Threading.Tasks.Task<System.Xml.XmlNode> getReportAsync(string merchant_number, string password, string usertype, string report_type, System.DateTime date_from, System.DateTime date_to, string token_id, string block_id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.nupay.co.za/getReportSPF", ReplyAction="*")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.Xml.XmlNode getReportSPF(string merchant_number, string password, string usertype, string report_type, System.DateTime date_from, System.DateTime date_to, string token_id, string block_id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.nupay.co.za/getReportSPF", ReplyAction="*")]
    System.Threading.Tasks.Task<System.Xml.XmlNode> getReportSPFAsync(string merchant_number, string password, string usertype, string report_type, System.DateTime date_from, System.DateTime date_to, string token_id, string block_id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.nupay.co.za/getReportFull", ReplyAction="*")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.Xml.XmlNode getReportFull(string merchant_number, string password, string usertype, string report_type, System.DateTime date_from, System.DateTime date_to, string token_id, string block_id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.nupay.co.za/getReportFull", ReplyAction="*")]
    System.Threading.Tasks.Task<System.Xml.XmlNode> getReportFullAsync(string merchant_number, string password, string usertype, string report_type, System.DateTime date_from, System.DateTime date_to, string token_id, string block_id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.nupay.co.za/requestProgressAEDO", ReplyAction="*")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.Xml.XmlNode requestProgressAEDO(string bank);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.nupay.co.za/requestProgressAEDO", ReplyAction="*")]
    System.Threading.Tasks.Task<System.Xml.XmlNode> requestProgressAEDOAsync(string bank);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.nupay.co.za/getReportEDO", ReplyAction="*")]
    [System.ServiceModel.XmlSerializerFormatAttribute()]
    System.Xml.XmlNode getReportEDO(string merchant_number, string password, string usertype, string report_type, System.DateTime date_from, System.DateTime date_to, string token_id, string block_id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://www.nupay.co.za/getReportEDO", ReplyAction="*")]
    System.Threading.Tasks.Task<System.Xml.XmlNode> getReportEDOAsync(string merchant_number, string password, string usertype, string report_type, System.DateTime date_from, System.DateTime date_to, string token_id, string block_id);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface wsNupayReportSoapChannel : wsNupayReportSoap, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class wsNupayReportSoapClient : System.ServiceModel.ClientBase<wsNupayReportSoap>, wsNupayReportSoap
{
    
    public wsNupayReportSoapClient()
    {
    }
    
    public wsNupayReportSoapClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public wsNupayReportSoapClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public wsNupayReportSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public wsNupayReportSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public System.Xml.XmlNode getReport(string merchant_number, string password, string usertype, string report_type, System.DateTime date_from, System.DateTime date_to, string token_id, string block_id)
    {
        return base.Channel.getReport(merchant_number, password, usertype, report_type, date_from, date_to, token_id, block_id);
    }
    
    public System.Threading.Tasks.Task<System.Xml.XmlNode> getReportAsync(string merchant_number, string password, string usertype, string report_type, System.DateTime date_from, System.DateTime date_to, string token_id, string block_id)
    {
        return base.Channel.getReportAsync(merchant_number, password, usertype, report_type, date_from, date_to, token_id, block_id);
    }
    
    public System.Xml.XmlNode getReportSPF(string merchant_number, string password, string usertype, string report_type, System.DateTime date_from, System.DateTime date_to, string token_id, string block_id)
    {
        return base.Channel.getReportSPF(merchant_number, password, usertype, report_type, date_from, date_to, token_id, block_id);
    }
    
    public System.Threading.Tasks.Task<System.Xml.XmlNode> getReportSPFAsync(string merchant_number, string password, string usertype, string report_type, System.DateTime date_from, System.DateTime date_to, string token_id, string block_id)
    {
        return base.Channel.getReportSPFAsync(merchant_number, password, usertype, report_type, date_from, date_to, token_id, block_id);
    }
    
    public System.Xml.XmlNode getReportFull(string merchant_number, string password, string usertype, string report_type, System.DateTime date_from, System.DateTime date_to, string token_id, string block_id)
    {
        return base.Channel.getReportFull(merchant_number, password, usertype, report_type, date_from, date_to, token_id, block_id);
    }
    
    public System.Threading.Tasks.Task<System.Xml.XmlNode> getReportFullAsync(string merchant_number, string password, string usertype, string report_type, System.DateTime date_from, System.DateTime date_to, string token_id, string block_id)
    {
        return base.Channel.getReportFullAsync(merchant_number, password, usertype, report_type, date_from, date_to, token_id, block_id);
    }
    
    public System.Xml.XmlNode requestProgressAEDO(string bank)
    {
        return base.Channel.requestProgressAEDO(bank);
    }
    
    public System.Threading.Tasks.Task<System.Xml.XmlNode> requestProgressAEDOAsync(string bank)
    {
        return base.Channel.requestProgressAEDOAsync(bank);
    }
    
    public System.Xml.XmlNode getReportEDO(string merchant_number, string password, string usertype, string report_type, System.DateTime date_from, System.DateTime date_to, string token_id, string block_id)
    {
        return base.Channel.getReportEDO(merchant_number, password, usertype, report_type, date_from, date_to, token_id, block_id);
    }
    
    public System.Threading.Tasks.Task<System.Xml.XmlNode> getReportEDOAsync(string merchant_number, string password, string usertype, string report_type, System.DateTime date_from, System.DateTime date_to, string token_id, string block_id)
    {
        return base.Channel.getReportEDOAsync(merchant_number, password, usertype, report_type, date_from, date_to, token_id, block_id);
    }
}
