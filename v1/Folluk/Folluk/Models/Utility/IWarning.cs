using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Folluk.Models.Utility
{
    public class IWarning
    {

        public bool Status { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public string Css { get; set; }

        public string Url { get; set; }

        
        public void  Set(bool status = false, string title = "", string body = "", string css = "", string url = "")
        {
            this.Status = status;
            this.Title = title;
            this.Body = body;
            this.Css = css;
            this.Url = url;
        }

    }
}