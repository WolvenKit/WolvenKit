using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVehicleTemperatureSettings : CVariable
	{
		[Ordinal(0)] [RED("rpmThreshold")] public CFloat RpmThreshold { get; set; }
		[Ordinal(1)] [RED("timeToActivateTemperature")] public CFloat TimeToActivateTemperature { get; set; }
		[Ordinal(2)] [RED("cooldownTime")] public CFloat CooldownTime { get; set; }

		public audioVehicleTemperatureSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
