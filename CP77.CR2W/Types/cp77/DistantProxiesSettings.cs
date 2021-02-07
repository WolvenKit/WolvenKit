using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DistantProxiesSettings : IAreaSettings
	{
		[Ordinal(0)]  [RED("distantProxiesEmissive")] public CFloat DistantProxiesEmissive { get; set; }
		[Ordinal(1)]  [RED("distantProxiesEmissiveHeight")] public CFloat DistantProxiesEmissiveHeight { get; set; }
		[Ordinal(2)]  [RED("distantProxiesEmissivePower")] public CFloat DistantProxiesEmissivePower { get; set; }
		[Ordinal(3)]  [RED("distantProxiesBboxzBlend")] public CFloat DistantProxiesBboxzBlend { get; set; }

		public DistantProxiesSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
