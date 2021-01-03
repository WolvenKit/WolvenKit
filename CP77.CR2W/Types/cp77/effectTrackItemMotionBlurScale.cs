using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemMotionBlurScale : effectTrackItem
	{
		[Ordinal(0)]  [RED("scale")] public effectEffectParameterEvaluatorFloat Scale { get; set; }

		public effectTrackItemMotionBlurScale(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
