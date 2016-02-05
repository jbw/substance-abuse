using UnityEngine;
using System.Linq;
using System.Collections.Generic;
using System;
using System.Linq.Expressions;

public class GrassSubstanceParameters : SubstanceParameters
{

    [InputParameter("Grass_Amount")]
    public float GrassAmount;

    [InputParameter("GrassLength")]
    public float GrassLength;

    void Start()
    {

    }

}
