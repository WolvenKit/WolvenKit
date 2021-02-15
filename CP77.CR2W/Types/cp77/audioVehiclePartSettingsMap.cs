using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioVehiclePartSettingsMap : audioAudioMetadata
	{
		[Ordinal(1)] [RED("minAcousticsIsolationFactorValue")] public CFloat MinAcousticsIsolationFactorValue { get; set; }
		[Ordinal(2)] [RED("partSettings")] public CArray<audioVehiclePartSettingsMapItem> PartSettings { get; set; }

		public audioVehiclePartSettingsMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
