using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class vgBaseVectorGraphicShape : ISerializable
	{
		[Ordinal(0)] [RED("calTransform")] public Matrix CalTransform { get; set; }
		[Ordinal(1)] [RED("yle")] public CHandle<vgVectorGraphicStyle> Yle { get; set; }

		public vgBaseVectorGraphicShape(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
