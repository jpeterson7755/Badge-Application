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
    
    public partial class BadgeType
    {
        public BadgeType()
        {
            this.Badges = new HashSet<Badge>();
        }
    
        public int BadgeTypeId { get; set; }
        public string BadgeTypeName { get; set; }
        public bool PayrollEligible { get; set; }
    
        public virtual ICollection<Badge> Badges { get; set; }
    }
}
