using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WeaponJammedAction : StatusEffectActions
	{
		[Ordinal(0)] [RED("jammedWeaponDuration")] public CFloat JammedWeaponDuration { get; set; }
		[Ordinal(1)] [RED("jammedWeaponStartTimeStamp")] public CFloat JammedWeaponStartTimeStamp { get; set; }

		public WeaponJammedAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
