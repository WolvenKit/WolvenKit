using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkUniformGridWidget : inkCompoundWidget
	{
		[Ordinal(0)]  [RED("wrappingWidgetCount")] public CUInt32 WrappingWidgetCount { get; set; }
		[Ordinal(1)]  [RED("orientation")] public CEnum<inkEOrientation> Orientation { get; set; }

		public inkUniformGridWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
