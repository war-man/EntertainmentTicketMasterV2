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
    
    public partial class EpsilonUser
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public bool RoleFlag { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    
        public virtual EpsilonUser EpsilonUsers1 { get; set; }
        public virtual EpsilonUser EpsilonUser1 { get; set; }
    }
}
