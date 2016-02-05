using UnityEngine;
using System.Linq;
using System.Collections.Generic;
using System;

public class DescriptionAttribute : Attribute
{
    private string desc;

    public DescriptionAttribute(string v)
    {
        this.desc = v;

    }

    public override string ToString()
    {
        return desc;
    }
}

