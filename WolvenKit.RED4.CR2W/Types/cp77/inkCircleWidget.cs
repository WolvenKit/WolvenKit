using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkCircleWidget : inkBaseShapeWidget
	{
		[Ordinal(20)] [RED("segmentsNumber")] public CUInt32 SegmentsNumber { get; set; }

		public inkCircleWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
