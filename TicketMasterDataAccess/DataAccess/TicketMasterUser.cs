//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TicketMasterDataAccess.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class TicketMasterUser
    {
        public TicketMasterUser()
        {
            this.EntertainmentAddresses = new HashSet<EntertainmentAddress>();
        }
    
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string ASPNetUserId { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual ICollection<EntertainmentAddress> EntertainmentAddresses { get; set; }
    }
}
