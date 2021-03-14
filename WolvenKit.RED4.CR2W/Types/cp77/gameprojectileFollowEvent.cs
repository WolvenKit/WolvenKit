using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameprojectileFollowEvent : redEvent
	{
		[Ordinal(0)] [RED("followObject")] public wCHandle<gameObject> FollowObject { get; set; }

		public gameprojectileFollowEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
