using SearchMaps.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchMaps.Models.Poco
{
    public class MainTableView
    {
        public int Id { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Locality { get; set; }
        public Region Region { get; set; }
    }
}
