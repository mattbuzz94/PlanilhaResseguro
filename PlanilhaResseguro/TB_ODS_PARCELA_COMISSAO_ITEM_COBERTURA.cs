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
    
    public partial class TB_ODS_PARCELA_COMISSAO_ITEM_COBERTURA
    {
        public string CD_APOLICE { get; set; }
        public string CD_ENDOSSO { get; set; }
        public int CD_ITEM { get; set; }
        public string CD_COBERTURA { get; set; }
        public int CD_PARCELA { get; set; }
        public string CD_RAMO { get; set; }
        public string CD_CORRETOR { get; set; }
        public int TP_COMISSAO { get; set; }
        public string CD_ORIGEM { get; set; }
        public string TP_ENDOSSO { get; set; }
        public Nullable<decimal> PC_PARCELA_COMISSAO { get; set; }
        public Nullable<decimal> VL_COMISSAO { get; set; }
        public Nullable<decimal> VL_COMISSAO_ANTECIPADO { get; set; }
        public Nullable<int> CD_EXTRATO { get; set; }
        public string CD_SITUACAO_PARCELA { get; set; }
        public Nullable<decimal> VL_COMISSAO_ASSISTENCIA { get; set; }
        public Nullable<System.DateTime> DT_CARGA { get; set; }
        public string NR_MES_REFERENCIA_EXTENSO { get; set; }
        public int CD_EXTERNO { get; set; }
        public int CD_LANCAMENTO { get; set; }
        public byte TP_LANCAMENTO { get; set; }
        public Nullable<decimal> VL_CUSTO_COMISSAO { get; set; }
        public Nullable<System.DateTime> DT_PREVISAO_PAGAMENTO { get; set; }
        public Nullable<decimal> VL_JUROS_COMISSAO { get; set; }
        public Nullable<decimal> VL_JUROS_COMISSAO_ASSISTENCIA { get; set; }
    
        public virtual TB_ODS_CORRETOR TB_ODS_CORRETOR { get; set; }
        public virtual TB_ODS_EMISSAO TB_ODS_EMISSAO { get; set; }
    }
}
