using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Court_BE.Services.InterimRequests.models
{
    public class InterimRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public InterimRequest(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public InterimRequest()
        {

        }
    }
}
