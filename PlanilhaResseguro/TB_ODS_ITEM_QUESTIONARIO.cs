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
    
    public partial class TB_ODS_ITEM_QUESTIONARIO
    {
        public string CD_APOLICE { get; set; }
        public string CD_ENDOSSO { get; set; }
        public int CD_ITEM { get; set; }
        public int CD_PERG { get; set; }
        public string DS_PERG { get; set; }
        public Nullable<int> CD_RESP { get; set; }
        public string DS_RESP { get; set; }
        public string RESP_ITEM { get; set; }
        public Nullable<int> TP_RESP { get; set; }
        public Nullable<System.DateTime> DT_CARGA { get; set; }
        public string CD_ORIGEM { get; set; }
        public string TP_ENDOSSO { get; set; }
    
        public virtual TB_ODS_ITEM TB_ODS_ITEM { get; set; }
    }
}