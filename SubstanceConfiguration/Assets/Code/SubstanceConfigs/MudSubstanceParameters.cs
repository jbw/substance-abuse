using UnityEngine;
using System.Linq;
using System.Collections.Generic;
using System;
using System.Linq.Expressions;

public class MudSubstanceParameters : SubstanceParameters
{

    [Description("GrassAmount")]
    public float GrassAmount;

    [Description("WaterControl_Cracks")]
    public float WaterControl;

    [Description("WaterAmount")]
    public float WaterAmount;

    void Start()
    {

    }

}
