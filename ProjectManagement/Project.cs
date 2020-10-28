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
    
    public partial class Project
    {
        public Project()
        {
            this.ProjectBioStats = new HashSet<ProjectBioStat>();
            this.ProjectGrants = new HashSet<ProjectGrant>();
            this.ProjectServiceTypes = new HashSet<ProjectServiceType>();
            this.ProjectStudies = new HashSet<ProjectStudy>();
            this.ProjectServiceDetails = new HashSet<ProjectServiceDetail>();
            this.ProjectInvoices = new HashSet<Invoice>();
            this.ClientRequest = new HashSet<ClientRequest>();
        }
    
        public int Id { get; set; }
        public int InvestId { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public Nullable<System.DateTime> DeadLine { get; set; }
        public System.DateTime InitialDate { get; set; }
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
        public Nullable<System.DateTime> AnslysisCompletionDate { get; set; }
        public Nullable<int> RedcapId { get; set; }
        public Nullable<System.DateTime> ProjectCompletionDate { get; set; }
        public string Comment { get; set; }
        public string Creator { get; set; }
        public System.DateTime CreationDate { get; set; }
        public string GrantOther { get; set; }
        public string PilotOther { get; set; }
        public string StudyOther { get; set; }
        public string StudyType { get; set; }
        public string StudyPopulation { get; set; }
        public bool IsJuniorPI { get; set; }
        public bool IsRmatrix { get; set; }
        public Nullable<int> RmatrixNum { get; set; }
        public Nullable<System.DateTime> RmatrixSubDate { get; set; }
        public Nullable<System.DateTime> RmatrixRcvDate { get; set; }
        public bool NotReportRmatrix { get; set; }
    
        public virtual ICollection<ProjectBioStat> ProjectBioStats { get; set; }
        public virtual ICollection<ProjectGrant> ProjectGrants { get; set; }
        public virtual ICollection<ProjectServiceType> ProjectServiceTypes { get; set; }
        public virtual ICollection<ProjectStudy> ProjectStudies { get; set; }
        public virtual ICollection<ProjectServiceDetail> ProjectServiceDetails { get; set; }
        public virtual ICollection<Invoice> ProjectInvoices { get; set; }
        public virtual ICollection<ClientRequest> ClientRequest { get; set; }
        public virtual Invests Invests { get; set; }
    }
}
