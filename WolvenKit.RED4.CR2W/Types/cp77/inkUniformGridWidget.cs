using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkUniformGridWidget : inkCompoundWidget
	{
		[Ordinal(23)] [RED("wrappingWidgetCount")] public CUInt32 WrappingWidgetCount { get; set; }
		[Ordinal(24)] [RED("orientation")] public CEnum<inkEOrientation> Orientation { get; set; }

		public inkUniformGridWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
