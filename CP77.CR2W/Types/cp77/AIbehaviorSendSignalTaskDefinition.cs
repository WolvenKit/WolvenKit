using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorSendSignalTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(0)]  [RED("signalName")] public CName SignalName { get; set; }
		[Ordinal(1)]  [RED("startAction")] public CEnum<gameBoolSignalAction> StartAction { get; set; }
		[Ordinal(2)]  [RED("startActionUserData")] public CHandle<gameSignalUserDataDefinition> StartActionUserData { get; set; }
		[Ordinal(3)]  [RED("endAction")] public CEnum<gameBoolSignalAction> EndAction { get; set; }
		[Ordinal(4)]  [RED("endActionUserData")] public CHandle<gameSignalUserDataDefinition> EndActionUserData { get; set; }

		public AIbehaviorSendSignalTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
