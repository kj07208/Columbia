//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BTRServices
{
    using System;
    using System.Collections.Generic;
    
    public partial class approval_matrix
    {
        public int approval_matrix_key { get; set; }
        public string uni { get; set; }
        public string role_title { get; set; }
        public string role_level { get; set; }
        public Nullable<decimal> approval_limit { get; set; }
        public string next_approval_level { get; set; }
    
        public virtual index index { get; set; }
    }
}