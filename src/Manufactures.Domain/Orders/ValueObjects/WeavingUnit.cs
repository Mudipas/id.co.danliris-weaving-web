﻿using Moonlay.Domain;
using System.Collections.Generic;

namespace Manufactures.Domain.Orders.ValueObjects
{
    public class WeavingUnit : ValueObject
    {
        public WeavingUnit(string id, string code, string name)
        {
            _id = id;
            Code = code;
            Name = name;
        }

        public string _id { get; private set; }
        public string Code { get; private set; }
        public string Name { get; private set; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return _id;
            yield return Code;
            yield return Name;
        }
    }
}
