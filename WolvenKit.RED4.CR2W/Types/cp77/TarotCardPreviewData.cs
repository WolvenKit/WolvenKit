using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TarotCardPreviewData : inkGameNotificationData
	{
		[Ordinal(6)] [RED("cardData")] public TarotCardData CardData { get; set; }

		public TarotCardPreviewData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
