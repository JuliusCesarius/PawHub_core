﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects.DataClasses;
using blastic.patterns.interfaces;

namespace blastic.patterns.clases
{
    public class BusinessRulesBase<T> : CrossValidation, ICrossValidation
        where T : EntityObject
    {
        //TODO: Implentar código genérico entre business rules
    }
}
