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
    
    public partial class XMCProjekt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public XMCProjekt()
        {
            this.XMCTasks = new HashSet<XMCTask>();
            this.XMCUsers = new HashSet<XMCUser>();
        }
    
        public long XMCProjekt_Id { get; set; }
        public string Projekt_Name { get; set; }
        public int Projekt_Hours_Precalculated { get; set; }
        public string Projekt_Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XMCTask> XMCTasks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XMCUser> XMCUsers { get; set; }
    }
}
