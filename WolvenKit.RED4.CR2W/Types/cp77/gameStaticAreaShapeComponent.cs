using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameStaticAreaShapeComponent : entIPlacedComponent
	{
		[Ordinal(5)] [RED("outline")] public CHandle<AreaShapeOutline> Outline { get; set; }
		[Ordinal(6)] [RED("color")] public CColor Color { get; set; }
		[Ordinal(7)] [RED("isEnabled")] public CBool IsEnabled { get; set; }

		public gameStaticAreaShapeComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
