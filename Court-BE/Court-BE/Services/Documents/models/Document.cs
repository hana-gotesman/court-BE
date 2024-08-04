using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Court_BE.Services.Documents.models
{
    public class Document
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int caseId { get; set; }

        public Document(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public Document()
        {

        }
    }
}
