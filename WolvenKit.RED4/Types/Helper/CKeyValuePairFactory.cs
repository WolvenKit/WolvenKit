namespace WolvenKit.RED4.Types;

public static class CKeyValuePairFactory
{
    public static CKeyValuePair Create(CMaterialParameter param)
    {
        var parameterName = param.ParameterName.GetResolvedText() ?? "invalid";
        ;
        switch (param)
        {
            case CMaterialParameterColor col:
                return new CKeyValuePair(parameterName, col.Color);
            case CMaterialParameterCpuNameU64 paramCpuName:
                return new CKeyValuePair(parameterName, paramCpuName.Name);
            case CMaterialParameterCube cube:
                return new CKeyValuePair(parameterName, cube.Texture);
            case CMaterialParameterDynamicTexture tex:
                return new CKeyValuePair(parameterName, tex.Texture);
            case CMaterialParameterFoliageParameters fol:
                return new CKeyValuePair(parameterName, fol.FoliageProfile);
            case CMaterialParameterGradient grad:
                return new CKeyValuePair(parameterName, grad.Gradient);
            case CMaterialParameterHairParameters hp:
                return new CKeyValuePair(parameterName, hp.HairProfile);
            case CMaterialParameterMultilayerMask mlmask:
                return new CKeyValuePair(parameterName, mlmask.Mask);
            case CMaterialParameterMultilayerSetup mlsetup:
                return new CKeyValuePair(parameterName, mlsetup.Setup);
            case CMaterialParameterScalar scalar:
                return new CKeyValuePair(parameterName, scalar.Scalar);
            case CMaterialParameterSkinParameters sp:
                return new CKeyValuePair(parameterName, sp.SkinProfile);
            case CMaterialParameterTerrainSetup terrainSetup:
                return new CKeyValuePair(parameterName, terrainSetup.Setup);
            case CMaterialParameterStructBuffer buffer:
                return new CKeyValuePair(parameterName, buffer.Register);
            case CMaterialParameterTexture tex:
                return new CKeyValuePair(parameterName, tex.Texture);
            case CMaterialParameterTextureArray texArray:
                return new CKeyValuePair(parameterName, texArray.Texture);
            case CMaterialParameterVector vec:
                return new CKeyValuePair(parameterName, vec.Vector);
        }

        return new CKeyValuePair("invalid", new RedDummy());
    }
}
