using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAMSMSG.Shared.DataObjectModel
{ 


public class PlanName
{
    public int id { get; set; }
    public string NameOfPlan { get; set; }
    public string PlanCode { get; set; }
    public string PlanPrice { get; set; }
    public string PlanDetails { get; set; }
}
public class Subscriber
{
    public int id { get; set; }
    public int UserID { get; set; }
    public string SubscriberLevel { get; set; }
}


    public class Subscription
    {
        public int id { get; set; }
        public string SubscriberID { get; set; }
        public string SubscriptionName { get; set; }
        public string SubscriptionPlanID { get; set; }
        public DateTime SubscriptionDate { get; set; }
        public DateTime SubscriptionValidUpTO { get; set; }
    }

}