using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MediaDeviceControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(107)] 
		[RED("previousStation")] 
		public CInt32 PreviousStation
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(108)] 
		[RED("activeChannelName")] 
		public CString ActiveChannelName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(109)] 
		[RED("dataInitialized")] 
		public CBool DataInitialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(110)] 
		[RED("amountOfStations")] 
		public CInt32 AmountOfStations
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(111)] 
		[RED("activeStation")] 
		public CInt32 ActiveStation
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public MediaDeviceControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
