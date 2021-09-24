using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Folluk.Models.Utility
{
    public class OController
    {
        public int ControllerId { get; set; }
        public string Name { get; set; }
        public bool IsAuthenticationRequired { get; set; }

        public OController(int id = 0, string name = "", bool auth=false)
        {
            this.ControllerId = id;
            this.Name = name;
            this.IsAuthenticationRequired = auth;
        }
    }
}