//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PlanilhaResseguro
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_ODS_CLASS_CORRETOR
    {
        public string CD_CORR { get; set; }
        public string CLASS_CORRETOR { get; set; }
        public string CAT_CORRETOR { get; set; }
        public Nullable<System.DateTime> DAT_CARGA { get; set; }
    
        public virtual TB_ODS_CORRETOR TB_ODS_CORRETOR { get; set; }
    }
}