using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFIntro
{
    public class CalculatorService : ICalcService
    {
        public ComplexNumber CreateComplexNumber(int a, int b)
        {
            ComplexNumber compObj = new ComplexNumber(a, b);
            return compObj;
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }        

        public int GetRealPart(ComplexNumber complex)
        {
            return complex.RealPart;
        }

        public int GetImagPart(ComplexNumber complex)
        {
            return complex.ImagPart;
        }

    }
}
