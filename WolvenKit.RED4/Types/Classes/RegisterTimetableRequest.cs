using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RegisterTimetableRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("requesterData")] 
		public PSOwnerData RequesterData
		{
			get => GetPropertyValue<PSOwnerData>();
			set => SetPropertyValue<PSOwnerData>(value);
		}

		[Ordinal(1)] 
		[RED("timeTable")] 
		public CArray<SDeviceTimetableEntry> TimeTable
		{
			get => GetPropertyValue<CArray<SDeviceTimetableEntry>>();
			set => SetPropertyValue<CArray<SDeviceTimetableEntry>>(value);
		}

		[Ordinal(2)] 
		[RED("lights")] 
		public CInt32 Lights
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public RegisterTimetableRequest()
		{
			RequesterData = new() { Id = new() };
			TimeTable = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
