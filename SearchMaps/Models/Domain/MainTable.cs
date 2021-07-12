using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchMaps.Models
{
    public class MainTable
    {
        public int ID { get; set; }
        public string INN { get; set; }
        public string IdDoc { get; set; }
        public DateTime MakeDateDoc { get; set; }
        public DateTime IncludeDateSub { get; set; }
        public int VidSubMSP { get; set; }
        public int CatSubMSP { get; set; }
        public int PrizNovMSP { get; set; }
        public int SvedSocPred { get; set; }
        public int SSCHR { get; set; }
        public string Name { get; set; }
        public int RegionID { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Locality { get; set; }

        public int StatusID { get; set; }
    }
}
