using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PricingTool.Models.DAO
{
    public class Proposal
    {
        [Key]
        public int ID { get; set; }
        public string ProposalName { get; set; }
        public string CustomerGrpName { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    }
}
