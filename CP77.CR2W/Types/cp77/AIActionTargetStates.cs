using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIActionTargetStates : CVariable
	{
		[Ordinal(0)]  [RED("npcStates")] public AIActionNPCStates NpcStates { get; set; }
		[Ordinal(1)]  [RED("playerStates")] public AIActionPlayerStates PlayerStates { get; set; }

		public AIActionTargetStates(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
