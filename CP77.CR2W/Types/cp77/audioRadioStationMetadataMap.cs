using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioRadioStationMetadataMap : audioAudioMetadata
	{
		[Ordinal(1)] [RED("radioStations")] public CArray<CName> RadioStations { get; set; }
		[Ordinal(2)] [RED("switchStationEvent")] public CName SwitchStationEvent { get; set; }
		[Ordinal(3)] [RED("turnOnRadioEvent")] public CName TurnOnRadioEvent { get; set; }
		[Ordinal(4)] [RED("turnOffRadioEvent")] public CName TurnOffRadioEvent { get; set; }
		[Ordinal(5)] [RED("defaultBackgroundJingle")] public audioRadioStationJingleMetadata DefaultBackgroundJingle { get; set; }

		public audioRadioStationMetadataMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
