using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scneventsVFXEvent : scnSceneEvent
	{
		[Ordinal(6)] [RED("effectEntry")] public scnEffectEntry EffectEntry { get; set; }
		[Ordinal(7)] [RED("action")] public CEnum<scneventsVFXActionType> Action { get; set; }
		[Ordinal(8)] [RED("sequenceShift")] public CUInt32 SequenceShift { get; set; }
		[Ordinal(9)] [RED("performerId")] public scnPerformerId PerformerId { get; set; }
		[Ordinal(10)] [RED("nodeRef")] public NodeRef NodeRef { get; set; }
		[Ordinal(11)] [RED("muteSound")] public CBool MuteSound { get; set; }

		public scneventsVFXEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
