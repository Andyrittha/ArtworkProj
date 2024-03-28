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
    
    public partial class IGRID_M_OUTBOUND_HEADER
    {
        public int IGRID_OUTBOUND_HEADER_ID { get; set; }
        public string ARTWORK_NO { get; set; }
        public string DATE { get; set; }
        public string TIME { get; set; }
        public string RECORD_TYPE { get; set; }
        public string MATERIAL_NUMBER { get; set; }
        public string MATERIAL_DESCRIPTION { get; set; }
        public Nullable<System.DateTime> MATERIAL_CREATE_DATE { get; set; }
        public string ARTWORK_URL { get; set; }
        public string STATUS { get; set; }
        public string PA_USER_NAME { get; set; }
        public string PG_USER_NAME { get; set; }
        public string REFERENCE_MATERIAL { get; set; }
        public string PLANT { get; set; }
        public string PRINTING_STYLE_OF_PRIMARY { get; set; }
        public string PRINTING_STYLE_OF_SECONDARY { get; set; }
        public string CUSTOMER_DESIGN { get; set; }
        public string CUSTOMER_DESIGN_DETAIL { get; set; }
        public string CUSTOMER_SPEC { get; set; }
        public string CUSTOMER_SPEC_DETAIL { get; set; }
        public string CUSTOMER_SIZE { get; set; }
        public string CUSTOMER_SIZE_DETAIL { get; set; }
        public string CUSTOMER_NOMINATES_VENDOR { get; set; }
        public string CUSTOMER_NOMINATES_VENDOR_DETAIL { get; set; }
        public string CUSTOMER_NOMINATES_COLOR { get; set; }
        public string CUSTOMER_NOMINATES_COLOR_DETAIL { get; set; }
        public string CUSTOMER_BARCODE_SCANABLE { get; set; }
        public string CUSTOMER_BARCODE_SCANABLE_DETAIL { get; set; }
        public string CUSTOMER_BARCODE_SPEC { get; set; }
        public string CUSTOMER_BARCODE_SPEC_DETAIL { get; set; }
        public string FIRST_INFO_GROUP { get; set; }
        public string SO_NUMBER { get; set; }
        public string SO_ITEM { get; set; }
        public string SO_PLANT { get; set; }
        public string PIC_MKT { get; set; }
        public string DESTINATION { get; set; }
        public string NOTE_OF_PA { get; set; }
        public string FINAL_INFO_GROUP { get; set; }
        public string NOTE_OF_PG { get; set; }
        public string COMPLETE_INFO_GROUP { get; set; }
        public string EXPIRY_DATE_SYSTEM { get; set; }
        public string SERIOUSNESS_OF_COLOR_PRINTING { get; set; }
        public string ANALYSIS { get; set; }
        public string SHADE_LIMIT { get; set; }
        public Nullable<decimal> PACKAGE_QUANTITY { get; set; }
        public Nullable<decimal> WASTE_PERCENT { get; set; }
        public System.DateTime CREATE_DATE { get; set; }
        public int CREATE_BY { get; set; }
        public System.DateTime UPDATE_DATE { get; set; }
        public int UPDATE_BY { get; set; }
        public string CHANGE_POINT { get; set; }
    }
}