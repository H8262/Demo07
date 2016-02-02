using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class TV
    {
        public string Name { get; set; }
        public string Channel { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public string Description { get; set; }

        private List<TV> programs;
        public TV()
        {
            programs = new List<TV>();
        }

        public void AddTv(TV tv)
        {
            programs.Add(tv);
        }
        public override string ToString()
        {
            return "Name: " + Name + " Channel: " + Channel + " Start time_ " + Start + " End " + End + " Description: " + Description;
        }
        
    }
}
