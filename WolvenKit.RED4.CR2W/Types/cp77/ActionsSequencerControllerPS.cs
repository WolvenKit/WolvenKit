using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActionsSequencerControllerPS : MasterControllerPS
	{
		[Ordinal(104)] [RED("sequenceDuration")] public CFloat SequenceDuration { get; set; }
		[Ordinal(105)] [RED("sequencerMode")] public CEnum<EActionsSequencerMode> SequencerMode { get; set; }
		[Ordinal(106)] [RED("actionTypeToForward")] public SActionTypeForward ActionTypeToForward { get; set; }
		[Ordinal(107)] [RED("ongoingSequence")] public ActionsSequence OngoingSequence { get; set; }

		public ActionsSequencerControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
