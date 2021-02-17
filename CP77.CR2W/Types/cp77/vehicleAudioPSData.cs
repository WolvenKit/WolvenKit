using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class vehicleAudioPSData : CVariable
	{
		[Ordinal(0)] [RED("activeRadioStation")] public CName ActiveRadioStation { get; set; }
		[Ordinal(1)] [RED("acousticIsolationFactor")] public CFloat AcousticIsolationFactor { get; set; }
		[Ordinal(2)] [RED("isPlayerVehicleSummoned")] public CBool IsPlayerVehicleSummoned { get; set; }

		public vehicleAudioPSData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
