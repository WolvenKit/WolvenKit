using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiTarotCardAddedNotificationViewData : gameuiGenericNotificationViewData
	{
		[Ordinal(5)] [RED("imagePart")] public CName ImagePart { get; set; }
		[Ordinal(6)] [RED("cardName")] public CString CardName { get; set; }
		[Ordinal(7)] [RED("animation")] public CName Animation { get; set; }

		public gameuiTarotCardAddedNotificationViewData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
