using System.Linq;
using UnityEngine;

namespace Assets.Code.SubstanceConfiguation
{
    public class SubstanceSettings
    {
        public SubstanceSettings()
        {
            CacheSize = ProceduralCacheSize.NoLimit;
            ProcessorUsage = ProceduralProcessorUsage.All;
        }

        public ProceduralCacheSize CacheSize { get; set; }
        public ProceduralProcessorUsage ProcessorUsage { get; set; }
    }

}
