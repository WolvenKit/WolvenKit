using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MediaDeviceControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(104)] 
		[RED("previousStation")] 
		public CInt32 PreviousStation
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(105)] 
		[RED("activeChannelName")] 
		public CString ActiveChannelName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(106)] 
		[RED("dataInitialized")] 
		public CBool DataInitialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(107)] 
		[RED("amountOfStations")] 
		public CInt32 AmountOfStations
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(108)] 
		[RED("activeStation")] 
		public CInt32 ActiveStation
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
