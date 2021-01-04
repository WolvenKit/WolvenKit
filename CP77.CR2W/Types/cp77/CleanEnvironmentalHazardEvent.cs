using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CleanEnvironmentalHazardEvent : redEvent
	{
		[Ordinal(0)]  [RED("stimEvent")] public CHandle<senseStimuliEvent> StimEvent { get; set; }

		public CleanEnvironmentalHazardEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
