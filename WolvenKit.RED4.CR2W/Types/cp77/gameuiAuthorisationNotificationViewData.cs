using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiAuthorisationNotificationViewData : gameuiGenericNotificationViewData
	{
		[Ordinal(5)] [RED("authType")] public CEnum<gameuiAuthorisationNotificationType> AuthType { get; set; }

		public gameuiAuthorisationNotificationViewData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
