using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questVehicleAirtime_ConditionType : questIVehicleConditionType
	{
		private CFloat _seconds;

		[Ordinal(0)] 
		[RED("seconds")] 
		public CFloat Seconds
		{
			get => GetProperty(ref _seconds);
			set => SetProperty(ref _seconds, value);
		}

		public questVehicleAirtime_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
