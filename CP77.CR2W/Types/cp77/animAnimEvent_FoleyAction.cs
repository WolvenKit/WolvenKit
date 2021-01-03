using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimEvent_FoleyAction : animAnimEvent
	{
		[Ordinal(0)]  [RED("actionName")] public CName ActionName { get; set; }

		public animAnimEvent_FoleyAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
