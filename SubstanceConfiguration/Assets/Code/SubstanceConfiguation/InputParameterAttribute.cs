using UnityEngine;
using System.Linq;
using System.Collections.Generic;
using System;

public class InputParameterAttribute : Attribute
{
    private string parameterName;

    public InputParameterAttribute(string inputParameterName)
    {
        this.parameterName = inputParameterName;
    }

    public override string ToString()
    {
        return parameterName;
    }
}

