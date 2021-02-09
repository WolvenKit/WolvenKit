using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ActionsSequence : CVariable
	{
		[Ordinal(0)]  [RED("sequenceInitiator")] public entEntityID SequenceInitiator { get; set; }
		[Ordinal(1)]  [RED("maxActionsInSequence")] public CInt32 MaxActionsInSequence { get; set; }
		[Ordinal(2)]  [RED("actionsTriggeredCount")] public CInt32 ActionsTriggeredCount { get; set; }
		[Ordinal(3)]  [RED("delayIDs")] public CArray<gameDelayID> DelayIDs { get; set; }

		public ActionsSequence(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
