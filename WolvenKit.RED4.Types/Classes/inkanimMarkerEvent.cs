using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkanimMarkerEvent : inkanimEvent
	{
		[Ordinal(1)] 
		[RED("markerName")] 
		public CName MarkerName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
