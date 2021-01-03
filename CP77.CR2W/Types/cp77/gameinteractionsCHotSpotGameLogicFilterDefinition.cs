using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsCHotSpotGameLogicFilterDefinition : ISerializable
	{
		[Ordinal(0)]  [RED("activatorPrereq")] public CHandle<gameIPrereq> ActivatorPrereq { get; set; }
		[Ordinal(1)]  [RED("hotSpotPrereq")] public CHandle<gameIPrereq> HotSpotPrereq { get; set; }
		[Ordinal(2)]  [RED("scriptedConditionClass")] public CHandle<gameinteractionsInteractionScriptedCondition> ScriptedConditionClass { get; set; }

		public gameinteractionsCHotSpotGameLogicFilterDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
