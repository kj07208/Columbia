//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BTRServices.DAL
{
    using System;
    
    public partial class budget_transfer_request_datarecord_Result
    {
        public int btr_key { get; set; }
        public System.Guid btr_guid { get; set; }
        public int budget_type_key { get; set; }
        public string budget_type { get; set; }
        public int life_cycle_key { get; set; }
        public string internal_state { get; set; }
        public int internal_state_key { get; set; }
        public string request_uni_code { get; set; }
        public int requestor_uni_key { get; set; }
        public decimal total_amount { get; set; }
        public string explanation { get; set; }
        public bool priority_flag { get; set; }
        public string life_cycle { get; set; }
        public string title { get; set; }
        public Nullable<int> transfer_type_key { get; set; }
        public string transfer_type { get; set; }
        public System.DateTime created { get; set; }
        public int created_by { get; set; }
        public string created_by_name { get; set; }
        public System.DateTime modified { get; set; }
        public int modified_by { get; set; }
        public string modified_by_name { get; set; }
    }
}
