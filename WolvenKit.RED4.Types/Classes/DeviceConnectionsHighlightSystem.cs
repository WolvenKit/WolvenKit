using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeviceConnectionsHighlightSystem : gameScriptableSystem
	{
		private entEntityID _highlightedDeviceID;
		private CArray<entEntityID> _highlightedConnectionsIDs;

		[Ordinal(0)] 
		[RED("highlightedDeviceID")] 
		public entEntityID HighlightedDeviceID
		{
			get => GetProperty(ref _highlightedDeviceID);
			set => SetProperty(ref _highlightedDeviceID, value);
		}

		[Ordinal(1)] 
		[RED("highlightedConnectionsIDs")] 
		public CArray<entEntityID> HighlightedConnectionsIDs
		{
			get => GetProperty(ref _highlightedConnectionsIDs);
			set => SetProperty(ref _highlightedConnectionsIDs, value);
		}
	}
}
