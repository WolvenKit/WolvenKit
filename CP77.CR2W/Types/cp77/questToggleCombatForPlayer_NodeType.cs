using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questToggleCombatForPlayer_NodeType : questIVehicleManagerNodeType
	{
		[Ordinal(0)]  [RED("startCombat")] public CBool StartCombat { get; set; }

		public questToggleCombatForPlayer_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
