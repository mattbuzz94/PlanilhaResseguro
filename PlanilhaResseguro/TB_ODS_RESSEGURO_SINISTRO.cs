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
    
    public partial class TB_ODS_RESSEGURO_SINISTRO
    {
        public string CD_SINISTRO { get; set; }
        public string CD_PLANILHA_CEDE { get; set; }
        public string CD_LANCAMENTO { get; set; }
        public string CD_CONTABIL { get; set; }
        public string CD_RESSEGURADOR { get; set; }
        public int CD_EVENTO { get; set; }
        public string CD_MOVIMENTO { get; set; }
        public string CD_MOVIMENTO_ORIGINAL { get; set; }
        public System.DateTime DT_MOVIMENTO { get; set; }
        public decimal VL_MOVIMENTO { get; set; }
        public string DS_ARQUIVO { get; set; }
        public Nullable<System.DateTime> DT_CARGA { get; set; }
        public string CD_CTR_RESSEGURO { get; set; }
        public Nullable<long> ID_EXTRACAO_SINISTRO { get; set; }
    
        public virtual TB_ODS_RESSEGURADOR TB_ODS_RESSEGURADOR { get; set; }
    }
}
