using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ActionsSequencerControllerPS : MasterControllerPS
	{
		[Ordinal(0)]  [RED("actionTypeToForward")] public SActionTypeForward ActionTypeToForward { get; set; }
		[Ordinal(1)]  [RED("ongoingSequence")] public ActionsSequence OngoingSequence { get; set; }
		[Ordinal(2)]  [RED("sequenceDuration")] public CFloat SequenceDuration { get; set; }
		[Ordinal(3)]  [RED("sequencerMode")] public CEnum<EActionsSequencerMode> SequencerMode { get; set; }

		public ActionsSequencerControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
