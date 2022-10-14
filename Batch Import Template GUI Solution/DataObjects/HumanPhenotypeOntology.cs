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
        public string Label { get; set; }

        public string[] ConvertToRow()
        {
            string[] row = new string[2];
            row[0] = Label;
            row[1] = Id;
            
            
            return row;            
        }

        public override string ToString()
        {
            return Label;
        }

    }
}
