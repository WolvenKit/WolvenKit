using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ForceSafeEvents : UpperBodyEventsTransition
	{
		[Ordinal(6)] [RED("safeAnimFeature")] public CHandle<AnimFeature_SafeAction> SafeAnimFeature { get; set; }
		[Ordinal(7)] [RED("weaponObjectID")] public TweakDBID WeaponObjectID { get; set; }

		public ForceSafeEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
