using UnityEngine;
using System.Linq;
using System.Collections.Generic;
using System;
using System.Linq.Expressions;

public class MudSubstanceParameters : SubstanceParameters
{

    [InputParameter("GrassAmount")]
    public float GrassAmount;

    [InputParameter("WaterControl_Cracks")]
    public float WaterControl;

    [InputParameter("WaterAmount")]
    public float WaterAmount;

    void Start()
    {

    }

}
