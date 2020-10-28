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
    
    public partial class Projects_20150707
    {
        public int Id { get; set; }
        public int InvestId { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public Nullable<System.DateTime> DeadLine { get; set; }
        public System.DateTime InitialDate { get; set; }
        public Nullable<System.DateTime> AnslysisCompletionDate { get; set; }
        public int PilotId { get; set; }
        public int HiProgramId { get; set; }
        public int EthincGroupId { get; set; }
        public bool IsJabsom { get; set; }
        public bool IsInternal { get; set; }
        public bool HasMentor { get; set; }
        public string MentorFirstName { get; set; }
        public string MentorLastName { get; set; }
        public string MentorEmail { get; set; }
        public bool IsProject { get; set; }
        public bool IsApproved { get; set; }
        public Nullable<int> RedcapId { get; set; }
        public Nullable<System.DateTime> ProjectCompletionDate { get; set; }
        public string Comment { get; set; }
        public string Creator { get; set; }
        public System.DateTime CreationDate { get; set; }
        public string GrantOther { get; set; }
        public string PilotOther { get; set; }
        public string StudyOther { get; set; }
    }
}
