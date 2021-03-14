using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SendEquipWeaponCommand : AIbehaviortaskScript
	{
		[Ordinal(0)] [RED("secondary")] public CBool Secondary { get; set; }

		public SendEquipWeaponCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
