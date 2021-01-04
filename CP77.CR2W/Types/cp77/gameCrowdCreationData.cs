using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameCrowdCreationData : CVariable
	{
		[Ordinal(0)]  [RED("timePeriods", 4)] public CStatic<gameCrowdPhaseTimePeriod> TimePeriods { get; set; }

		public gameCrowdCreationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
