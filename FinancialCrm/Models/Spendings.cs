//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinancialCrm.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Spendings
    {
        public int SpendingId { get; set; }
        public string SpendingTitle { get; set; }
        public Nullable<decimal> SpendingAmount { get; set; }
        public Nullable<System.DateTime> SpendingDate { get; set; }
        public Nullable<int> CategoryId { get; set; }
    
        public virtual Categories Categories { get; set; }
        public string SpendingsTitle { get; internal set; }
        public decimal SpendingsAmount { get; internal set; }
        public string SpendingsPeriod { get; internal set; }
    }
}
