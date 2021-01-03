using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkCircleWidget : inkBaseShapeWidget
	{
		[Ordinal(0)]  [RED("segmentsNumber")] public CUInt32 SegmentsNumber { get; set; }

		public inkCircleWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
