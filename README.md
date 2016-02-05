# Substance Configuration

Ability to easily model Substance parameters in the Inspector and
manipulate values at runtime without lots of manual configuration.

# Create config
```csharp 
public class GrassSubstanceParameters : SubstanceParameters
{
    [Description("Grass_Amount")]
    public float GrassAmount;

    [Description("GrassLength")]
    public float GrassLength;
}
csharp 

# Connect
