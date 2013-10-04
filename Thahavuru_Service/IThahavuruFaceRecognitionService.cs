using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Thahavuru_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IThahavuruFaceRecognitionService" in both code and config file together.
    [ServiceContract]
    public interface IThahavuruFaceRecognitionService
    {
        [OperationContract]
        InputImagesList GetMatches(InputImage probeInfo);
    }


    [DataContract]
    public class InputImage
    {
        [DataMember]
        public byte[][] Probe { get; set; }

        [DataMember]
        public string ID{ get; set; }
    }

    [DataContract]
    public class InputImagesList
    {
        [DataMember]
        List<InputImage> Probe { get; set; }
    }
}
