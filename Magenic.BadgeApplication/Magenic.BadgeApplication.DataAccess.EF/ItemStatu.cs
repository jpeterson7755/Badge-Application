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
    
    public partial class ItemStatu
    {
        public ItemStatu()
        {
            this.ActivitySubmissions = new HashSet<ActivitySubmission>();
        }
    
        public int ItemStatusId { get; set; }
        public string StatusName { get; set; }
    
        public virtual ICollection<ActivitySubmission> ActivitySubmissions { get; set; }
    }
}
