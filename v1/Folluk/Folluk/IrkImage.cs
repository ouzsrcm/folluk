//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Folluk
{
    using System;
    using System.Collections.Generic;
    
    public partial class IrkImage
    {
        public int IrkImageId { get; set; }
        public Nullable<int> IrkId { get; set; }
        public Nullable<int> UserId { get; set; }
        public string Image { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
    
        public virtual Irk Irk { get; set; }
        public virtual User User { get; set; }
    }
}