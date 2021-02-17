using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioWeaponFireModeSounds : CVariable
	{
		[Ordinal(0)] [RED("burst")] public CName Burst { get; set; }
		[Ordinal(1)] [RED("charge")] public CName Charge { get; set; }
		[Ordinal(2)] [RED("fullAuto")] public CName FullAuto { get; set; }
		[Ordinal(3)] [RED("semiAuto")] public CName SemiAuto { get; set; }
		[Ordinal(4)] [RED("windup")] public CName Windup { get; set; }

		public audioWeaponFireModeSounds(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
