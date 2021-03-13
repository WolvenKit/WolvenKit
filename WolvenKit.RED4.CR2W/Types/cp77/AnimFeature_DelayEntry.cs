using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_DelayEntry : animAnimFeature
	{
		[Ordinal(0)] [RED("thresholdPassed")] public CBool ThresholdPassed { get; set; }

		public AnimFeature_DelayEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
