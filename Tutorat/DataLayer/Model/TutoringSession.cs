﻿using System;

namespace DataLayer.Model
{
    public class TutoringSession : Entity
    {
        public int HelpedId { get; set; }
        public int TutorId { get; set; }
        public DateTime DateTimeSession { get; set; }
        public int LengthSession { get; set; }
        public HelpedStudent Helped { get; set; }
        public Tutor Tutor { get; set; }
    }
}