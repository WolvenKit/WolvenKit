using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkGridWidget : inkCompoundWidget
	{
		[Ordinal(23)] [RED("orientation")] public CEnum<inkEOrientation> Orientation { get; set; }
		[Ordinal(24)] [RED("childPadding")] public inkMargin ChildPadding { get; set; }
		[Ordinal(25)] [RED("childSizeStep")] public Vector2 ChildSizeStep { get; set; }

		public inkGridWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
