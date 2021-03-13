using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ForceSafeEvents : UpperBodyEventsTransition
	{
		[Ordinal(6)] [RED("safeAnimFeature")] public CHandle<AnimFeature_SafeAction> SafeAnimFeature { get; set; }
		[Ordinal(7)] [RED("weaponObjectID")] public TweakDBID WeaponObjectID { get; set; }

		public ForceSafeEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
