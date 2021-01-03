using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkScrollAreaWidget : inkCompoundWidget
	{
		[Ordinal(0)]  [RED("constrainContentPosition")] public CBool ConstrainContentPosition { get; set; }
		[Ordinal(1)]  [RED("fitToContentDirection")] public CEnum<inkFitToContentDirection> FitToContentDirection { get; set; }
		[Ordinal(2)]  [RED("horizontalScrolling")] public CFloat HorizontalScrolling { get; set; }
		[Ordinal(3)]  [RED("useInternalMask")] public CBool UseInternalMask { get; set; }
		[Ordinal(4)]  [RED("verticalScrolling")] public CFloat VerticalScrolling { get; set; }

		public inkScrollAreaWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
