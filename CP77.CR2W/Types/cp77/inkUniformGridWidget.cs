using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkUniformGridWidget : inkCompoundWidget
	{
		[Ordinal(0)]  [RED("orientation")] public CEnum<inkEOrientation> Orientation { get; set; }
		[Ordinal(1)]  [RED("wrappingWidgetCount")] public CUInt32 WrappingWidgetCount { get; set; }

		public inkUniformGridWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
