namespace WolvenKit.RED4.Types;

// ReSharper disable once InconsistentNaming
public partial class Multilayer_LayerTemplateOverridesLevels
{
    public override string ToString() => $"{N} => {(int)MathF.Round(V[0] * 100f)}, {(int)MathF.Round(V[1] * 100f)}";
}