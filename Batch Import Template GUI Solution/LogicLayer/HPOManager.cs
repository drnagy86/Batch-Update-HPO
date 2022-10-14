using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObjects;
using DataAccessLayer;


namespace LogicLayer
{
    public class HPOManager : IHPOManager
    {
        IHPODataAccessor _hPODataAccessor = null;

        public HPOManager()
        {
            _hPODataAccessor = new HPODDataAccessor();
        }

        public HPOManager(IHPODataAccessor hPODataAccessor)
        {
            _hPODataAccessor = hPODataAccessor;
        }

        public List<HumanPhenotypeOntology> RetrieveHumanPhenotypeOntologyIdAndLabels()
        {
            List<HumanPhenotypeOntology> result = new List<HumanPhenotypeOntology>();

            try
            {
                result = _hPODataAccessor.GetHumanPhenotypeOntologyIdAndLabels();
            }
            catch (Exception ex)
            {

                throw ex;
            }


            return result;            
        }
    }
}
