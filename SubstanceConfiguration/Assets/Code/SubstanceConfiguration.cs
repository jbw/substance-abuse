using System.Linq;
using UnityEngine;

public class SubstanceConfiguration : MonoBehaviour
{
    private Renderer _renderer;
    public SubstanceParameters parameters;

    void Start()
    {
        _renderer = this.GetComponent<Renderer>();
        Config();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Config()
    {
        ProceduralMaterial substance = _renderer.material as ProceduralMaterial;
        ProceduralMaterial.substanceProcessorUsage = ProceduralProcessorUsage.All;

        if (substance)
        {
            substance.cacheSize = ProceduralCacheSize.NoLimit;

            //Find out the real names of the properties to create configs.
            //var substanceParamterNames = substance
            //    .GetProceduralPropertyDescriptions()
            //    .Select(x => x.name)
            //    .ToList();
          
            var properties = parameters.GetProperties();

            foreach (var property in properties)
            {
                substance.SetProceduralFloat(property.Name, property.Value);
            }

            substance.RebuildTextures();
        }
    }
}
