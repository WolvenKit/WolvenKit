using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ClueLockNotification : HUDManagerRequest
	{
		[Ordinal(1)] [RED("isLocked")] public CBool IsLocked { get; set; }

		public ClueLockNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
