//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectManagement
{
    using System;
    using System.Collections.Generic;
    
    public partial class GrantPI
    {
        public int Id { get; set; }
        public int GrantId { get; set; }
        public int PiId { get; set; }
        public string Creator { get; set; }
        public System.DateTime CreateDate { get; set; }
    
        public virtual Grant Grant { get; set; }
        public virtual Invests Invests { get; set; }
    }
}
