using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemMotionBlurScale : effectTrackItem
	{
		[Ordinal(3)] [RED("scale")] public effectEffectParameterEvaluatorFloat Scale { get; set; }

		public effectTrackItemMotionBlurScale(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
