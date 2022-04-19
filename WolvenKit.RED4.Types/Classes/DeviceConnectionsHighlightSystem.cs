using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DeviceConnectionsHighlightSystem : gameScriptableSystem
	{
		[Ordinal(0)] 
		[RED("highlightedDeviceID")] 
		public entEntityID HighlightedDeviceID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("highlightedConnectionsIDs")] 
		public CArray<entEntityID> HighlightedConnectionsIDs
		{
			get => GetPropertyValue<CArray<entEntityID>>();
			set => SetPropertyValue<CArray<entEntityID>>(value);
		}

		public DeviceConnectionsHighlightSystem()
		{
			HighlightedDeviceID = new();
			HighlightedConnectionsIDs = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
