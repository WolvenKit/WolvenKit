using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioVehicleTemperatureSettings : CVariable
	{
		[Ordinal(0)]  [RED("cooldownTime")] public CFloat CooldownTime { get; set; }
		[Ordinal(1)]  [RED("rpmThreshold")] public CFloat RpmThreshold { get; set; }
		[Ordinal(2)]  [RED("timeToActivateTemperature")] public CFloat TimeToActivateTemperature { get; set; }

		public audioVehicleTemperatureSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
