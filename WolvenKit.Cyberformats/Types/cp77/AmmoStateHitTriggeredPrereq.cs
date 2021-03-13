using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AmmoStateHitTriggeredPrereq : HitTriggeredPrereq
	{
		[Ordinal(5)] [RED("valueToListen")] public CEnum<EMagazineAmmoState> ValueToListen { get; set; }

		public AmmoStateHitTriggeredPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
