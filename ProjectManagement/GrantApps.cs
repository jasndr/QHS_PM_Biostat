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
    
    public partial class GrantApps
    {
        public int Id { get; set; }
        public int InvestId { get; set; }
        public int Status { get; set; }
        public Nullable<int> ProjectId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    
        public virtual Invests Invests { get; set; }
        public virtual Projects Projects { get; set; }
    }
}
