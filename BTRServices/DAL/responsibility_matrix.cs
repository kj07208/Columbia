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
    using System.Collections.Generic;
    
    public partial class responsibility_matrix
    {
        public int responsibility_matrix_key { get; set; }
        public int index_key { get; set; }
        public string name { get; set; }
        public string uni { get; set; }
    
        public virtual index index { get; set; }
    }
}