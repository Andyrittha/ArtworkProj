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
    
    public partial class ART_WF_MOCKUP_PROCESS
    {
        public int MOCKUP_SUB_ID { get; set; }
        public int MOCKUP_ID { get; set; }
        public Nullable<int> PARENT_MOCKUP_SUB_ID { get; set; }
        public Nullable<int> CURRENT_STEP_ID { get; set; }
        public Nullable<int> CURRENT_USER_ID { get; set; }
        public Nullable<int> CURRENT_ROLE_ID { get; set; }
        public Nullable<int> CURRENT_VENDOR_ID { get; set; }
        public Nullable<int> CURRENT_CUSTOMER_ID { get; set; }
        public string REMARK { get; set; }
        public string IS_END { get; set; }
        public Nullable<int> REASON_ID { get; set; }
        public string IS_TERMINATE { get; set; }
        public string REMARK_TERMINATE { get; set; }
        public string REMARK_KILLPROCESS { get; set; }
        public Nullable<int> TERMINATE_REASON_CODE { get; set; }
        public string IS_DELEGATE { get; set; }
        public string IS_STEP_DURATION_EXTEND { get; set; }
        public System.DateTime CREATE_DATE { get; set; }
        public int CREATE_BY { get; set; }
        public System.DateTime UPDATE_DATE { get; set; }
        public int UPDATE_BY { get; set; }
        public Nullable<int> STEP_DURATION_EXTEND_REASON_ID { get; set; }
        public string STEP_DURATION_EXTEND_REMARK { get; set; }
    }
}
