using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DistantProxiesSettings : IAreaSettings
	{
		[Ordinal(2)] [RED("distantProxiesEmissive")] public CFloat DistantProxiesEmissive { get; set; }
		[Ordinal(3)] [RED("distantProxiesEmissiveHeight")] public CFloat DistantProxiesEmissiveHeight { get; set; }
		[Ordinal(4)] [RED("distantProxiesEmissivePower")] public CFloat DistantProxiesEmissivePower { get; set; }
		[Ordinal(5)] [RED("distantProxiesBboxzBlend")] public CFloat DistantProxiesBboxzBlend { get; set; }

		public DistantProxiesSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
