using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vgVectorGraphicDefinition : ISerializable
	{
		[Ordinal(0)] [RED("rootShapeGroup")] public CHandle<vgVectorGraphicShape_Group> RootShapeGroup { get; set; }
		[Ordinal(1)] [RED("dimensions")] public Vector2 Dimensions { get; set; }

		public vgVectorGraphicDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
