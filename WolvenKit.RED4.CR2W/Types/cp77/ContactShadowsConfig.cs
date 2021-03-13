using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ContactShadowsConfig : CVariable
	{
		[Ordinal(0)] [RED("range")] public CFloat Range { get; set; }
		[Ordinal(1)] [RED("rangeLimit")] public CFloat RangeLimit { get; set; }
		[Ordinal(2)] [RED("screenEdgeFadeRange")] public CFloat ScreenEdgeFadeRange { get; set; }
		[Ordinal(3)] [RED("distanceFadeLimit")] public CFloat DistanceFadeLimit { get; set; }
		[Ordinal(4)] [RED("distanceFadeRange")] public CFloat DistanceFadeRange { get; set; }

		public ContactShadowsConfig(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
