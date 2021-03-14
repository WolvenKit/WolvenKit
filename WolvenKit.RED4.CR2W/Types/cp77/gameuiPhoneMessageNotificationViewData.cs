using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPhoneMessageNotificationViewData : gameuiQuestUpdateNotificationViewData
	{
		[Ordinal(14)] [RED("threadHash")] public CInt32 ThreadHash { get; set; }
		[Ordinal(15)] [RED("contactHash")] public CInt32 ContactHash { get; set; }

		public gameuiPhoneMessageNotificationViewData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
