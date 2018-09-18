using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider.Models
{
    public class ApplyEdits
    {
        public List<Graphic> addFeatures { get; set; }
        public List<Graphic> updateFeatures { get; set; }
        public List<Graphic> deleteFeatures { get; set; }
    }
    public class Graphic
    {
        public List<string> attributes { get; set; }
    }
}
