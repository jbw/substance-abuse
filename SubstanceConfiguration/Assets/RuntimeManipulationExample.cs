using UnityEngine;
using Assets.Code.SubstanceConfiguation;

public class RuntimeManipulationExample : MonoBehaviour {

	// Use this for initialization
	void Start () {

        var aCube = GameObject.FindGameObjectWithTag("Cube1");

        var grassParams = aCube.GetComponent<GrassSubstanceParameters>();
        grassParams.GrassAmount = 10;

        var config = aCube.GetComponent<SubstanceConfiguration>();
        config.parameters = grassParams;

        var low = new SubstanceSettings
        {
            CacheSize = ProceduralCacheSize.None,
            ProcessorUsage = ProceduralProcessorUsage.Half
        };

        var high = new SubstanceSettings
        {
            CacheSize = ProceduralCacheSize.NoLimit,
            ProcessorUsage = ProceduralProcessorUsage.All
        };

        config.Config(low);

    }

    // Update is called once per frame
    void Update () {
	
	}
}
