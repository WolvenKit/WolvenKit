using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FoliageShadowConfig : CVariable
	{
		[Ordinal(0)] [RED("foliageShadowCascadeGradient")] public CFloat FoliageShadowCascadeGradient { get; set; }
		[Ordinal(1)] [RED("foliageShadowCascadeFilterScale")] public CFloat FoliageShadowCascadeFilterScale { get; set; }
		[Ordinal(2)] [RED("foliageShadowCascadeGradientDistanceRange")] public CFloat FoliageShadowCascadeGradientDistanceRange { get; set; }

		public FoliageShadowConfig(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
