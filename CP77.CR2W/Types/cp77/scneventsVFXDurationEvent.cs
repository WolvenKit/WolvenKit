using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scneventsVFXDurationEvent : scnSceneEvent
	{
		[Ordinal(0)]  [RED("effectEntry")] public scnEffectEntry EffectEntry { get; set; }
		[Ordinal(1)]  [RED("startAction")] public CEnum<scneventsVFXActionType> StartAction { get; set; }
		[Ordinal(2)]  [RED("endAction")] public CEnum<scneventsVFXActionType> EndAction { get; set; }
		[Ordinal(3)]  [RED("sequenceShift")] public CUInt32 SequenceShift { get; set; }
		[Ordinal(4)]  [RED("performerId")] public scnPerformerId PerformerId { get; set; }
		[Ordinal(5)]  [RED("nodeRef")] public NodeRef NodeRef { get; set; }
		[Ordinal(6)]  [RED("muteSound")] public CBool MuteSound { get; set; }

		public scneventsVFXDurationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
