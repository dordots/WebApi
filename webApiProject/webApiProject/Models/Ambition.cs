using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webApiProject.Enums;

namespace webApiProject.Models
{
    public class Ambition
    {
        public string Title { get; set; }
        public string Note { get; set; }
        public bool Recurrence { get; set; }
        public string Partner { get; set; }
        public AmbitionTypeEnum AmbitionType { get; set; }
    }
}