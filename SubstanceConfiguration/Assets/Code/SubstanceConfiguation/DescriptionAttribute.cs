using UnityEngine;
using System.Linq;
using System.Collections.Generic;
using System;

public class InputParameterAttribute : Attribute
{
    private string desc;

    public InputParameterAttribute(string v)
    {
        this.desc = v;

    }

    public override string ToString()
    {
        return desc;
    }
}

