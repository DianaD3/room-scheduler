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
    
    public partial class TimeSlot
    {
        public int TimeSlotID { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public int Status { get; set; }
        public int RoomID { get; set; }
        public int HostID { get; set; }
    
        public virtual Room Room { get; set; }
        public virtual User User { get; set; }
    }
}
