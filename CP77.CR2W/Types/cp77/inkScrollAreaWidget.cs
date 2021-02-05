using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkScrollAreaWidget : inkCompoundWidget
	{
		[Ordinal(0)]  [RED("horizontalScrolling")] public CFloat HorizontalScrolling { get; set; }
		[Ordinal(1)]  [RED("verticalScrolling")] public CFloat VerticalScrolling { get; set; }
		[Ordinal(2)]  [RED("constrainContentPosition")] public CBool ConstrainContentPosition { get; set; }
		[Ordinal(3)]  [RED("fitToContentDirection")] public CEnum<inkFitToContentDirection> FitToContentDirection { get; set; }
		[Ordinal(4)]  [RED("useInternalMask")] public CBool UseInternalMask { get; set; }

		public inkScrollAreaWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
