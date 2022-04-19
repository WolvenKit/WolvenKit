using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MediaDeviceData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("initialStation")] 
		public CInt32 InitialStation
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("amountOfStations")] 
		public CInt32 AmountOfStations
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("activeChannelName")] 
		public CString ActiveChannelName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(3)] 
		[RED("isInteractive")] 
		public CBool IsInteractive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public MediaDeviceData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
