﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObjects;

namespace DataAccessLayer
{
    public interface IHPODataAccessor
    {
        List<HumanPhenotypeOntology> GetHumanPhenotypeOntologyIdAndLabels();
    }
}
