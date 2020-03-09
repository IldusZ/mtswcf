using CallService.Models;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace CallService
{
    [ServiceContract]
    public interface ICallEventService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", 
            UriTemplate = "/CallEvent/{CallID}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat =WebMessageFormat.Json,
            BodyStyle =WebMessageBodyStyle.Wrapped)]
        CallEvent GetCallEvent(string CallID);

        [OperationContract]
        [WebInvoke(Method = "GET",
            UriTemplate = "/CallEvent/",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped)]
        List<CallEvent> GetCallEventList();

        [OperationContract]
        [WebInvoke(Method = "POST",
            UriTemplate = "/CallEvent/",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        CallEvent AddCallEvent(CallEvent callEvent);
    }
}
