using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkPhaseWithSpeedAnim : animAnimNode_SkPhaseAnim
	{
		[Ordinal(0)]  [RED("speedLink")] public animFloatLink SpeedLink { get; set; }

		public animAnimNode_SkPhaseWithSpeedAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
