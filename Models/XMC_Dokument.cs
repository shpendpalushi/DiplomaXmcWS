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
    
    public partial class XMC_Dokument
    {
        public long XMCDokument_Id { get; set; }
        public string Dokument_Path { get; set; }
        public string Dokument_Type { get; set; }
        public string Dokument_Content { get; set; }
        public long XMCTask_Id { get; set; }
    
        public virtual XMCTask XMCTask { get; set; }
    }
}
