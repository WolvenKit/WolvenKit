using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldProxyMeshAdvancedBuildParams : CVariable
	{
		[Ordinal(0)] [RED("boundingBoxSyncParams")] public worldProxyBoundingBoxSyncParams BoundingBoxSyncParams { get; set; }
		[Ordinal(1)] [RED("surfaceFlattenParams")] public worldProxySurfaceFlattenParams SurfaceFlattenParams { get; set; }
		[Ordinal(2)] [RED("misc")] public worldProxyMiscAdvancedParams Misc { get; set; }
		[Ordinal(3)] [RED("rayBias")] public CFloat RayBias { get; set; }
		[Ordinal(4)] [RED("rayMaxDistance")] public CFloat RayMaxDistance { get; set; }

		public worldProxyMeshAdvancedBuildParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
