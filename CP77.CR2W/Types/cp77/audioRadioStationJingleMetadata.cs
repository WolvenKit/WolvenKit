using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioRadioStationJingleMetadata : CVariable
	{
		[Ordinal(0)] [RED("introJingleEvent")] public CName IntroJingleEvent { get; set; }
		[Ordinal(1)] [RED("introDuration")] public CFloat IntroDuration { get; set; }
		[Ordinal(2)] [RED("middleJingleEvent")] public CName MiddleJingleEvent { get; set; }
		[Ordinal(3)] [RED("endJingleEvent")] public CName EndJingleEvent { get; set; }
		[Ordinal(4)] [RED("outroDuration")] public CFloat OutroDuration { get; set; }

		public audioRadioStationJingleMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
