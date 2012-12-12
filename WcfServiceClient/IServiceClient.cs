using System.ServiceModel;

namespace WcfServiceClient
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceClient" in both code and config file together.
    [ServiceContract]
    public interface IServiceClient
    {
        [OperationContract]
        string AskNumber();
    }
}
