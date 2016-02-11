using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpDiscovery
{
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.CompilerServices;

    class Calculator
    {

        public Calculator(String pName = "Calculator")
        {
            this.MName = pName;
        }


        public String MName { get; set; }
        public static double pi = 3.14;
        public static double sum(String pString)
        {
            double resultat = 0;
            String j;
            foreach (var i in pString.Split('+'))
            {
                j = i.Trim();
                if (j == "pi")
                {
                    resultat += pi;
                }
                else
                {
                    resultat += Convert.ToDouble(j);
                }
            }
            return resultat;
        }
    
    };

}
