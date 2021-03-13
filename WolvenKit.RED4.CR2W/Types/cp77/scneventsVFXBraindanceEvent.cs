using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scneventsVFXBraindanceEvent : scnSceneEvent
	{
		[Ordinal(6)] [RED("performerId")] public scnPerformerId PerformerId { get; set; }
		[Ordinal(7)] [RED("nodeRef")] public NodeRef NodeRef { get; set; }
		[Ordinal(8)] [RED("effectEntry")] public scnEffectEntry EffectEntry { get; set; }
		[Ordinal(9)] [RED("sequenceShift")] public CUInt32 SequenceShift { get; set; }
		[Ordinal(10)] [RED("glitchEffectEntry")] public scnEffectEntry GlitchEffectEntry { get; set; }
		[Ordinal(11)] [RED("glitchSequenceShift")] public CUInt32 GlitchSequenceShift { get; set; }
		[Ordinal(12)] [RED("fullyRewindable")] public CBool FullyRewindable { get; set; }

		public scneventsVFXBraindanceEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
