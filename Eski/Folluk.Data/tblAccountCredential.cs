//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Folluk.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblAccountCredential
    {
        public int AccountCredentialId { get; set; }
        public Nullable<int> AccountId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    
        public virtual tblAccount tblAccount { get; set; }
    }
}
