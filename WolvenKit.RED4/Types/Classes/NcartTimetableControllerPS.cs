using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NcartTimetableControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(107)] 
		[RED("ncartTimetableSetup")] 
		public NcartTimetableSetup NcartTimetableSetup
		{
			get => GetPropertyValue<NcartTimetableSetup>();
			set => SetPropertyValue<NcartTimetableSetup>(value);
		}

		[Ordinal(108)] 
		[RED("currentTimeToDepart")] 
		public CInt32 CurrentTimeToDepart
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(109)] 
		[RED("currentLine")] 
		public CInt32 CurrentLine
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public NcartTimetableControllerPS()
		{
			DeviceName = "LocKey#1653";
			TweakDBRecord = "Devices.NcartTimetable";
			TweakDBDescriptionRecord = "device_descriptions.NcartTimetable";
			NcartTimetableSetup = new NcartTimetableSetup();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
