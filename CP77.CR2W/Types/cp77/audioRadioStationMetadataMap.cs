using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioRadioStationMetadataMap : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("defaultBackgroundJingle")] public audioRadioStationJingleMetadata DefaultBackgroundJingle { get; set; }
		[Ordinal(1)]  [RED("radioStations")] public CArray<CName> RadioStations { get; set; }
		[Ordinal(2)]  [RED("switchStationEvent")] public CName SwitchStationEvent { get; set; }
		[Ordinal(3)]  [RED("turnOffRadioEvent")] public CName TurnOffRadioEvent { get; set; }
		[Ordinal(4)]  [RED("turnOnRadioEvent")] public CName TurnOnRadioEvent { get; set; }

		public audioRadioStationMetadataMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
