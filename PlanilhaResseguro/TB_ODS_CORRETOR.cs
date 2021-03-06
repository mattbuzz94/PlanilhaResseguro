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
    
    public partial class TB_ODS_CORRETOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_ODS_CORRETOR()
        {
            this.TB_ODS_PARTCORRETOR = new HashSet<TB_ODS_PARTCORRETOR>();
            this.TB_ODS_EMISSAO = new HashSet<TB_ODS_EMISSAO>();
            this.TB_ODS_PARCELA_COMISSAO_ITEM_COBERTURA = new HashSet<TB_ODS_PARCELA_COMISSAO_ITEM_COBERTURA>();
        }
    
        public string CD_CORR { get; set; }
        public string NM_CORR { get; set; }
        public string CD_CPF_CNPJ_CORR { get; set; }
        public string TP_PESS { get; set; }
        public string CD_SUSEP { get; set; }
        public string CD_EXECUTIVO { get; set; }
        public string CD_SEGMENTO { get; set; }
        public string CD_AGRUPAMENTO { get; set; }
        public string CD_FILIAL { get; set; }
        public string CD_CENTRO_CUSTO { get; set; }
        public Nullable<System.DateTime> DT_CARGA { get; set; }
        public string CD_PESS { get; set; }
        public string CD_CANAL { get; set; }
        public string CD_CLASSE_CORRETOR { get; set; }
        public string ST_CORRETOR { get; set; }
        public string DS_ENDERECO { get; set; }
        public string NR_ENDERECO { get; set; }
        public string NM_CIDADE { get; set; }
        public string NM_BAIRRO { get; set; }
        public string CD_UF { get; set; }
        public string CD_CEP { get; set; }
        public Nullable<System.DateTime> DT_INCLUSAO { get; set; }
        public string ST_STATUS { get; set; }
        public Nullable<bool> CD_MULTICALCULO { get; set; }
        public string CD_SUB_DOMINIO_CLASSIFICA_CORRETOR { get; set; }
    
        public virtual TB_ODS_AGRUPAMENTO TB_ODS_AGRUPAMENTO { get; set; }
        public virtual TB_ODS_CANAL TB_ODS_CANAL { get; set; }
        public virtual TB_ODS_CLASS_CORRETOR TB_ODS_CLASS_CORRETOR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_ODS_PARTCORRETOR> TB_ODS_PARTCORRETOR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_ODS_EMISSAO> TB_ODS_EMISSAO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_ODS_PARCELA_COMISSAO_ITEM_COBERTURA> TB_ODS_PARCELA_COMISSAO_ITEM_COBERTURA { get; set; }
        public virtual TB_ODS_EXECUTIVO TB_ODS_EXECUTIVO { get; set; }
        public virtual TB_ODS_HIERARQUIA TB_ODS_HIERARQUIA { get; set; }
        public virtual TB_ODS_SEGMENTO TB_ODS_SEGMENTO { get; set; }
    }
}
