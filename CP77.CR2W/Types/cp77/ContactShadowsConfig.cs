using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ContactShadowsConfig : CVariable
	{
		[Ordinal(0)]  [RED("distanceFadeLimit")] public CFloat DistanceFadeLimit { get; set; }
		[Ordinal(1)]  [RED("distanceFadeRange")] public CFloat DistanceFadeRange { get; set; }
		[Ordinal(2)]  [RED("range")] public CFloat Range { get; set; }
		[Ordinal(3)]  [RED("rangeLimit")] public CFloat RangeLimit { get; set; }
		[Ordinal(4)]  [RED("screenEdgeFadeRange")] public CFloat ScreenEdgeFadeRange { get; set; }

		public ContactShadowsConfig(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
