using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vgVectorGraphicShape_Text : vgBaseVectorGraphicShape
	{
		[Ordinal(2)] [RED("xt")] public CString Xt { get; set; }

		public vgVectorGraphicShape_Text(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
