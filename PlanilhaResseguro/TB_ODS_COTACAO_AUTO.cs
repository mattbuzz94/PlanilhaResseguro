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
    
    public partial class TB_ODS_COTACAO_AUTO
    {
        public string CD_COTACAO { get; set; }
        public System.DateTime DATA_COTACAO { get; set; }
        public int CD_ITEM { get; set; }
        public string TP_REGISTRO { get; set; }
        public string CD_PRODUTO { get; set; }
        public string CD_CORRETOR { get; set; }
        public string NM_SEGURADO { get; set; }
        public string NR_CPF_CNPJ { get; set; }
        public string NR_CPF_CNPJ_COTACAO { get; set; }
        public string CD_ORIGEM { get; set; }
        public string DS_ORIGEM { get; set; }
        public string DS_ANO_FABRICACAO { get; set; }
        public string DS_ANO_MODELO { get; set; }
        public string CD_CATEG_TARIFARIA { get; set; }
        public string CD_CEP_PERNOITE { get; set; }
        public Nullable<double> CD_CATEG_BONUS { get; set; }
        public string CD_VEICULO { get; set; }
        public string CD_FRANQUIA { get; set; }
        public string IND_ZERO_KM { get; set; }
        public string CD_PLACA { get; set; }
        public string CD_CHASSI { get; set; }
        public Nullable<int> CD_RENAVAN { get; set; }
        public string QTD_PASSAGEIROS { get; set; }
        public string QTD_PORTAS { get; set; }
        public string CD_REGIAO_TARIFARIA { get; set; }
        public string TP_COMBUSTIVEL { get; set; }
        public string DS_COMBUSTIVEL { get; set; }
        public string TP_DAF { get; set; }
        public string TP_MODALIDADE { get; set; }
        public Nullable<double> PERC_VARIACAO { get; set; }
        public string TP_RENOVACAO { get; set; }
        public string DS_RENOVACAO { get; set; }
        public string CD_UTILIZACAO { get; set; }
        public Nullable<decimal> IS_CASCO { get; set; }
        public Nullable<decimal> IS_DM { get; set; }
        public Nullable<decimal> IS_DC { get; set; }
        public Nullable<decimal> IS_APP { get; set; }
        public Nullable<decimal> VL_PREMIO_TOTAL { get; set; }
        public Nullable<int> QTDE_CALCULOS { get; set; }
        public Nullable<int> QTDE_EMISSOES { get; set; }
        public Nullable<System.DateTime> DT_EVO_DM { get; set; }
        public Nullable<System.DateTime> DT_CARGA { get; set; }
        public Nullable<int> CD_CONTROLADORA_DECISAO { get; set; }
        public Nullable<int> CD_CONTROLE_PROPONENTE { get; set; }
        public string DS_CONTROLE_PROPONENTE { get; set; }
        public string CD_CONTROLE_CONDUTOR { get; set; }
        public string DS_CONTROLE_CONDUTOR { get; set; }
        public string CD_CONTROLE_VEICULO { get; set; }
        public string DS_CONTROLE_VEICULO { get; set; }
        public string TAXA_CALCULO { get; set; }
    }
}