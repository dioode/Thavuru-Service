using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Thahavuru.Resources.ViewModels;

namespace Thahavuru_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IThahavuruFaceRecognitionService" in both code and config file together.
    [ServiceContract]
    public interface IThahavuruFaceRecognitionService
    {
        //[OperationContract]
        //ViewModel GetMatches(ViewModel model);

        [OperationContract]
        InputImagesList GetMatches(InputImage probeInfo);

        [OperationContract]
        string UploadFile(byte[] f, string fileName);
        UserInterfaceModel GetMatches(UserInterfaceModel model);
    }

    //[DataContract]
    //public class ViewModel
    //{
    //    [DataMember]
    //    public UserInterfaceModel Model;
    //}


}
