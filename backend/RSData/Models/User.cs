﻿using System;
using System.Collections.Generic;

namespace RSData.Models
{
    public partial class User
    {
        public User()
        {
            EventAttendee = new HashSet<Event>();
            EventHost = new HashSet<Event>();
            Penalty = new HashSet<Penalty>();
            TimeSlot = new HashSet<TimeSlot>();
            UserRole = new HashSet<UserRole>();
        }

        public int UserId { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int DepartmentId { get; set; }

        public Department Department { get; set; }
        public ICollection<Event> EventAttendee { get; set; }
        public ICollection<Event> EventHost { get; set; }
        public ICollection<Penalty> Penalty { get; set; }
        public ICollection<TimeSlot> TimeSlot { get; set; }
        public ICollection<UserRole> UserRole { get; set; }
    }
}
