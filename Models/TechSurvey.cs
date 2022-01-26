using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Survey.Models
{
    public class TechSurvey
    {
        public string id { get; set; }
        public string question { get; set; }
        public string type { get; set; }
        public string createdDate { get; set; }
        public string updatedDate { get; set; }

    }
}
