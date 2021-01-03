using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scneventsVFXBraindanceEvent : scnSceneEvent
	{
		[Ordinal(0)]  [RED("effectEntry")] public scnEffectEntry EffectEntry { get; set; }
		[Ordinal(1)]  [RED("fullyRewindable")] public CBool FullyRewindable { get; set; }
		[Ordinal(2)]  [RED("glitchEffectEntry")] public scnEffectEntry GlitchEffectEntry { get; set; }
		[Ordinal(3)]  [RED("glitchSequenceShift")] public CUInt32 GlitchSequenceShift { get; set; }
		[Ordinal(4)]  [RED("nodeRef")] public NodeRef NodeRef { get; set; }
		[Ordinal(5)]  [RED("performerId")] public scnPerformerId PerformerId { get; set; }
		[Ordinal(6)]  [RED("sequenceShift")] public CUInt32 SequenceShift { get; set; }

		public scneventsVFXBraindanceEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
