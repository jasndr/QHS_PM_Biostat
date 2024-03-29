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
    
    public partial class BioStats
    {
        public BioStats()
        {
            this.ClientRequest2 = new HashSet<ClientRequest2>();
            this.GrantBiostat = new HashSet<GrantBiostat>();
            this.Project2Biostat = new HashSet<Project2Biostat>();
            this.ProjectBioStat = new HashSet<ProjectBioStat>();
            this.PublicationBioStat = new HashSet<PublicationBioStat>();
            this.Tasks = new HashSet<Tasks>();
            this.TimeEntries = new HashSet<TimeEntries>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string LogonId { get; set; }
        public string Email { get; set; }
        public System.DateTime EndDate { get; set; }
        public long BitValue { get; set; }
    
        public virtual ICollection<ClientRequest2> ClientRequest2 { get; set; }
        public virtual ICollection<GrantBiostat> GrantBiostat { get; set; }
        public virtual ICollection<Project2Biostat> Project2Biostat { get; set; }
        public virtual ICollection<ProjectBioStat> ProjectBioStat { get; set; }
        public virtual ICollection<PublicationBioStat> PublicationBioStat { get; set; }
        public virtual ICollection<Tasks> Tasks { get; set; }
        public virtual ICollection<TimeEntries> TimeEntries { get; set; }
    }
}
