using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SmartHouseControllerPS : MasterControllerPS
	{
		[Ordinal(108)] 
		[RED("timetable")] 
		public CArray<SPresetTimetableEntry> Timetable
		{
			get => GetPropertyValue<CArray<SPresetTimetableEntry>>();
			set => SetPropertyValue<CArray<SPresetTimetableEntry>>(value);
		}

		[Ordinal(109)] 
		[RED("activePreset")] 
		public CHandle<SmartHousePreset> ActivePreset
		{
			get => GetPropertyValue<CHandle<SmartHousePreset>>();
			set => SetPropertyValue<CHandle<SmartHousePreset>>(value);
		}

		[Ordinal(110)] 
		[RED("availablePresets")] 
		public CArray<CHandle<SmartHousePreset>> AvailablePresets
		{
			get => GetPropertyValue<CArray<CHandle<SmartHousePreset>>>();
			set => SetPropertyValue<CArray<CHandle<SmartHousePreset>>>(value);
		}

		[Ordinal(111)] 
		[RED("smartHouseCustomization")] 
		public SmartHouseConfiguration SmartHouseCustomization
		{
			get => GetPropertyValue<SmartHouseConfiguration>();
			set => SetPropertyValue<SmartHouseConfiguration>(value);
		}

		[Ordinal(112)] 
		[RED("callbackID")] 
		public CUInt32 CallbackID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public SmartHouseControllerPS()
		{
			DeviceName = "LocKey#15648";
			TweakDBRecord = "Devices.SmartHouse";
			TweakDBDescriptionRecord = 130612213885;
			Timetable = new();
			AvailablePresets = new();
			SmartHouseCustomization = new SmartHouseConfiguration();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
