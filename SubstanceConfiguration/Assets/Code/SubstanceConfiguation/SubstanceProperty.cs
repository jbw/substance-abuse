using UnityEngine;
using System.Linq;
using System.Collections.Generic;
using System;

public class SubstanceProperty
{
    public SubstanceProperty(string paramValue, float value)
    {
        Name = paramValue;
        Value = value;
    }

    public string Name { get; set; }
    public float Value { get; set; }
}


