using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObjects;

namespace DataAccessLayer
{
    public class HPODDataAccessor : IHPODataAccessor
    {
        public List<HumanPhenotypeOntology> GetHumanPhenotypeOntologyIdAndLabels()
        {
            List<HumanPhenotypeOntology> results = new List<HumanPhenotypeOntology>();

            try
            {
                StreamReader fileReader = new StreamReader(AppData.DataPath + @"\" + AppData.HPOFileName);
            }
            catch (Exception ex)
            {

                throw ex;
            }




            return results;
        }
    }
}
