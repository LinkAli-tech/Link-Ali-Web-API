using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace User_API.Models
{
    public class Quote
    {
        public int QuoteId { get; set; }
        public int UserId { get; set; }
        public string CaseNumber { get; set; }
        public string Description { get; set; }
        public int VideoLength { get; set; }
        public int UploadFile { get; set; }
        public string IncludeScript { get; set; }
        public int DelayTime { get; set; }
        public int InsetTime { get; set; }
        public bool WebsiteFlag { get; set; }
    }
}
