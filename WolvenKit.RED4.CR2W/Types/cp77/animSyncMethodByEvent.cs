using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animSyncMethodByEvent : animISyncMethod
	{
		[Ordinal(0)] [RED("eventName")] public CName EventName { get; set; }

		public animSyncMethodByEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
