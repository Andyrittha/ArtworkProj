﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{

    public class WHManagement_MODEL : IGRID_AUTHROLIZE_CHANGE
    {
        public int Id { get; set; }
        public string ProductGroup { get; set; }
        public string Description { get; set; }
        public string Plant { get; set; }
        public string WHNumber { get; set; }
        public string StorageType { get; set; }
        public string LE_Qty { get; set; }
        public string Storage_UnitType { get; set; }
        public string Inactive { get; set; }

    }
    public class WHManagement_REQUEST : REQUEST_MODEL
    {
        public string user { get; set; }
        public string Type { get; set; }
        public string Keyword { get; set; }
        public WHManagement_MODEL data { get; set; }
    }
    public class WHManagement_REQUEST_LIST : REQUEST_MODEL
    {
        public List<WHManagement_MODEL> data { get; set; }
    }
    public class WHManagement_RESULT : RESULT_MODEL
    {
        public List<WHManagement_MODEL> data { get; set; }
    }
}