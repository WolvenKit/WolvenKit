using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkBrushWrapper : CVariable
	{
		[Ordinal(0)] [RED("brush")] public CHandle<inkWidgetBrush> Brush { get; set; }
		[Ordinal(1)] [RED("externalBrush")] public rRef<inkWidgetBrushResource> ExternalBrush { get; set; }

		public inkBrushWrapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
