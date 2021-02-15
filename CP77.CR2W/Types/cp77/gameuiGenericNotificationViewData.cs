using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiGenericNotificationViewData : IScriptable
	{
		[Ordinal(0)] [RED("title")] public CString Title { get; set; }
		[Ordinal(1)] [RED("text")] public CString Text { get; set; }
		[Ordinal(2)] [RED("soundEvent")] public CName SoundEvent { get; set; }
		[Ordinal(3)] [RED("soundAction")] public CName SoundAction { get; set; }
		[Ordinal(4)] [RED("action")] public CHandle<GenericNotificationBaseAction> Action { get; set; }

		public gameuiGenericNotificationViewData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
