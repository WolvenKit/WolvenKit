using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamesmartGunSmartGunLockEvent : redEvent
	{
		[Ordinal(0)] [RED("locked")] public CBool Locked { get; set; }
		[Ordinal(1)] [RED("lockedOnByPlayer")] public CBool LockedOnByPlayer { get; set; }

		public gamesmartGunSmartGunLockEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
