using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questToggleCombatForPlayer_NodeType : questIVehicleManagerNodeType
	{
		[Ordinal(0)] [RED("startCombat")] public CBool StartCombat { get; set; }

		public questToggleCombatForPlayer_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
