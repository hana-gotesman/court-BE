using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Court_BE.Services.Decision.models
{
    public class Decision
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Decision(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public Decision()
        {

        }
    }
}
