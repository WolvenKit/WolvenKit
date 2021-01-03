using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class workTimeOfDayCondition : workIWorkspotCondition
	{
		[Ordinal(0)]  [RED("activeAfter")] public GameTime ActiveAfter { get; set; }
		[Ordinal(1)]  [RED("activeUntil")] public GameTime ActiveUntil { get; set; }

		public workTimeOfDayCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
