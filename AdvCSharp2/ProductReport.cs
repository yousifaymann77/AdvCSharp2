using System;
using System.Collections.Generic;
using System.Text;

namespace AdvCSharp2
{
    internal class ProductReport
    {
        #region Task 03 : Custom Report Generator 3.1 Print Reports
        public static void PrintReport(List<Product> products, Action<Product> action)
        {
            foreach (Product product in products)
            {
                action(product);
            }
        } 
        #endregion
    }
}
