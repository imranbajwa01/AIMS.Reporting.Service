﻿using System;
namespace AIMS.Reporting.WorkerService.Models
{    

    public class AttendanceTanzeem
    {
        public int Ansar { get; set; }
        public int Khuddam { get; set; }
        public int Itfal { get; set; }
        public int Lajna { get; set; }
        public int Nasrat { get; set; }
        public int Boys { get; set; }
        public int Girls { get; set; }
        public int Visitors { get; set; }
        public DateTime CreatedAtUTC { get; set; }
    }

}

