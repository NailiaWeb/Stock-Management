//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrderManageForShop
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderDetail
    {
        public int Id { get; set; }
        public int OrderID { get; set; }
        public int ItemID { get; set; }
        public int Qty { get; set; }
        public double Total { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual Purchase Purchase { get; set; }
    }
}
