//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PoseidonShared.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class viewProductDetail
    {
        public Nullable<System.DateTime> DateAdded { get; set; }
        public Nullable<int> StockId { get; set; }
        public int ProductId { get; set; }
        public int StockItemId { get; set; }
        public string ProductName { get; set; }
        public string GenericName { get; set; }
        public string Origin { get; set; }
        public string Strength { get; set; }
        public int Quantity { get; set; }
        public string PackSize { get; set; }
        public Nullable<int> QtyPackSize { get; set; }
        public Nullable<int> ReorderLevel { get; set; }
        public string BatchNo { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        public string Location { get; set; }
        public string MajorSupplier { get; set; }
        public Nullable<decimal> CostPerUnit { get; set; }
        public Nullable<decimal> TotalCost { get; set; }
        public int WarehouseNo { get; set; }
    }
}