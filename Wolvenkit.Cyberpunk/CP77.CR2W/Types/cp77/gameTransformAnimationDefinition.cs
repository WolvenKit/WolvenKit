using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimationDefinition : CVariable
	{
		[Ordinal(0)]  [RED("autoStart")] public CBool AutoStart { get; set; }
		[Ordinal(1)]  [RED("autoStartDelay")] public CFloat AutoStartDelay { get; set; }
		[Ordinal(2)]  [RED("looping")] public CBool Looping { get; set; }
		[Ordinal(3)]  [RED("name")] public CName Name { get; set; }
		[Ordinal(4)]  [RED("reverse")] public CBool Reverse { get; set; }
		[Ordinal(5)]  [RED("timeScale")] public CFloat TimeScale { get; set; }
		[Ordinal(6)]  [RED("timeline")] public gameTransformAnimationTimeline Timeline { get; set; }
		[Ordinal(7)]  [RED("timesToPlay")] public CUInt32 TimesToPlay { get; set; }

		public gameTransformAnimationDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
