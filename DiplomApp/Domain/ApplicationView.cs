using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomApp.Domain
{
    public class ApplicationView
    {
       
            public int Id { get; set; }
            public DateTime Start { get; set; }
            public string Descriprion { get; set; }
            public DateTime? End { get; set; }
            public string Prim { get; set; }
            public string PC { get; set; }
            public string Phone { get; set; }
            public string Status { get; set; }
            public string Fio { get; set; }
    }
}
