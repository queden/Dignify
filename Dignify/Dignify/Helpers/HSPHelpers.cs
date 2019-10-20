using System;
using System.Collections.Generic;
using System.Text;
using Dignify.Models;


namespace Dignify.Helpers
{
    class HSPHelpers
    {
        public static List<Charity> GetByCategory(Service service)
        {
            List<Charity> charityList = Models.Charities.GetCharityList();
            List<Charity> relevantCharityList = new List<Charity>();
            foreach (Charity charity in charityList)
            {
                foreach (Service serv in charity.Services)
                {
                    if (serv == service)
                    {
                        relevantCharityList.Add(charity);
                    }
                }
            }
            return relevantCharityList;
        }
    }
}
