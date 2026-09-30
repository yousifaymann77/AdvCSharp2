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

        #region 3.2. Transform Products 
        public static List<string> TransformProducts(List<Product> products, Func<Product, string> transform)
        {
            List<string> result = new List<string>();
            foreach (Product product in products)
            {
                result.Add(transform(product));
            }
            return result;
        } 
        #endregion
    }
}
