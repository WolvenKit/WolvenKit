using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NetworkAreaControllerPS : MasterControllerPS
	{
		[Ordinal(108)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(109)] 
		[RED("visualizerID")] 
		public CUInt32 VisualizerID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(110)] 
		[RED("hudActivated")] 
		public CBool HudActivated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(111)] 
		[RED("currentlyAvailableCharges")] 
		public CInt32 CurrentlyAvailableCharges
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(112)] 
		[RED("maxAvailableCharges")] 
		public CInt32 MaxAvailableCharges
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public NetworkAreaControllerPS()
		{
			RevealDevicesGrid = false;
			DeviceName = "DBGNetworkName";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
