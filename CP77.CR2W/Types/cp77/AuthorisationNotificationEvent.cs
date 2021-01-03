using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AuthorisationNotificationEvent : redEvent
	{
		[Ordinal(0)]  [RED("type")] public CEnum<gameuiAuthorisationNotificationType> Type { get; set; }

		public AuthorisationNotificationEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
