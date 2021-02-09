using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TarotPreviewGameController : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("background")] public inkWidgetReference Background { get; set; }
		[Ordinal(1)]  [RED("previewImage")] public inkImageWidgetReference PreviewImage { get; set; }
		[Ordinal(2)]  [RED("previewTitle")] public inkTextWidgetReference PreviewTitle { get; set; }
		[Ordinal(3)]  [RED("previewDescription")] public inkTextWidgetReference PreviewDescription { get; set; }
		[Ordinal(4)]  [RED("data")] public CHandle<TarotCardPreviewData> Data { get; set; }

		public TarotPreviewGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
