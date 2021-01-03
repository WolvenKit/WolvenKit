using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ZoomLevelAimEvents : ZoomEventsTransition
	{
		[Ordinal(0)]  [RED("isAmingWithWeapon")] public CBool IsAmingWithWeapon { get; set; }

		public ZoomLevelAimEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
