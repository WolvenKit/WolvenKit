using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkGridWidget : inkCompoundWidget
	{
		[Ordinal(0)]  [RED("childPadding")] public inkMargin ChildPadding { get; set; }
		[Ordinal(1)]  [RED("childSizeStep")] public Vector2 ChildSizeStep { get; set; }
		[Ordinal(2)]  [RED("orientation")] public CEnum<inkEOrientation> Orientation { get; set; }

		public inkGridWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
