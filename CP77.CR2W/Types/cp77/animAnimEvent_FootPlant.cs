using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimEvent_FootPlant : animAnimEvent
	{
		[Ordinal(0)]  [RED("customEvent")] public CName CustomEvent { get; set; }
		[Ordinal(1)]  [RED("side")] public CEnum<animEventSide> Side { get; set; }

		public animAnimEvent_FootPlant(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
