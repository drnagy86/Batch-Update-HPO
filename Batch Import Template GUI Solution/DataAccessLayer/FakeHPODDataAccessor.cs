using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObjects;

namespace DataAccessLayer
{
    public class FakeHPODDataAccessor : IHPODataAccessor
    {

        private List<HumanPhenotypeOntology> _fakeHpo = null;

        public FakeHPODDataAccessor()
        {            

            _fakeHpo = new List<HumanPhenotypeOntology>();
            _fakeHpo.Add( new HumanPhenotypeOntology()
                {
                    Id = "HP:0010711",
                    Label = "1-2 toe syndactyly"
            });
            _fakeHpo.Add(new HumanPhenotypeOntology()
                {
                Id = "HP:0005112",
                Label = "Abdominal aortic aneurysm "
            });
            _fakeHpo.Add(new HumanPhenotypeOntology()
                {
                Id = "HP:0009131",
                Label = "Abnormality of the musculature of the thorax"
            });
            _fakeHpo.Add(new HumanPhenotypeOntology()
                {
                Id = "HP: 0003250",
                Label = "Aplasia of the vagina"
            });
            _fakeHpo.Add(new HumanPhenotypeOntology()
                {
                Id = "HP:0040169",
                Label = "Loose anagen hair"
            });
            _fakeHpo.Add(new HumanPhenotypeOntology()
                {
                Id = "HP:0030814",
                Label = "Orange discolored tonsils"
            });

        }

        public List<HumanPhenotypeOntology> GetHumanPhenotypeOntologyIdAndLabels()
        {
            return _fakeHpo;
        }
    }
}
