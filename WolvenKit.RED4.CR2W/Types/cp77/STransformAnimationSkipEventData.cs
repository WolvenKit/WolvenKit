using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class STransformAnimationSkipEventData : CVariable
	{
		[Ordinal(0)] [RED("time")] public CFloat Time { get; set; }
		[Ordinal(1)] [RED("skipToEnd")] public CBool SkipToEnd { get; set; }

		public STransformAnimationSkipEventData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
