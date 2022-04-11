using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleRadioSongChanged : redEvent
	{
		[Ordinal(0)] 
		[RED("radioSongName")] 
		public CName RadioSongName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
