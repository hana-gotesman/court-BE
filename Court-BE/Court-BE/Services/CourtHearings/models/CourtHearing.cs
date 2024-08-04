using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Court_BE.Services.CourtHearings.models
{
    public class CourtHearing
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CourtHearing(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public CourtHearing()
        {

        }
    }
}
