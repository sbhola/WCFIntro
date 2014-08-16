using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFIntro
{
    [ServiceContract]
    public interface ICalcService
    {
        [OperationContract]
        ComplexNumber CreateComplexNumber(int a, int b);

        [OperationContract]
        string GetData(int value);        

        [OperationContract]
        int GetRealPart(ComplexNumber complex);

        [OperationContract]
        int GetImagPart(ComplexNumber complex);
    }

    [DataContract]
    public class ComplexNumber
    {        
        public ComplexNumber(int a, int b)
        {
            RealPart = a;
            ImagPart = b;
        }

        [DataMember]
        public int RealPart { get; set; }

        [DataMember]
        public int ImagPart { get; set; }


    }
}
