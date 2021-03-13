using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_WeaponScopeData : animAnimFeature
	{
		[Ordinal(0)] [RED("ironsightAngleWithScope")] public CFloat IronsightAngleWithScope { get; set; }
		[Ordinal(1)] [RED("hasScope")] public CBool HasScope { get; set; }

		public AnimFeature_WeaponScopeData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
