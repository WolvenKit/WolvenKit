using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TarotCardPreviewData : inkGameNotificationData
	{
		[Ordinal(6)] [RED("cardData")] public TarotCardData CardData { get; set; }

		public TarotCardPreviewData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
