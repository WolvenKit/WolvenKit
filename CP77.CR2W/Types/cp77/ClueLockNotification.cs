using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ClueLockNotification : HUDManagerRequest
	{
		[Ordinal(0)]  [RED("isLocked")] public CBool IsLocked { get; set; }

		public ClueLockNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
