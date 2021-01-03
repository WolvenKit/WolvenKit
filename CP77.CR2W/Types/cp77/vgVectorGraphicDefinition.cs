using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class vgVectorGraphicDefinition : ISerializable
	{
		[Ordinal(0)]  [RED("dimensions")] public Vector2 Dimensions { get; set; }
		[Ordinal(1)]  [RED("rootShapeGroup")] public CHandle<vgVectorGraphicShape_Group> RootShapeGroup { get; set; }

		public vgVectorGraphicDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
