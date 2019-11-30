using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Hierarchy
{
    class Project
    {
        public string Projectname { get; set; }
        public DateTime ProjectStartTime { get; set; }
        public string Details { get; set; }
        private string state;
        public string State
        {
            get => state;
            set
            {
                if (value == "Open" || value == "Closed")
                    state = value;
                else
                    throw new Exception("Wrong state");
            }
        } 
       

    }
}
