using Court_BE.Services.Users.models;
using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Court_BE.Services.LegalCases.models
{
    public class Case
    {
        public string numCase { get; set; }
        public User user { get; set; }
        public StatusCaseEnum statusId { get; set; }
        public string topic { get; set; }
        public string type { get; set; }
        public string entitlement { get; set; }
        public DateTime dateCreate { get; set; }
        public string nextDiscussion { get; set; }
        public User submitsExcitation { get; set; }
        public User chairmanCommitte { get; set; }
        public string publicRepresentative { get; set; }

        public Case(string numCase, User user, StatusCaseEnum statusId, string topic,
              string type, string entitlement, DateTime dateCreate, string nextDiscussion, User submitsExcitation,
              User chairmanCommitte, string publicRepresentative)
        {
            this.numCase = numCase;
            this.user = user;
            this.statusId = statusId;
            this.topic = topic;
            this.type = type;
            this.entitlement = entitlement;
            this.dateCreate = dateCreate;
            this.nextDiscussion = nextDiscussion;
            this.submitsExcitation = submitsExcitation;
            this.chairmanCommitte = chairmanCommitte;
            this.publicRepresentative = publicRepresentative;
        }
    }
}
