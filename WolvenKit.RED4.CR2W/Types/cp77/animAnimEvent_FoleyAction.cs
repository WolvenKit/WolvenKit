using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimEvent_FoleyAction : animAnimEvent
	{
		[Ordinal(3)] [RED("actionName")] public CName ActionName { get; set; }

		public animAnimEvent_FoleyAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
