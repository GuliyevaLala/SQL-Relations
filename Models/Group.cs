using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SQL_Task.Models
{    public class Group
    {
        public int Id { get; set; }
        public string GroupNo { get; set; }

        public List<Pupil> Pupils { get; set; }
    }
}
