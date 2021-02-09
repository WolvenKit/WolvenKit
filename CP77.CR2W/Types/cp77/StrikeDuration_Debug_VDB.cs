using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class StrikeDuration_Debug_VDB : StrikeDuration_Debug
	{
		[Ordinal(0)]  [RED("UPDATE_DELAY")] public CFloat UPDATE_DELAY { get; set; }
		[Ordinal(1)]  [RED("DISPLAY_DURATION")] public CFloat DISPLAY_DURATION { get; set; }
		[Ordinal(2)]  [RED("timeToNextUpdate")] public CFloat TimeToNextUpdate { get; set; }

		public StrikeDuration_Debug_VDB(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
