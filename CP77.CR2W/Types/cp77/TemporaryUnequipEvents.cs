using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class TemporaryUnequipEvents : UpperBodyEventsTransition
	{
		[Ordinal(0)]  [RED("forceOpen")] public CBool ForceOpen { get; set; }

		public TemporaryUnequipEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
