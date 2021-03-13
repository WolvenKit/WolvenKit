using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vgVectorGraphicShape_Polygon : vgBaseVectorGraphicShape
	{
		[Ordinal(2)] [RED("ints")] public CArray<Vector2> Ints { get; set; }

		public vgVectorGraphicShape_Polygon(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
