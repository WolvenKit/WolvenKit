using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioVehiclePartSettingsMap : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("minAcousticsIsolationFactorValue")] public CFloat MinAcousticsIsolationFactorValue { get; set; }
		[Ordinal(1)]  [RED("partSettings")] public CArray<audioVehiclePartSettingsMapItem> PartSettings { get; set; }

		public audioVehiclePartSettingsMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
