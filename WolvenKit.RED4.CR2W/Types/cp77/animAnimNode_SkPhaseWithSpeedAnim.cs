using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkPhaseWithSpeedAnim : animAnimNode_SkPhaseAnim
	{
		[Ordinal(31)] [RED("speedLink")] public animFloatLink SpeedLink { get; set; }

		public animAnimNode_SkPhaseWithSpeedAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
