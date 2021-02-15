using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkCircleWidget : inkBaseShapeWidget
	{
		[Ordinal(20)] [RED("segmentsNumber")] public CUInt32 SegmentsNumber { get; set; }

		public inkCircleWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
