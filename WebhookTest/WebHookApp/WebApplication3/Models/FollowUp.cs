using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class FollowUp
    {
        public string body { get; set; }
        public string epcId { get; set; }
        public string agentId { get; set; }
        public string skillId { get; set; }
        public string skillAddress { get; set; }
        public string mediaType { get; set; }
        public string relationType { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public string bcc { get; set; }
        public string subject { get; set; }
        public string mediaId { get; set; }
    }
}