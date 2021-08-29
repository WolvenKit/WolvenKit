using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RegisterTimetableRequest : gameScriptableSystemRequest
	{
		private PSOwnerData _requesterData;
		private CArray<SDeviceTimetableEntry> _timeTable;
		private CInt32 _lights;

		[Ordinal(0)] 
		[RED("requesterData")] 
		public PSOwnerData RequesterData
		{
			get => GetProperty(ref _requesterData);
			set => SetProperty(ref _requesterData, value);
		}

		[Ordinal(1)] 
		[RED("timeTable")] 
		public CArray<SDeviceTimetableEntry> TimeTable
		{
			get => GetProperty(ref _timeTable);
			set => SetProperty(ref _timeTable, value);
		}

		[Ordinal(2)] 
		[RED("lights")] 
		public CInt32 Lights
		{
			get => GetProperty(ref _lights);
			set => SetProperty(ref _lights, value);
		}
	}
}
