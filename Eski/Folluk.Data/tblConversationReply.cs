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
    
    public partial class tblConversationReply
    {
        public int ConversationReplyId { get; set; }
        public Nullable<int> ConversationId { get; set; }
        public Nullable<int> AccountId { get; set; }
        public string MessageBody { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<bool> IsRead { get; set; }
    
        public virtual tblAccount tblAccount { get; set; }
        public virtual tblConversation tblConversation { get; set; }
    }
}