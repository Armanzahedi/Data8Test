using Data8.PowerPlatform.Dataverse.Client;
using Dumpify;
using Microsoft.Crm.Sdk.Messages;


// var onPremAD = new OnPremiseClient("https://systan-solutions.bmsd.ir/telegramSys/XRMServices/2011/Organization.svc", "bmsd\\username", "password");

var onPremAD = new OnPremiseClient("http://dynamicsv9/whatsappSys/XRMServices/2011/Organization.svc", "bmsd\\username", "password");
// System.ServiceModel.FaultException: An error occurred when verifying security for the message.

onPremAD.Execute(new WhoAmIRequest()).Dump();
