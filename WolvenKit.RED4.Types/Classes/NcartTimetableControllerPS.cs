using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NcartTimetableControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(104)] 
		[RED("ncartTimetableSetup")] 
		public NcartTimetableSetup NcartTimetableSetup
		{
			get => GetPropertyValue<NcartTimetableSetup>();
			set => SetPropertyValue<NcartTimetableSetup>(value);
		}

		[Ordinal(105)] 
		[RED("currentTimeToDepart")] 
		public CInt32 CurrentTimeToDepart
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public NcartTimetableControllerPS()
		{
			DeviceName = "LocKey#1653";
			TweakDBRecord = 96749304508;
			TweakDBDescriptionRecord = 147694950908;
			NcartTimetableSetup = new() { DepartFrequency = 5, UiUpdateFrequency = 1 };
		}
	}
}
