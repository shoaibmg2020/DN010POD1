//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class SalaryInfo
    {
        public int SalarySheetNo { get; set; }
        public int EmpCode { get; set; }
        public System.DateTime DateOfSalary { get; set; }
        public decimal Basic { get; set; }
        public Nullable<decimal> HRA { get; set; }
        public Nullable<decimal> DA { get; set; }
        public Nullable<decimal> NetSalary { get; set; }
    
        public virtual EmpMaster EmpMaster { get; set; }
    }
}