using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vgBaseVectorGraphicShape : ISerializable
	{
		[Ordinal(0)] [RED("calTransform")] public CMatrix CalTransform { get; set; }
		[Ordinal(1)] [RED("yle")] public CHandle<vgVectorGraphicStyle> Yle { get; set; }

		public vgBaseVectorGraphicShape(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
