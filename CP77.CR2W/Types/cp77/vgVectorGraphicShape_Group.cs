using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class vgVectorGraphicShape_Group : vgBaseVectorGraphicShape
	{
		[Ordinal(0)]  [RED("childShapes")] public CArray<CHandle<vgBaseVectorGraphicShape>> ChildShapes { get; set; }

		public vgVectorGraphicShape_Group(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
