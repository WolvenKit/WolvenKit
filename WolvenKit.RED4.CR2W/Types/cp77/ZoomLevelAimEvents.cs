using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ZoomLevelAimEvents : ZoomEventsTransition
	{
		[Ordinal(0)] [RED("isAmingWithWeapon")] public CBool IsAmingWithWeapon { get; set; }

		public ZoomLevelAimEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
