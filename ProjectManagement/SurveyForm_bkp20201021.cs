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
    
    public partial class SurveyForm_bkp20201021
    {
        public string Id { get; set; }
        public int SurveyId { get; set; }
        public int ProjectId { get; set; }
        public string ProjectTitle { get; set; }
        public string RequestBy { get; set; }
        public System.DateTime RequestDate { get; set; }
        public bool Responded { get; set; }
        public Nullable<System.DateTime> RespondDate { get; set; }
        public Nullable<System.DateTime> ProjectInitialDate { get; set; }
        public Nullable<System.DateTime> ProjectCompletionDate { get; set; }
        public string LeadBiostat { get; set; }
        public Nullable<decimal> PhdHours { get; set; }
        public Nullable<decimal> MsHours { get; set; }
        public string SendTo { get; set; }
        public string Comment { get; set; }
        public Nullable<bool> Recommend { get; set; }
        public int RequestCount { get; set; }
    }
}
