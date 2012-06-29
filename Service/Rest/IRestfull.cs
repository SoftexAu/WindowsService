using System.IO;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace Service.Rest
{
    [ServiceContract]
    public interface IRestfull
    {
        [OperationContract]
        [WebGet]
        void SuperGet(string id);

        [OperationContract]
        [WebInvoke(Method = "POST")]
        Stream SuperPost(Stream instance);
    }
}