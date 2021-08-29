using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FuseData : RedBaseClass
	{
		private PSOwnerData _psOwnerData;
		private CArray<SDeviceTimetableEntry> _timeTable;
		private CInt32 _lights;

		[Ordinal(0)] 
		[RED("psOwnerData")] 
		public PSOwnerData PsOwnerData
		{
			get => GetProperty(ref _psOwnerData);
			set => SetProperty(ref _psOwnerData, value);
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
