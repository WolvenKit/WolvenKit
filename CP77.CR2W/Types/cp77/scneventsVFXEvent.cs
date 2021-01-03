using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scneventsVFXEvent : scnSceneEvent
	{
		[Ordinal(0)]  [RED("action")] public CEnum<scneventsVFXActionType> Action { get; set; }
		[Ordinal(1)]  [RED("effectEntry")] public scnEffectEntry EffectEntry { get; set; }
		[Ordinal(2)]  [RED("muteSound")] public CBool MuteSound { get; set; }
		[Ordinal(3)]  [RED("nodeRef")] public NodeRef NodeRef { get; set; }
		[Ordinal(4)]  [RED("performerId")] public scnPerformerId PerformerId { get; set; }
		[Ordinal(5)]  [RED("sequenceShift")] public CUInt32 SequenceShift { get; set; }

		public scneventsVFXEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
