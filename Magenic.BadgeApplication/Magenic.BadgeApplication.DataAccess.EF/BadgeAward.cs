//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Magenic.BadgeApplication.DataAccess.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class BadgeAward
    {
        public int BadgeAwardId { get; set; }
        public int BadgeId { get; set; }
        public int EmployeeId { get; set; }
        public System.DateTime AwardDate { get; set; }
        public int AwardAmount { get; set; }
        public bool PaidOut { get; set; }
        public Nullable<System.DateTime> PaidDate { get; set; }
        public Nullable<int> PaidCompletedBy { get; set; }
        public Nullable<bool> Published { get; set; }
    
        public virtual Badge Badge { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Employee Employee1 { get; set; }
    }
}
