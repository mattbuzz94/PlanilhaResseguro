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
    
    public partial class TB_ODS_DAF
    {
        public int NR_SEQUENCIA { get; set; }
        public string CD_ORIGEM { get; set; }
        public string NR_PROPOSTA { get; set; }
        public string CD_PROD { get; set; }
        public string CD_RAMO { get; set; }
        public System.DateTime DT_MOVIMENTACAO { get; set; }
        public string CD_DISPOSITIVO { get; set; }
        public int TP_SERVICO { get; set; }
        public double VL_SERVICO { get; set; }
        public string CD_PESSOA { get; set; }
        public System.DateTime DT_CARGA { get; set; }
        public Nullable<System.DateTime> DT_EVO_SUN { get; set; }
        public Nullable<int> NR_SEQ { get; set; }
        public string CD_CORR { get; set; }
    }
}