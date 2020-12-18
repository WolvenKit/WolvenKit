using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
    [REDMeta]
    public class CMesh : CVariable
    {
        [Ordinal(0)] [RED("cookingPlatform")] public CEnum<ECookingPlatform> CookingPlatform { get; set; }
        [Ordinal(1)] [RED("resourceVersion")] public CUInt8 ResourceVersion { get; set; }
        [Ordinal(2)] [RED("boundingBox")] public Box BoundingBox { get; set; }
        [Ordinal(3)] [RED("surfaceAreaPerAxis")] public Vector3 SurfaceAreaPerAxis { get; set; }
        [Ordinal(4)] [RED("materialEntries")] public CArray<CMeshMaterialEntry> MaterialEntries { get; set; }
        [Ordinal(5)] [RED("preloadLocalMaterialInstances")] public CArray<CHandle<IMaterial>> PreloadLocalMaterialInstances { get; set; }
        [Ordinal(6)] [RED("appearances")] public CArray<CHandle<meshMeshAppearance>> Appearances { get; set; }
        [Ordinal(7)] [RED("renderResourceBlob")] public CHandle<IRenderResourceBlob> RenderResourceBlob { get; set; }
        [Ordinal(8)] [RED("lodLevelInfo")] public CArray<CFloat> LodLevelInfo { get; set; }
        [Ordinal(9)] [RED("castGlobalShadowsCachedInCook")] public CBool CastGlobalShadowsCachedInCook { get; set; }
        [Ordinal(10)] [RED("castLocalShadowsCachedInCook")] public CBool CastLocalShadowsCachedInCook { get; set; }
        public CMesh(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }


	[REDMeta]
    public class meshMeshParameter : CVariable
    {

        public meshMeshParameter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }

        
    }



}