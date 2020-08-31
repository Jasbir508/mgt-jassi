using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Mgt_Jassi.Models
{
    public class TaskOrderOptionYear
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int TaskOrderID { get; set; }
        public string LaborCategory { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public TaskOrder TaskOrder { get; set; }
    }
}