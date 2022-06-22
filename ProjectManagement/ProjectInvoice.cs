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
    
    public partial class ProjectInvoice
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string RequestNumber { get; set; }
        public Nullable<System.DateTime> RequestDate { get; set; }
        public Nullable<decimal> RequestedPhd { get; set; }
        public Nullable<decimal> RequestedMS { get; set; }
        public Nullable<decimal> ApprovedPhd { get; set; }
        public Nullable<decimal> ApprovedMS { get; set; }
        public Nullable<decimal> WorkedPhd { get; set; }
        public Nullable<decimal> WorkedMS { get; set; }
        public Nullable<decimal> InvoicedPhd { get; set; }
        public Nullable<decimal> InvoicedMS { get; set; }
        public Nullable<System.DateTime> InvoiceDate { get; set; }
        public string InvoiceNumber { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
        public Nullable<System.DateTime> ClientApproveDate { get; set; }
        public Nullable<System.DateTime> RequestApproveDate { get; set; }
        public string Comment { get; set; }
        public bool Deleted { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string Creator { get; set; }
    
        public virtual Projects Projects { get; set; }
    }
}