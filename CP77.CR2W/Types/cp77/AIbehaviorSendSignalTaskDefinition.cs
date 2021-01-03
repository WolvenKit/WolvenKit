using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorSendSignalTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(0)]  [RED("endAction")] public CEnum<gameBoolSignalAction> EndAction { get; set; }
		[Ordinal(1)]  [RED("endActionUserData")] public CHandle<gameSignalUserDataDefinition> EndActionUserData { get; set; }
		[Ordinal(2)]  [RED("signalName")] public CName SignalName { get; set; }
		[Ordinal(3)]  [RED("startAction")] public CEnum<gameBoolSignalAction> StartAction { get; set; }
		[Ordinal(4)]  [RED("startActionUserData")] public CHandle<gameSignalUserDataDefinition> StartActionUserData { get; set; }

		public AIbehaviorSendSignalTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
