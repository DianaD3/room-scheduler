//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RSEntity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Penalty
    {
        public int PenaltyID { get; set; }
        public int AttendeeID { get; set; }
        public int EventID { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual Event Event { get; set; }
        public virtual User User { get; set; }
    }
}
