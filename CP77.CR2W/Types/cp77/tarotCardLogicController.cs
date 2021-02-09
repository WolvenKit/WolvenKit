using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class tarotCardLogicController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("image")] public inkImageWidgetReference Image { get; set; }
		[Ordinal(1)]  [RED("highlight")] public inkWidgetReference Highlight { get; set; }
		[Ordinal(2)]  [RED("data")] public TarotCardData Data { get; set; }

		public tarotCardLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
