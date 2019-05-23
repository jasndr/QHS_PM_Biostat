﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ProjectTrackerContainer : DbContext
    {
        public ProjectTrackerContainer()
            : base("name=ProjectTrackerContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Invests> Invests { get; set; }
        public virtual DbSet<InvestStatus> InvestStatus { get; set; }
        public virtual DbSet<ServiceType> ServiceTypes { get; set; }
        public virtual DbSet<BioStatGroup> BioStatGroups { get; set; }
        public virtual DbSet<BioStat> BioStats { get; set; }
        public virtual DbSet<GrantApp> GrantApps { get; set; }
        public virtual DbSet<GrantAffil> GrantAffils { get; set; }
        public virtual DbSet<Pilot> Pilots { get; set; }
        public virtual DbSet<HiProgram> HiPrograms { get; set; }
        public virtual DbSet<EthnicGroup> EthnicGroups { get; set; }
        public virtual DbSet<JabsomDept> JabsomDepts { get; set; }
        public virtual DbSet<JabsomOffice> JabsomOffices { get; set; }
        public virtual DbSet<JabsomAffil> JabsomAffils { get; set; }
        public virtual DbSet<Conference> Conferences { get; set; }
        public virtual DbSet<TimeEntry> TimeEntries { get; set; }
        public virtual DbSet<ProjectBioStat> ProjectBioStats { get; set; }
        public virtual DbSet<ProjectGrant> ProjectGrants { get; set; }
        public virtual DbSet<ProjectServiceType> ProjectServiceTypes { get; set; }
        public virtual DbSet<PublicationBioStat> PublicationBioStats { get; set; }
        public virtual DbSet<PublicationGrant> PublicationGrants { get; set; }
        public virtual DbSet<Publication> Publications { get; set; }
        public virtual DbSet<Journal> Journals { get; set; }
        public virtual DbSet<Date1> Date1 { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<PubHistory> PubHistories { get; set; }
        public virtual DbSet<PublishStatu> PublishStatus { get; set; }
        public virtual DbSet<PublishType> PublishTypes { get; set; }
        public virtual DbSet<ProjectStudy> ProjectStudies { get; set; }
        public virtual DbSet<CoAuthorAffil> CoAuthorAffils { get; set; }
        public virtual DbSet<PublicationCoAuthorAffil> PublicationCoAuthorAffils { get; set; }
        public virtual DbSet<ProjectServiceDetail> ProjectServiceDetails { get; set; }
        public virtual DbSet<StudyPopulation> StudyPopulations { get; set; }
        public virtual DbSet<StudyType> StudyTypes { get; set; }
        public virtual DbSet<BiostatReport> BiostatReports { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<ViewInvoice> ViewInvoices { get; set; }
        public virtual DbSet<GrantBiostat> GrantBiostats { get; set; }
        public virtual DbSet<GrantFundStatu> GrantFundStatus { get; set; }
        public virtual DbSet<GrantPI> GrantPIs { get; set; }
        public virtual DbSet<Grant> Grants { get; set; }
        public virtual DbSet<ViewGrant> ViewGrants { get; set; }
        public virtual DbSet<Survey> Surveys { get; set; }
        public virtual DbSet<SurveyForm> SurveyForms { get; set; }
        public virtual DbSet<SurveyFormAnswer> SurveyFormAnswers { get; set; }
        public virtual DbSet<SurveyQuestion> SurveyQuestions { get; set; }
        public virtual DbSet<SurveyQuestionOption> SurveyQuestionOptions { get; set; }
        public virtual DbSet<PTTask> PTTasks { get; set; }
        public virtual DbSet<TaskField> TaskFields { get; set; }
        public virtual DbSet<TaskHistory> TaskHistories { get; set; }
        public virtual DbSet<ClientRequest> ClientRequest { get; set; }
        public virtual DbSet<ClientAgmt> ClientAgmt { get; set; }
        public virtual DbSet<CollabCtr> CollabCtr { get; set; }
        public virtual DbSet<Invoice1> Invoice1Set { get; set; }
        public virtual DbSet<ProjectPhase> ProjectPhase { get; set; }
        public virtual DbSet<vwBiostatTime> vwBiostatTime { get; set; }
        public virtual DbSet<Academic> Academic { get; set; }
        public virtual DbSet<ProjectField> ProjectField { get; set; }
        public virtual DbSet<AcademicField> AcademicField { get; set; }
        public virtual DbSet<vwProjectBiostat> vwProjectBiostat { get; set; }
        public virtual DbSet<InvoiceItem2> InvoiceItem2 { get; set; }
        public virtual DbSet<vwAgreement> vwAgreement { get; set; }
        public virtual DbSet<vwProject> vwProject { get; set; }
        public virtual DbSet<Project2> Project2 { get; set; }
        public virtual DbSet<ViewGrant2> ViewGrant2 { get; set; }
    
        public virtual int P_PROJECT_HOURS(Nullable<System.DateTime> startDate, Nullable<System.DateTime> endDate, Nullable<int> projectId, ObjectParameter phdHours, ObjectParameter mSHours)
        {
            var startDateParameter = startDate.HasValue ?
                new ObjectParameter("StartDate", startDate) :
                new ObjectParameter("StartDate", typeof(System.DateTime));
    
            var endDateParameter = endDate.HasValue ?
                new ObjectParameter("EndDate", endDate) :
                new ObjectParameter("EndDate", typeof(System.DateTime));
    
            var projectIdParameter = projectId.HasValue ?
                new ObjectParameter("ProjectId", projectId) :
                new ObjectParameter("ProjectId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("P_PROJECT_HOURS", startDateParameter, endDateParameter, projectIdParameter, phdHours, mSHours);
        }
    
        public virtual int P_PROJECTPHASE_HOURS(Nullable<int> projectId, string phase, Nullable<System.DateTime> startDate, Nullable<System.DateTime> endDate, ObjectParameter phdHours, ObjectParameter mSHours)
        {
            var projectIdParameter = projectId.HasValue ?
                new ObjectParameter("ProjectId", projectId) :
                new ObjectParameter("ProjectId", typeof(int));
    
            var phaseParameter = phase != null ?
                new ObjectParameter("Phase", phase) :
                new ObjectParameter("Phase", typeof(string));
    
            var startDateParameter = startDate.HasValue ?
                new ObjectParameter("StartDate", startDate) :
                new ObjectParameter("StartDate", typeof(System.DateTime));
    
            var endDateParameter = endDate.HasValue ?
                new ObjectParameter("EndDate", endDate) :
                new ObjectParameter("EndDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("P_PROJECTPHASE_HOURS", projectIdParameter, phaseParameter, startDateParameter, endDateParameter, phdHours, mSHours);
        }
    
        public virtual ObjectResult<P_INVOICE_HOURS_Result> P_INVOICE_HOURS(Nullable<int> collabCtrId, Nullable<int> invoiceId, Nullable<System.DateTime> startDate, Nullable<System.DateTime> endDate, Nullable<bool> refresh)
        {
            var collabCtrIdParameter = collabCtrId.HasValue ?
                new ObjectParameter("CollabCtrId", collabCtrId) :
                new ObjectParameter("CollabCtrId", typeof(int));
    
            var invoiceIdParameter = invoiceId.HasValue ?
                new ObjectParameter("InvoiceId", invoiceId) :
                new ObjectParameter("InvoiceId", typeof(int));
    
            var startDateParameter = startDate.HasValue ?
                new ObjectParameter("StartDate", startDate) :
                new ObjectParameter("StartDate", typeof(System.DateTime));
    
            var endDateParameter = endDate.HasValue ?
                new ObjectParameter("EndDate", endDate) :
                new ObjectParameter("EndDate", typeof(System.DateTime));
    
            var refreshParameter = refresh.HasValue ?
                new ObjectParameter("Refresh", refresh) :
                new ObjectParameter("Refresh", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<P_INVOICE_HOURS_Result>("P_INVOICE_HOURS", collabCtrIdParameter, invoiceIdParameter, startDateParameter, endDateParameter, refreshParameter);
        }
    
        public virtual ObjectResult<P_INVOICE_HOURS2_Result> P_INVOICE_HOURS2(Nullable<int> collabCtrId, Nullable<int> invoiceId, Nullable<System.DateTime> startDate, Nullable<System.DateTime> endDate, Nullable<bool> refresh)
        {
            var collabCtrIdParameter = collabCtrId.HasValue ?
                new ObjectParameter("CollabCtrId", collabCtrId) :
                new ObjectParameter("CollabCtrId", typeof(int));
    
            var invoiceIdParameter = invoiceId.HasValue ?
                new ObjectParameter("InvoiceId", invoiceId) :
                new ObjectParameter("InvoiceId", typeof(int));
    
            var startDateParameter = startDate.HasValue ?
                new ObjectParameter("StartDate", startDate) :
                new ObjectParameter("StartDate", typeof(System.DateTime));
    
            var endDateParameter = endDate.HasValue ?
                new ObjectParameter("EndDate", endDate) :
                new ObjectParameter("EndDate", typeof(System.DateTime));
    
            var refreshParameter = refresh.HasValue ?
                new ObjectParameter("Refresh", refresh) :
                new ObjectParameter("Refresh", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<P_INVOICE_HOURS2_Result>("P_INVOICE_HOURS2", collabCtrIdParameter, invoiceIdParameter, startDateParameter, endDateParameter, refreshParameter);
        }
    
        public virtual ObjectResult<P_INVOICE_HOURS2a_Result> P_INVOICE_HOURS2a(Nullable<int> collabCtrId, Nullable<int> invoiceId, Nullable<System.DateTime> startDate, Nullable<System.DateTime> endDate, Nullable<bool> refresh, Nullable<bool> removeZeros)
        {
            var collabCtrIdParameter = collabCtrId.HasValue ?
                new ObjectParameter("CollabCtrId", collabCtrId) :
                new ObjectParameter("CollabCtrId", typeof(int));
    
            var invoiceIdParameter = invoiceId.HasValue ?
                new ObjectParameter("InvoiceId", invoiceId) :
                new ObjectParameter("InvoiceId", typeof(int));
    
            var startDateParameter = startDate.HasValue ?
                new ObjectParameter("StartDate", startDate) :
                new ObjectParameter("StartDate", typeof(System.DateTime));
    
            var endDateParameter = endDate.HasValue ?
                new ObjectParameter("EndDate", endDate) :
                new ObjectParameter("EndDate", typeof(System.DateTime));
    
            var refreshParameter = refresh.HasValue ?
                new ObjectParameter("Refresh", refresh) :
                new ObjectParameter("Refresh", typeof(bool));
    
            var removeZerosParameter = removeZeros.HasValue ?
                new ObjectParameter("RemoveZeros", removeZeros) :
                new ObjectParameter("RemoveZeros", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<P_INVOICE_HOURS2a_Result>("P_INVOICE_HOURS2a", collabCtrIdParameter, invoiceIdParameter, startDateParameter, endDateParameter, refreshParameter, removeZerosParameter);
        }
    }
}
