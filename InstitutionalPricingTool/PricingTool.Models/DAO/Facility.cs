using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PricingTool.Models.DAO
{
    public class Facility
    {
        [Key]
        public int ID { get; set; }
        public string ProposalName { get; set; }
        public string FacilityName { get; set; }
        public string BookingCountry { get; set; }
        public string Currency { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime MaturityDate { get; set; }
        public decimal Limit { get; set; }
    }
}
