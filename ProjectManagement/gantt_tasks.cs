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
    
    public partial class gantt_tasks
    {
        public int id { get; set; }
        public string comment { get; set; }
        public System.DateTime start_date { get; set; }
        public int duration { get; set; }
        public decimal progress { get; set; }
        public int sortorder { get; set; }
        public int parent { get; set; }
    }
}
