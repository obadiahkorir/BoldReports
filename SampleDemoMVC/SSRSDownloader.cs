using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.Threading.Tasks;

namespace SampleDemoMVC
{
    public class SSRSDownloader
    {
        const string SSRSUsername = "SampleUsername";
        const string SSRSPassword = "SamplePassword";
        const string SSRSReportExecutionUrl = "https://192.168.110.2/reportserver/ReportExecution2005.asmx?wsdl";
        const string SSRSFolderPath = "DemoReports";
        const string ReportName = "Report1";

        //public async static Task<byte[]> GenerateSSRSReport(int demoParam)
        //{
        //    var binding = new BasicHttpBinding(BasicHttpSecurityMode.TransportCredentialOnly);
        //    binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Ntlm;
        //    binding.MaxReceivedMessageSize = 10485760; //10MB limit

        //    //Create the execution service SOAP Client
        //    var rsExec = new ReportExecutionServiceSoapClient(binding, new EndpointAddress(SSRSReportExecutionUrl));

        //    //Setup access credentials.
        //    var clientCredentials = new NetworkCredential(SSRSUsername, SSRSPassword, ".");
        //    if (rsExec.ClientCredentials != null)
        //    {
        //        rsExec.ClientCredentials.Windows.AllowedImpersonationLevel =
        //            System.Security.Principal.TokenImpersonationLevel.Impersonation;
        //        rsExec.ClientCredentials.Windows.ClientCredential = clientCredentials;
        //    }

        //    //This handles the problem of "Missing session identifier"
        //    rsExec.Endpoint.EndpointBehaviors.Add(new ReportingServicesEndpointBehavior());

        //    await rsExec.LoadReportAsync(null, "/" + SSRSFolderPath + "/" + ReportName, null);

        //    //TODO: determine parameters
        //    //Set the parameters asked for by the report
        //    ReportExecutionService.ParameterValue[] reportParam = new ReportExecutionService.ParameterValue[1];

        //    reportParam[0] = new ReportExecutionService.ParameterValue();
        //    reportParam[0].Name = "demoParam";
        //    reportParam[0].Value = demoParam.ToString();

        //    await rsExec.SetExecutionParametersAsync(null, null, reportParam, "en-us");

        //    //run the report
        //    const string deviceInfo = @"<DeviceInfo><Toolbar>False</Toolbar></DeviceInfo>";
        //    var response = await rsExec.RenderAsync(new RenderRequest(null, null, "EXCEL", deviceInfo));

        //    //spit out the result
        //    var byteResults = response.Result;

        //    return byteResults;
        //}
    }
}