using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class vgVectorGraphicShape_Circle : vgBaseVectorGraphicShape
	{
		[Ordinal(0)]  [RED("dius")] public CFloat Dius { get; set; }

		public vgVectorGraphicShape_Circle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
