using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemWeaponPlaneBlur : effectTrackItem
	{
		[Ordinal(0)]  [RED("farPlaneMultiplier")] public effectEffectParameterEvaluatorFloat FarPlaneMultiplier { get; set; }
		[Ordinal(1)]  [RED("override")] public CBool Override { get; set; }

		public effectTrackItemWeaponPlaneBlur(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
