using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkBrushWrapper : CVariable
	{
		[Ordinal(0)] [RED("brush")] public CHandle<inkWidgetBrush> Brush { get; set; }
		[Ordinal(1)] [RED("externalBrush")] public rRef<inkWidgetBrushResource> ExternalBrush { get; set; }

		public inkBrushWrapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
