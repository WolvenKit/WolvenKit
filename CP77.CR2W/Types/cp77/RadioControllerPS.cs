using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class RadioControllerPS : MediaDeviceControllerPS
	{
		[Ordinal(0)]  [RED("radioSetup")] public RadioSetup RadioSetup { get; set; }
		[Ordinal(1)]  [RED("stations")] public CArray<RadioStationsMap> Stations { get; set; }
		[Ordinal(2)]  [RED("stationsInitialized")] public CBool StationsInitialized { get; set; }

		public RadioControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
