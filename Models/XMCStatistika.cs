//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DiplomaXMCWS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class XMCStatistika
    {
        public long XMCStatistika_Id { get; set; }
        public string Statistika_Name { get; set; }
        public string Statistika_Description { get; set; }
        public long Creator_Id { get; set; }
        public long Referencer_Id { get; set; }
    
        public virtual XMCUser XMCUser { get; set; }
        public virtual XMCUser XMCUser1 { get; set; }
    }
}
