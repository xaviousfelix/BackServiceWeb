using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ServiceBMISize
{
    /// <summary>
    /// Summary description for ServiceBMISizq
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ServiceBMISizq : System.Web.Services.WebService
    {

        [WebMethod]
        public string GetSize(double weight, double height, double age)
        {
            string size = "Unknown";

            if (height >= 140 && height <= 200)
            {
                if (weight >= 48.38 && weight <= 120.03)
                {
                    if (age >= 15 && age <= 60)
                    {
                        double bmi = weight / ((height / 100) * (height / 100));

                        if (bmi < 18.5)
                        {
                            size = "YOUR SIZE IS : S";
                        }
                        else if (bmi < 24.9)
                        {
                            size = "YOUR SIZE IS : M";
                        }
                        else if (bmi < 29.9)
                        {
                            size = "YOUR SIZE IS : L";
                        }
                        else
                        {
                            size = "YOUR SIZE IS : XL";
                        }
                    }
                }
            }

            return size;
        }
    }
}
