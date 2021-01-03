using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkPhaseWithDurationAnim : animAnimNode_SkPhaseAnim
	{
		[Ordinal(0)]  [RED("durationLink")] public animFloatLink DurationLink { get; set; }

		public animAnimNode_SkPhaseWithDurationAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
