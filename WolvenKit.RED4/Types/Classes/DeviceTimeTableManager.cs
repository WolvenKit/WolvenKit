using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DeviceTimeTableManager : IScriptable
	{
		[Ordinal(0)] 
		[RED("timeTable")] 
		public CArray<SDeviceTimetableEntry> TimeTable
		{
			get => GetPropertyValue<CArray<SDeviceTimetableEntry>>();
			set => SetPropertyValue<CArray<SDeviceTimetableEntry>>(value);
		}

		public DeviceTimeTableManager()
		{
			TimeTable = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
