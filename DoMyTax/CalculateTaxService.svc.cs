using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DoMyTax
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CalculateTaxService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CalculateTaxService.svc or CalculateTaxService.svc.cs at the Solution Explorer and start debugging.
    public class CalculateTaxService : ICalculateTaxService
    {
        public decimal Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public decimal Divide(int bignumber, int smallnumber)
        {
            return bignumber / smallnumber;
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public decimal Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        public decimal Subtract(int bignumber, int smallnumber)
        {
            return bignumber - smallnumber;
        }
    }
}
