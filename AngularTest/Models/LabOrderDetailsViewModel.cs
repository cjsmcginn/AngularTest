﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularTest.Models
{
    public class LabOrderDetailsViewModel
    {
        public int Id { get; set; }

        public string LabTestName { get; set; }

        public string PatientFirstName { get; set; }

        public string PatientLastName { get; set; }

        public DateTime OrderDate { get; set; }

        public string FacilityName { get; set; }

        public decimal AmountCollected { get; set; }
    }
}