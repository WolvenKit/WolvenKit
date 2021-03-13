using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioWeaponHandlingSettings : CVariable
	{
		[Ordinal(0)] [RED("equipEvent")] public CName EquipEvent { get; set; }
		[Ordinal(1)] [RED("unequipStartedEvent")] public CName UnequipStartedEvent { get; set; }
		[Ordinal(2)] [RED("unequippedEvent")] public CName UnequippedEvent { get; set; }

		public audioWeaponHandlingSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
