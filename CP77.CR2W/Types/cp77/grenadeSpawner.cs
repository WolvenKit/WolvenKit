using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class grenadeSpawner : gameweaponObject
	{
		[Ordinal(0)]  [RED("isCombatGadgetActive")] public CBool IsCombatGadgetActive { get; set; }

		public grenadeSpawner(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
