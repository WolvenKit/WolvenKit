using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vgVectorGraphicShape_Circle : vgBaseVectorGraphicShape
	{
		[Ordinal(2)] [RED("dius")] public CFloat Dius { get; set; }

		public vgVectorGraphicShape_Circle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
