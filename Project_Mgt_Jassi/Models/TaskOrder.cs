using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Mgt_Jassi.Models
{
    public class TaskOrder
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int ContractID { get; set; }
        public string Code { get; set; }

        public Contract Contract { get; set; }
        public List<TaskOrderLaborCat> TaskOrderLaborCats { get; set; }
        public List<TaskOrderOptionYear> TaskOrderOptionYears { get; set; }
        public List<Project> Projects { get; set; }
    }
}