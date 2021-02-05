using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiTarotCardAddedNotificationViewData : gameuiGenericNotificationViewData
	{
		[Ordinal(0)]  [RED("action")] public CHandle<GenericNotificationBaseAction> Action { get; set; }
		[Ordinal(1)]  [RED("imagePart")] public CName ImagePart { get; set; }
		[Ordinal(2)]  [RED("cardName")] public CString CardName { get; set; }
		[Ordinal(3)]  [RED("animation")] public CName Animation { get; set; }

		public gameuiTarotCardAddedNotificationViewData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
