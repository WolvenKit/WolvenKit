using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_WeaponScopeData : animAnimFeature
	{
		[Ordinal(0)]  [RED("hasScope")] public CBool HasScope { get; set; }
		[Ordinal(1)]  [RED("ironsightAngleWithScope")] public CFloat IronsightAngleWithScope { get; set; }

		public AnimFeature_WeaponScopeData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
