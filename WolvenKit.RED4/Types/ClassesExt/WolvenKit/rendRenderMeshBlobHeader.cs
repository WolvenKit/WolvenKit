namespace WolvenKit.RED4.Types;

public partial class rendRenderMeshBlobHeader
{
    public override IEnumerable<string> GetHiddenFieldNames()
    {
        return base.GetHiddenFieldNames().Concat([
            "bonePositions", 
            "customData", 
            "customDataElemStride", 
            "dataProcessing", 
            "indexBufferOffset", 
            "indexBufferStride",
            "opacityMicromaps", 
            "quantizationOffset", 
            "quantizationScale", 
            "renderChunks"
        ]);
    }
}

