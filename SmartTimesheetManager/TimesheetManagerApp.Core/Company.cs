//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TimesheetManagerApp.Core
{
    using System;
    using System.Collections.Generic;
    
    public partial class Company
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Company()
        {
            this.Company_User = new HashSet<Company_User>();
        }
    
        public int CompanyID { get; set; }
        public string CompanySerialNumber { get; set; }
        public string CompanyName { get; set; }
        public int PaymentPlan { get; set; }
        public System.DateTime RegisterdDate { get; set; }
        public bool Status { get; set; }
    
        public virtual PaymentPlan PaymentPlan1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Company_User> Company_User { get; set; }
    }
}