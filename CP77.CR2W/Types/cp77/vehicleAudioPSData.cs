using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class vehicleAudioPSData : CVariable
	{
		[Ordinal(0)]  [RED("acousticIsolationFactor")] public CFloat AcousticIsolationFactor { get; set; }
		[Ordinal(1)]  [RED("activeRadioStation")] public CName ActiveRadioStation { get; set; }
		[Ordinal(2)]  [RED("isPlayerVehicleSummoned")] public CBool IsPlayerVehicleSummoned { get; set; }

		public vehicleAudioPSData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
