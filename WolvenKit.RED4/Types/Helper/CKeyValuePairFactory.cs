namespace WolvenKit.RED4.Types;

public static class CKeyValuePairFactory
{
    public static CKeyValuePair Create(CMaterialParameter param)
    {
        var parameterName = param.ParameterName.GetResolvedText() ?? "invalid";
        return param switch
        {
            CMaterialParameterColor col => new CKeyValuePair(parameterName, col.Color),
            CMaterialParameterCpuNameU64 paramCpuName => new CKeyValuePair(parameterName, paramCpuName.Name),
            CMaterialParameterCube cube => new CKeyValuePair(parameterName, cube.Texture),
            CMaterialParameterDynamicTexture tex => new CKeyValuePair(parameterName, tex.Texture),
            CMaterialParameterFoliageParameters fol => new CKeyValuePair(parameterName, fol.FoliageProfile),
            CMaterialParameterGradient grad => new CKeyValuePair(parameterName, grad.Gradient),
            CMaterialParameterHairParameters hp => new CKeyValuePair(parameterName, hp.HairProfile),
            CMaterialParameterMultilayerMask mlmask => new CKeyValuePair(parameterName, mlmask.Mask),
            CMaterialParameterMultilayerSetup mlsetup => new CKeyValuePair(parameterName, mlsetup.Setup),
            CMaterialParameterScalar scalar => new CKeyValuePair(parameterName, scalar.Scalar),
            CMaterialParameterSkinParameters sp => new CKeyValuePair(parameterName, sp.SkinProfile),
            CMaterialParameterTerrainSetup terrainSetup => new CKeyValuePair(parameterName, terrainSetup.Setup),
            CMaterialParameterStructBuffer buffer => new CKeyValuePair(parameterName, buffer.Register),
            CMaterialParameterTexture tex => new CKeyValuePair(parameterName, tex.Texture),
            CMaterialParameterTextureArray texArray => new CKeyValuePair(parameterName, texArray.Texture),
            CMaterialParameterVector vec => new CKeyValuePair(parameterName, vec.Vector),
            _ => new CKeyValuePair("invalid", new RedDummy())
        };
    }
}
