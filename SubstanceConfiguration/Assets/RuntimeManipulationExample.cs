using UnityEngine;
using System.Collections;

public class RuntimeManipulationExample : MonoBehaviour {

	// Use this for initialization
	void Start () {

        var aCube = GameObject.FindGameObjectWithTag("Cube1");

        var grassParams = aCube.GetComponent<GrassSubstanceParameters>();
        grassParams.GrassAmount = 10;

        var config = aCube.GetComponent<SubstanceConfiguration>();
        config.parameters = grassParams;
        config.Config();
    }

    // Update is called once per frame
    void Update () {
	
	}
}
