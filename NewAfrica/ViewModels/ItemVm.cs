using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewAfrica.ViewModels
{
    public class ItemVm
    {
        public long iditem { get; set; }
        public string designation { get; set; }
        public string designdetails { get; set; }
        public long idsf { get; set; }
        public string libsf { get; set; }
        public int ordresf { get; set; }
        public decimal prixitem { get; set; }
        public string path1 {  get; set; }
        public string path2 { get; set; }
        public string path3 { get; set; }
    }
}