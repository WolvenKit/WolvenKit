using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkPhaseWithSpeedAnim : animAnimNode_SkPhaseAnim
	{
		[Ordinal(19)] [RED("speedLink")] public animFloatLink SpeedLink { get; set; }

		public animAnimNode_SkPhaseWithSpeedAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
