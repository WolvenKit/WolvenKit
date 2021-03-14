using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkWidgetBrushResource : CResource
	{
		[Ordinal(1)] [RED("brush")] public CHandle<inkWidgetBrush> Brush { get; set; }

		public inkWidgetBrushResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
