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
    
    public partial class TB_ODS_AVISO_CREDITO
    {
        public long ID_AVISO_CREDITO { get; set; }
        public short CD_STATUS_AVISO_CREDITO { get; set; }
        public Nullable<System.DateTime> DT_INCLUSAO { get; set; }
        public Nullable<System.DateTime> DT_CANCELADO { get; set; }
        public decimal VL_TOTAL_AVISO_CREDITO { get; set; }
        public Nullable<int> ID_CONVENIO_CARTEIRA { get; set; }
        public System.DateTime DT_AVISO_CREDITO { get; set; }
        public Nullable<System.DateTime> DT_CARGA { get; set; }
        public Nullable<System.DateTime> DT_EVO_DM { get; set; }
        public Nullable<int> NUM_SEQ { get; set; }
        public string CD_MOEDA { get; set; }
        public Nullable<decimal> VL_MOEDA { get; set; }
        public Nullable<System.DateTime> DT_COTACAO_MOEDA { get; set; }
        public Nullable<decimal> VL_AVISO_CREDITO_ORIGINAL { get; set; }
    }
}
