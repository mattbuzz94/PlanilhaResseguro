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
    
    public partial class TB_ODS_F_COMISSAO
    {
        public string CD_LIDER { get; set; }
        public string NR_APOLICE_DW { get; set; }
        public string TP_ENDOSSO { get; set; }
        public string NR_ENDOSSO_DW { get; set; }
        public int CD_PARCELA { get; set; }
        public string CD_RAMO_SUSEP { get; set; }
        public string CD_ITEM { get; set; }
        public string CD_COBERTURA { get; set; }
        public string CD_CORRETOR { get; set; }
        public string CD_ORIGEM { get; set; }
        public int CD_EVENTO { get; set; }
        public string CD_SISTEMA { get; set; }
        public System.DateTime DT_OPERACAO { get; set; }
        public System.DateTime DT_LANCAMENTO { get; set; }
        public short NR_PARCELAS { get; set; }
        public int TP_COMISSAO { get; set; }
        public decimal VL_COMISSAO { get; set; }
        public decimal VL_CUSTO_COMISSAO { get; set; }
        public string CD_MOEDA { get; set; }
        public int CD_EXTRATO { get; set; }
        public int NR_ANO_MES_EXTRATO { get; set; }
        public long ID_SEQUENCIA { get; set; }
        public System.DateTime DT_CARGA { get; set; }
        public Nullable<System.DateTime> DT_PROCESSAMENTO { get; set; }
        public string NM_ARQUIVO { get; set; }
        public string DS_OBSERVACAO { get; set; }
    }
}