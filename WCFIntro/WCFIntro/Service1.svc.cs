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
        private List<ComplexNumber> _compList = new List<ComplexNumber>();

        public void AddToList(ComplexNumber complex)
        {
            _compList.Add(complex);
        }

        public List<ComplexNumber> GetComplexNumList()
        {
            return _compList;
        }

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
