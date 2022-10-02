using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects
{
    public class HumanPhenotypeOntology
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string GeneId { get; set; }
        public string GeneSymbol { get; set; }
        public string GeneDatabase { get; set; }
        public string DiseaseID { get; set; }

    }
}
