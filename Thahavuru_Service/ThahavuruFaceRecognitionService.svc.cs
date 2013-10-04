using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Drawing;

namespace Thahavuru_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ThahavuruFaceRecognitionService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ThahavuruFaceRecognitionService.svc or ThahavuruFaceRecognitionService.svc.cs at the Solution Explorer and start debugging.
    public class ThahavuruFaceRecognitionService : IThahavuruFaceRecognitionService
    {

        public InputImagesList GetMatches(InputImage probeInfo)
        {
            return new InputImagesList();
        }
    }
}
