using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AISwitchToSecondaryWeaponCommand : AICommand
	{
		[Ordinal(4)] [RED("unEquip")] public CBool UnEquip { get; set; }

		public AISwitchToSecondaryWeaponCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
