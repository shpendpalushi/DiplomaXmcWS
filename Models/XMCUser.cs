//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DiplomaXMCWS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class XMCUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public XMCUser()
        {
            this.XMCStatistikas = new HashSet<XMCStatistika>();
            this.XMCStatistikas1 = new HashSet<XMCStatistika>();
            this.XMCTasks = new HashSet<XMCTask>();
            this.XMCTasks1 = new HashSet<XMCTask>();
            this.XMCProjekts = new HashSet<XMCProjekt>();
        }
    
        public long XMCUsers_Id { get; set; }
        public string Users_Full_Name { get; set; }
        public string Users_Email { get; set; }
        public string Users_Username { get; set; }
        public string Users_Password { get; set; }
        public string Users_Description { get; set; }
        public long XMCPozicion_Id { get; set; }
    
        public virtual XMCPozicion XMCPozicion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XMCStatistika> XMCStatistikas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XMCStatistika> XMCStatistikas1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XMCTask> XMCTasks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XMCTask> XMCTasks1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XMCProjekt> XMCProjekts { get; set; }
    }
}
