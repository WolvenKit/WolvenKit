using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SmartHouseControllerPS : MasterControllerPS
	{
		private CArray<SPresetTimetableEntry> _timetable;
		private CHandle<SmartHousePreset> _activePreset;
		private CArray<CHandle<SmartHousePreset>> _availablePresets;
		private SmartHouseConfiguration _smartHouseCustomization;
		private CUInt32 _callbackID;

		[Ordinal(105)] 
		[RED("timetable")] 
		public CArray<SPresetTimetableEntry> Timetable
		{
			get => GetProperty(ref _timetable);
			set => SetProperty(ref _timetable, value);
		}

		[Ordinal(106)] 
		[RED("activePreset")] 
		public CHandle<SmartHousePreset> ActivePreset
		{
			get => GetProperty(ref _activePreset);
			set => SetProperty(ref _activePreset, value);
		}

		[Ordinal(107)] 
		[RED("availablePresets")] 
		public CArray<CHandle<SmartHousePreset>> AvailablePresets
		{
			get => GetProperty(ref _availablePresets);
			set => SetProperty(ref _availablePresets, value);
		}

		[Ordinal(108)] 
		[RED("smartHouseCustomization")] 
		public SmartHouseConfiguration SmartHouseCustomization
		{
			get => GetProperty(ref _smartHouseCustomization);
			set => SetProperty(ref _smartHouseCustomization, value);
		}

		[Ordinal(109)] 
		[RED("callbackID")] 
		public CUInt32 CallbackID
		{
			get => GetProperty(ref _callbackID);
			set => SetProperty(ref _callbackID, value);
		}
	}
}
