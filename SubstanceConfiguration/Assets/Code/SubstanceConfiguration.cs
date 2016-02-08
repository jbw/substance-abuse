using Assets.Code.SubstanceConfiguation;
using UnityEngine;

public class SubstanceConfiguration : MonoBehaviour
{
    private Renderer _renderer;
    private SubstanceSettings _settings;

    public SubstanceParameters parameters;

    void Start()
    {
        _renderer = this.GetComponent<Renderer>();
        Config();
    }

    void Update()
    {
    }

    public SubstanceConfiguration()
    {
        _settings = new SubstanceSettings();
    }

    public void Config(SubstanceSettings settings = null)
    {
        if (parameters == null) return;
        if (settings != null) _settings = settings;

        ProceduralMaterial substance = _renderer.material as ProceduralMaterial;
        ProceduralMaterial.substanceProcessorUsage = _settings.ProcessorUsage;

        if (substance)
        {
            substance.cacheSize = _settings.CacheSize;

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