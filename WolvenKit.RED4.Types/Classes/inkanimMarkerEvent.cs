using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkanimMarkerEvent : inkanimEvent
	{
		private CName _markerName;

		[Ordinal(1)] 
		[RED("markerName")] 
		public CName MarkerName
		{
			get => GetProperty(ref _markerName);
			set => SetProperty(ref _markerName, value);
		}
	}
}
