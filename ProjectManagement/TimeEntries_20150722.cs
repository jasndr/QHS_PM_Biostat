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
    
    public partial class TimeEntries_20150722
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int BioStatId { get; set; }
        public int DateId { get; set; }
        public decimal Duration { get; set; }
        public int ServiceTypeId { get; set; }
        public System.DateTime CreationDate { get; set; }
        public string Creator { get; set; }
        public string Description { get; set; }
    }
}
